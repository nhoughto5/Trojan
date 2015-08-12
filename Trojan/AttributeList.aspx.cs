using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Database;
using System.Web.ModelBinding;
using System.Web.Routing;

namespace Trojan
{
    public partial class AttributeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Trojan.Database.Attribute> GetAttributes([QueryString("id")] int? CategoryId, [RouteData] string categoryName)
        {
            var _db = new Trojan.Database.TrojanDBContext();
            IQueryable <Trojan.Database.Attribute> query = _db.Attributes;

            if (CategoryId.HasValue && CategoryId > 0)
            {
                query = query.Where(p => p.CategoryId == CategoryId);
            }

            if (!String.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p =>
                                    String.Compare(p.Category.CategoryName,
                                    categoryName) == 0);
            }
            return query;
        }
    }
}