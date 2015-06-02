using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.Models;
using Trojan.Logic;

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
    }
}