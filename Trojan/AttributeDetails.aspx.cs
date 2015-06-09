﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Models;
using System.Web.ModelBinding;

namespace Trojan
{
    public partial class AttributeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Trojan.Models.Attribute> GetAttribute(
                            [QueryString("AttributeID")] int? AttributeId,
                            [RouteData] string AttributeName)
        {
            var _db = new Trojan.Models.AttributeContext();
            IQueryable<Trojan.Models.Attribute> query = _db.Attributes;
            if (AttributeId.HasValue && AttributeId > 0)
            {
                query = query.Where(p => p.AttributeID == AttributeId);
            }
            else if (!String.IsNullOrEmpty(AttributeName))
            {
                query = query.Where(p =>
                          String.Compare(p.AttributeName, AttributeName) == 0);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}