using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trojan.TrojanDataBase;
namespace Trojan
{
    public partial class Matrix : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TrojanDBContext _db = new TrojanDBContext();
            //var Entries = (from p in _db.MatrixRow select p);
            //var list = new List<Trojan.Database.MatrixRow>(Entries);
            //GridView1.DataSource = list;
            //GridView1.DataBind();
        }

    }
}