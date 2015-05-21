using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Models;
using System.Web.ModelBinding;

namespace Trojan
{
    public partial class AttributeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Trojan.Models.Attribute> GetAttributes([QueryString("id")] int? categoryId)
        {
            var _db = new Trojan.Models.AttributeContext();
            IQueryable<Trojan.Models.Attribute> query = _db.Attributes;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}