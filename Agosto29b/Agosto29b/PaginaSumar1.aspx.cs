using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agosto29b
{
  public partial class PaginaSumar1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      // 1) leer la informacion
      // 1.1) leer el cuadro de texto y lo voy a guarda en un entero
      int numero1=Convert.ToInt32(Txt1.Text);
      int numero2= Convert.ToInt32(Txt2.Text);

      // 2) procesarla
      int suma=numero1+numero2;

      // 3) regresar el resultado
      LabelResultado.Text=suma.ToString();



    }
  }
}
