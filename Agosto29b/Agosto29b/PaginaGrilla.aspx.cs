using Agosto29b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agosto29b
{
  public partial class PaginaGrilla : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    { 
      List<Pais> paises=new List<Pais>();

      paises.Add(new Pais("Chile",17));
      paises.Add(new Pais("Argentina", 30));
      paises.Add(new Pais("Peru", 20));
      paises.Add(new Pais("Colombia", 37));

      GridView1.DataSource=paises;
      GridView1.DataBind(); //reconstruye la grilla

      DropDownList1.DataSource=paises;
      DropDownList1.DataBind();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      if(Panel1.Visible==true) { 
        Panel1.Visible=false;
      } else
      {
        Panel1.Visible = true;
      }
    }
  }
}
