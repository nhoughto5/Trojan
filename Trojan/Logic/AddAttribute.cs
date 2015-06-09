using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trojan.Models;

namespace Trojan.Logic
{
    public class AddAttributes
    {
        public bool AddAttribute(string AttributeName, string AttributeDesc, string F_in, string F_out, string AttributeCategory, string AttributeImagePath)
        {
            var myAttribute = new Trojan.Models.Attribute();
            myAttribute.AttributeName = AttributeName;
            myAttribute.Description = AttributeDesc;
            myAttribute.F_in = Convert.ToInt32(F_in);
            myAttribute.F_out = Convert.ToInt32(F_out);
            myAttribute.ImagePath = AttributeImagePath;
            myAttribute.CategoryID = Convert.ToInt32(AttributeCategory);

            using (AttributeContext _db = new AttributeContext())
            {
                // Add Attribute to DB.
                _db.Attributes.Add(myAttribute);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}