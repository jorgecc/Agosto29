using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agosto29
{
  public partial class PaginaSumar : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      // leer los cuadros de texto
      string numero1=TextBox1.Text;
      string numero2=TextBox2.Text;
      // sumar.
      string sumar=numero1+numero2;
      // mostrar la suma en el objeto label.
      Label1.Text=sumar;


    }
  }
}
