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
                    RelationDiv.Visible = false;
                    RelationGrid.Visible = false;
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
                    if (cbOnOff.Checked == true) //Check to see if On/off is checked
                    {
                        if (usersShoppingCart.Get_OnOff(cartId, cartUpdates[i].AttributeId) == true) //If checked and currently on, turn off
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
                        cartUpdates[i].OnOff = usersShoppingCart.Get_OnOff(cartId, cartUpdates[i].AttributeId);
                    }
                    //cartUpdates[i].OnOff = cbOnOff.Checked;

                }
                usersShoppingCart.UpdateVirusDescriptionDatabase(cartId, cartUpdates);
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

        public void Build_Virus()
        {
            AttributeContext _db = new AttributeContext();
            List<List<int>> grid= new List<List<int>>();
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
                    //var Entries = (from p in _db.MatrixRow select p);
                    //IQueryable<MatrixRow> Row = (from p in _db.MatrixRow where p.AttributeID == currentID select p);
                    MatrixRow Row = (from p in _db.MatrixRow where p.AttributeID == currentID select p).SingleOrDefault();
                   // var Row = _db.MatrixRow.here()
                    //List<MatrixRow> list = new List<MatrixRow>(Row);
                    List<int> Columns = CheckRow(Row);
                    connectionsDictionary.Add(cartUpdates[i].AttributeId, Columns);
                    //ConnectionsLbl.Text = Columns;
                    //RelationGrid.DataSource = list;
                    //RelationGrid.DataBind();
                    //grid.Add(Columns);

                }
                //return gridList;
                RelationGrid.DataSource = connectionsDictionary;
                RelationGrid.DataBind();
            }
        }
        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            RelationDiv.Visible = false;
            RelationGrid.Visible = false;
            RelationGrid.DataSource = null;
            RelationGrid.DataBind();
        }
        protected void BuildBtn_Click(object sender, EventArgs e)
        {
            RelationDiv.Visible = true;
            RelationGrid.Visible = true;
            Build_Virus();
        }

        private List<int> CheckRow(MatrixRow Row){
            List<int> list = new List<int>();

            if (Row.A1 == true) list.Add(1);
            if (Row.A2 == true) list.Add(2);
            if (Row.A3 == true) list.Add(3);
            if (Row.A4 == true) list.Add(4);
            if (Row.A5 == true) list.Add(5);
            if (Row.A6 == true) list.Add(6);
            if (Row.A7 == true) list.Add(7);
            if (Row.A8 == true) list.Add(8);
            if (Row.A9 == true) list.Add(9);
            if (Row.A10 == true) list.Add(10);
            if (Row.A11 == true) list.Add(11);
            if (Row.A12 == true) list.Add(12);
            if (Row.A13 == true) list.Add(13);
            if (Row.A14 == true) list.Add(14);
            if (Row.A15 == true) list.Add(15);
            if (Row.A16 == true) list.Add(16);
            if (Row.A17 == true) list.Add(17);
            if (Row.A18 == true) list.Add(18);
            if (Row.A19 == true) list.Add(19);
            if (Row.A20 == true) list.Add(20);
            if (Row.A21 == true) list.Add(21);
            if (Row.A22 == true) list.Add(22);
            if (Row.A23 == true) list.Add(23);
            if (Row.A24 == true) list.Add(24);
            if (Row.A25 == true) list.Add(25);
            if (Row.A26 == true) list.Add(26);
            if (Row.A27 == true) list.Add(27);
            if (Row.A28 == true) list.Add(28);
            if (Row.A29 == true) list.Add(29);
            if (Row.A30 == true) list.Add(30);
            if (Row.A31 == true) list.Add(31);
            if (Row.A32 == true) list.Add(32);
            if (Row.A33 == true) list.Add(33);
            return list;
        }
    }
}