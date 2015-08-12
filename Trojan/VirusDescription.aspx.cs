using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Database;
using Trojan.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;

namespace Trojan
{
    public partial class VirusDescription : System.Web.UI.Page
    {
        bool Built;
        Dictionary<int, List<int>> connectionsDictionary = new Dictionary<int,List<int>>();
        protected void Page_Load(object sender, EventArgs e)
        {
            using (VirusDescriptionActions usersVirus = new VirusDescriptionActions())
            {
                int totalNumberofAttributes = 0;
                int totalF_in = 0;
                int totalF_out = 0;
                Built = false;
                Built = getBuiltStatus();
                totalNumberofAttributes = usersVirus.GetCount();
                totalF_in = usersVirus.getTotalF_in();
                totalF_out = usersVirus.getTotalF_out();
                if(!Built){
                    //RelationDiv.Visible = false;
                    //RelationGrid.Visible = false;
                }
                if (totalNumberofAttributes > 0)
                {
                    // Display Total.
                    lblTotal.Text = String.Format("{0:d}", totalNumberofAttributes);
                    VirusDescriptionTitle.InnerText = "Current Virus Total";
                    if (totalF_in > 0)
                    {
                        lblTotalF_in.Text = String.Format("{0:d}", totalF_in);
                    }
                    else
                    {
                        lblTotalF_in.Text = "0";
                    }
                    if (totalF_out > 0)
                    {
                        lblTotalF_out.Text = String.Format("{0:d}", totalF_out);
                    }
                    else
                    {
                        lblTotalF_out.Text = "0";
                    }
                }
                else
                {
                    VirusDescriptionTitle.InnerText = "No Attributes Selected";
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    LabelTotalF_in.Text = "";
                    lblTotalF_in.Text = "";
                    LabelTotalF_out.Text = "";
                    lblTotalF_out.Text = "";
                    UpdateBtn.Visible = false;
                    BuildBtn.Visible = false;
                }
                
                
            }
        }
        private bool getBuiltStatus(){
            return Built;
        }
        public List<VirusDescriptionItems> GetVirusDescriptionItems()
        {
            VirusDescriptionActions actions = new VirusDescriptionActions();
            return actions.GetDescriptionItems();
        }

        public List<VirusDescriptionItems> UpdateCartItems()
        {
            using (VirusDescriptionActions usersShoppingCart = new VirusDescriptionActions())
            {
                String virusId = usersShoppingCart.GetVirusId();

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
                    if (cbOnOff.Checked == true) //Check to see if On/off is checked
                    {
                        if (usersShoppingCart.Get_OnOff(virusId, cartUpdates[i].AttributeId) == true) //If checked and currently on, turn off
                        {
                            cartUpdates[i].OnOff = false;
                        }
                        else //If checked and currently off, turn on
                        {
                            cartUpdates[i].OnOff = true;
                        }
                        //cartUpdates[i].OnOff = cbOnOff.Checked;
                    }
                    else //if not checked, query DB for previous state
                    {
                        cartUpdates[i].OnOff = usersShoppingCart.Get_OnOff(virusId, cartUpdates[i].AttributeId);
                    }
                    //cartUpdates[i].OnOff = cbOnOff.Checked;

                }
                usersShoppingCart.UpdateVirusDescriptionDatabase(virusId, cartUpdates);
                DescriptionList.DataBind();
                lblTotal.Text = String.Format("{0:d}", usersShoppingCart.GetCount());
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
        List<int> getConnections(System.Linq.IQueryable<Matrix_Cell> Row_Values)
        {
            List<Matrix_Cell> Row = Row_Values.ToList();
            List<int> connects = new List<int>();
            foreach (var item in Row)
            {
                connects.Add(item.ColumnId);
            }
            return connects;
        }

        public void Build_Virus()
        {
            TrojanDBContext _db = new TrojanDBContext();
            List<int> tempList = new List<int>();
            int currentID;
            using (VirusDescriptionActions usersShoppingCart = new VirusDescriptionActions())
            {
                String cartId = usersShoppingCart.GetVirusId();
                VirusDescriptionActions.VirusDescriptionUpdates[] cartUpdates = new VirusDescriptionActions.VirusDescriptionUpdates[DescriptionList.Rows.Count];
                for (int i = 0; i < DescriptionList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(DescriptionList.Rows[i]);
                    cartUpdates[i].AttributeId = Convert.ToInt32(rowValues["AttributeID"]);
                    currentID = cartUpdates[i].AttributeId;
                    System.Linq.IQueryable<Matrix_Cell> Row = (from p in _db.default_Matrix where p.RowID == currentID select p);
                    tempList = getConnections(Row);
                }
            }
        }
        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            //RelationDiv.Visible = false;
            //RelationGrid.Visible = false;
            //RelationGrid.DataSource = null;
            //RelationGrid.DataBind();
        }
        protected void BuildBtn_Click(object sender, EventArgs e)
        {
            //RelationDiv.Visible = true;
            //RelationGrid.Visible = true;
            Build_Virus();
        }
    }
}