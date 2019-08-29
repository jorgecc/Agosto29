using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agosto29
{
  public partial class Pagina1 : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {
      

      TextBox1.Text="se cargo el page load";


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      TextBox1.Text="se hizo click en el boton";
    }
  }
}
