using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Trojan.TrojanDataBase;
using Trojan.TrojanDataBase;

namespace Trojan.Logic
{
    public class VirusDescriptionActions : IDisposable
    {
        public string VirusDescriptionID { get; set; }

        //private TrojanDBContext _db = new TrojanDBContext();
        private TrojanDBContext _db = new TrojanDBContext();

        public const string DescriptionSessionKey = "VirusId";

        public void AddToVirus(int id)
        {
            // Retrieve the Attribute from the database.           
            VirusDescriptionID = GetVirusId();

            var virItem = _db.VirusDescriptionItems.SingleOrDefault(
                c => c.VirusId == VirusDescriptionID
                && c.AttributeId == id);
            if (virItem == null)
            {
                //If the selected Attribute is not already included in the description
                //Add it and activate it's On_Off Status                 
                virItem = new VirusDescriptionItems
                {
                    ItemId = Guid.NewGuid().ToString(),
                    AttributeId = id,
                    VirusId = VirusDescriptionID,
                    Attrib = _db.Attributes.SingleOrDefault(
                     p => p.AttributeId == id),
                    On_Off = false,
                    DateCreated = DateTime.Now
                };

                _db.VirusDescriptionItems.Add(virItem);
            }
            else
            {
                //If the seleted Attribute is already included in the description
                //Do nothing
                //virItem.On_Off = false;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetVirusId()
        {
            if (HttpContext.Current.Session[DescriptionSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[DescriptionSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempDescriptionId = Guid.NewGuid();
                    HttpContext.Current.Session[DescriptionSessionKey] = tempDescriptionId.ToString();
                }
            }
            return HttpContext.Current.Session[DescriptionSessionKey].ToString();
        }

        public List<VirusDescriptionItems> GetDescriptionItems()
        {
            VirusDescriptionID = GetVirusId();

            return _db.VirusDescriptionItems.Where(
                c => c.VirusId == VirusDescriptionID).ToList();
        }
        public bool Get_OnOff(string cartID, int attributeID)
        {
            using (var _db = new Trojan.TrojanDataBase.TrojanDBContext())
            {
                try
                {
                    var myItem = (from c in _db.VirusDescriptionItems where c.VirusId == cartID && c.Attrib.AttributeId == attributeID select c).FirstOrDefault();
                    return myItem.On_Off;
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to query DB - " + exp.Message.ToString(), exp);
                }
            }
        }
        public int GetTotal()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply Attribute price by quantity of that Attribute to get        
            // the current price for each of those Attributes in the cart.  
            // Sum all Attribute price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? 1: 1)).Sum();
            return total ?? 0;
        }
        public int getTotalF_in()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply Attribute price by quantity of that Attribute to get        
            // the current price for each of those Attributes in the cart.  
            // Sum all Attribute price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? virusItems.Attrib.F_in : 0)).Sum();
            return total ?? 0;
        }
        public int getTotalF_out()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply Attribute price by quantity of that Attribute to get        
            // the current price for each of those Attributes in the cart.  
            // Sum all Attribute price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? virusItems.Attrib.F_out : 0)).Sum();
            return total ?? 0;
        }
        public VirusDescriptionActions GetCart(HttpContext context)
        {
            using (var virus = new VirusDescriptionActions())
            {
                virus.VirusDescriptionID = virus.GetVirusId();
                return virus;
            }
        }

        public void UpdateVirusDescriptionDatabase(String cartId, VirusDescriptionUpdates[] CartItemUpdates)
        {
            using (var db = new Trojan.TrojanDataBase.TrojanDBContext())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<VirusDescriptionItems> myVirus = GetDescriptionItems();
                    foreach (var virusItem in myVirus)
                    {
                        // Iterate through all rows within shopping cart list
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (virusItem.Attrib.AttributeId == CartItemUpdates[i].AttributeId)
                            {
                                if (CartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, virusItem.AttributeId);
                                }
                                else
                                {
                                    UpdateItem(cartId, virusItem.AttributeId, CartItemUpdates[i].OnOff);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void RemoveItem(string removeCartID, int removeAttributeID)
        {
            using (var _db = new Trojan.TrojanDataBase.TrojanDBContext())
            {
                try
                {
                    var myItem = (from c in _db.VirusDescriptionItems where c.VirusId == removeCartID && c.Attrib.AttributeId == removeAttributeID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Remove Item.
                        _db.VirusDescriptionItems.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void UpdateItem(string updateCartID, int updateAttributeID, bool OnOff)
        {
            using (var _db = new Trojan.TrojanDataBase.TrojanDBContext())
            {
                try
                {
                    var myItem = (from c in _db.VirusDescriptionItems where c.VirusId == updateCartID && c.Attrib.AttributeId == updateAttributeID select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.On_Off = OnOff;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void EmptyCart()
        {
            VirusDescriptionID = GetVirusId();
            var cartItems = _db.VirusDescriptionItems.Where(
                c => c.VirusId == VirusDescriptionID);
            foreach (var cartItem in cartItems)
            {
                _db.VirusDescriptionItems.Remove(cartItem);
            }
            // Save changes.             
            _db.SaveChanges();
        }

        public int GetCount()
        {
            VirusDescriptionID = GetVirusId();

            // Get the count of each item in the cart and sum them up          
            int? count = (from cartItems in _db.VirusDescriptionItems where cartItems.VirusId == VirusDescriptionID select (int?)(cartItems.AttributeId)).Count();
            // Return 0 if all entries are null         
            return count ?? 0;
        }

        public struct VirusDescriptionUpdates
        {
            public int AttributeId;
            public bool OnOff;
            public bool RemoveItem;
        }
        public void MigrateCart(string cartId, string userName)
        {
            var shoppingCart = _db.VirusDescriptionItems.Where(c => c.VirusId == cartId);
            foreach (VirusDescriptionItems item in shoppingCart)
            {
                item.VirusId = userName;
            }
            HttpContext.Current.Session[DescriptionSessionKey] = userName;
            _db.SaveChanges();
        }
    }
    }
