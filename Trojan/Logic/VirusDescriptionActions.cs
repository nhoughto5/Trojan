using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trojan.Models;

namespace Trojan.Logic
{
    public class VirusDescriptionActions : IDisposable
    {
        public string VirusDescriptionID { get; set; }

        private AttributeContext _db = new AttributeContext();

        public const string DescriptionSessionKey = "VirusId";

        public void AddToVirus(int id)
        {
            // Retrieve the product from the database.           
            VirusDescriptionID = GetVirusId();

            var virItem = _db.VirusDescriptionItems.SingleOrDefault(
                c => c.VirusId == VirusDescriptionID
                && c.AttributeId == id);
            if (virItem == null)
            {
                //If the selected Attribute is not already included in the description
                //Add it and activate it's On_Off Status                 
                virItem = new Virus_Item
                {
                    ItemId = Guid.NewGuid().ToString(),
                    AttributeId = id,
                    VirusId = VirusDescriptionID,
                    Attribute = _db.Attributes.SingleOrDefault(
                     p => p.AttributeID == id),
                     On_Off = true,
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

        public List<Virus_Item> GetDescriptionItems()
        {
            VirusDescriptionID = GetVirusId();

            return _db.VirusDescriptionItems.Where(
                c => c.VirusId == VirusDescriptionID).ToList();
        }

        public int GetTotal()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply product price by quantity of that product to get        
            // the current price for each of those products in the cart.  
            // Sum all product price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? 1: 0)).Sum();
            return total ?? 0;
        }
        public int getTotalF_in()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply product price by quantity of that product to get        
            // the current price for each of those products in the cart.  
            // Sum all product price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? virusItems.Attribute.F_in : 0)).Sum();
            return total ?? 0;
        }
        public int getTotalF_out()
        {
            VirusDescriptionID = GetVirusId();
            // Multiply product price by quantity of that product to get        
            // the current price for each of those products in the cart.  
            // Sum all product price totals to get the cart total.   
            int? total = 0;
            total = (int?)(from virusItems in _db.VirusDescriptionItems where virusItems.VirusId == VirusDescriptionID select (int?)(virusItems.On_Off == true ? virusItems.Attribute.F_out : 0)).Sum();
            return total ?? 0;
        }
    }
    }
