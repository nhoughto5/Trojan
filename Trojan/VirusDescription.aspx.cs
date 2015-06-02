using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Models;
using Trojan.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;

namespace Trojan
{
    public partial class VirusDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (VirusDescriptionActions usersVirus = new VirusDescriptionActions())
            {
                int totalNumberofAttributes = 0;
                int totalF_in = 0;
                int totalF_out = 0;
                totalNumberofAttributes = usersVirus.GetTotal();
                totalF_in = usersVirus.getTotalF_in();
                totalF_out = usersVirus.getTotalF_out();
                if (totalNumberofAttributes > 0)
                {
                    // Display Total.
                    lblTotal.Text = String.Format("{0:d}", totalNumberofAttributes);
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    VirusDescriptionTitle.InnerText = "No Attributes Selected";
                    UpdateBtn.Visible = false;
                }
                if (totalF_in > 0)
                {
                    // Display Total.
                    lblTotalF_in.Text = String.Format("{0:d}", totalF_in);
                }
                else
                {
                    LabelTotalF_in.Text = "";
                    lblTotalF_in.Text = "";
                    VirusDescriptionTitle.InnerText = "No Attributes Selected";
                }
                if (totalF_out > 0)
                {
                    // Display Total.
                    lblTotalF_out.Text = String.Format("{0:d}", totalF_out);
                }
                else
                {
                    LabelTotalF_out.Text = "";
                    lblTotalF_out.Text = "";
                    VirusDescriptionTitle.InnerText = "No Attributes Selected";
                }
                
            }
        }

        public List<Virus_Item> GetVirusDescriptionItems()
        {
            VirusDescriptionActions actions = new VirusDescriptionActions();
            return actions.GetDescriptionItems();
        }
        public List<Virus_Item> UpdateCartItems()
        {
            using (VirusDescriptionActions usersShoppingCart = new VirusDescriptionActions())
            {
                String cartId = usersShoppingCart.GetVirusId();

                VirusDescriptionActions.VirusDescriptionUpdates[] cartUpdates = new VirusDescriptionActions.VirusDescriptionUpdates[DescriptionList.Rows.Count];
                for (int i = 0; i < DescriptionList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(DescriptionList.Rows[i]);
                    cartUpdates[i].AttributeId = Convert.ToInt32(rowValues["AttributeID"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)DescriptionList.Rows[i].FindControl("Remove");
                    cartUpdates[i].RemoveItem = cbRemove.Checked;

                    CheckBox cbOnOff = new CheckBox();
                    cbOnOff = (CheckBox)DescriptionList.Rows[i].FindControl("On_Off_CheckBox");
                    cartUpdates[i].OnOff = cbOnOff.Checked;

                }
                usersShoppingCart.UpdateVirusDescriptionDatabase(cartId, cartUpdates);
                DescriptionList.DataBind();
                lblTotal.Text = String.Format("{0:d}", usersShoppingCart.GetTotal());
                lblTotalF_in.Text = String.Format("{0:d}", usersShoppingCart.getTotalF_in());
                lblTotalF_out.Text = String.Format("{0:d}", usersShoppingCart.getTotalF_out());
                return usersShoppingCart.GetDescriptionItems();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCartItems();
        }
    }
}