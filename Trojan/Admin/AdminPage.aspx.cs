using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.TrojanDataBase;
using Trojan.Logic;

namespace Trojan.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string attributeAction = Request.QueryString["AttributeAction"];
            if (attributeAction == "add")
            {
                LabelAddStatus.Text = "Attribute added!";
            }

            if (attributeAction == "remove")
            {
                LabelRemoveStatus.Text = "Attribute removed!";
            }
        }

        protected void AddAttributeButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Catalog/Images/");
            if (AttributeImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(AttributeImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    AttributeImage.PostedFile.SaveAs(path + AttributeImage.FileName);
                    // Save to Images/Thumbs folder.
                    AttributeImage.PostedFile.SaveAs(path + "Thumbs/" + AttributeImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add attribute data to DB.
                AddAttributes attributes = new AddAttributes();
                bool addSuccess = attributes.AddAttribute(AddAttributeName.Text, AddAttributeDescription.Text,
                    AddAttributeF_in.Text, AddAttributeF_out.Text, DropDownAddCategory.SelectedValue, AttributeImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?AttributeAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new attribute to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new Trojan.TrojanDataBase.TrojanDBContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetAttributes()
        {
            var _db = new Trojan.TrojanDataBase.TrojanDBContext();
            IQueryable query = _db.Attributes;
            return query;
        }

        protected void RemoveAttributeButton_Click(object sender, EventArgs e)
        {
            using (var _db = new Trojan.TrojanDataBase.TrojanDBContext())
            {
                int attributeId = Convert.ToInt16(DropDownRemoveAttribute.SelectedValue);
                var myItem = (from c in _db.Attributes where c.AttributeId == attributeId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Attributes.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?AttributeAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate attribute.";
                }
            }
        }
    }
}