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

    // evento = funcion que trabaja bajo una accion

    protected void Button1_Click(object sender, EventArgs e)
    {
      // conversion de numero a texto



      // leer los cuadros de texto
      int numero1 = Convert.ToInt32(  TextBox1.Text); // Convert
      int numero2 = Int32.Parse(TextBox2.Text);
      // sumar.
      int sumar=numero1+numero2;
      // mostrar la suma en el objeto label.
      Label1.Text=sumar.ToString();


    }
  }
}
