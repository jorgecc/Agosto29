using Agosto29b.Models;
using Agosto29b.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agosto29b
{
  public partial class PaginaSumar2 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      // 1) Leer la informacion y guardarla en un MODELO
      Calculadora objeto=CalculadoraSrv.Factory(Txt1.Text,Txt2.Text);

      // 2) Llamar a las funciones de SERVICIO
      int suma=CalculadoraSrv.Sumar(objeto);

      // 3) Muestro los resultados
      LabelResultado.Text=suma.ToString();

    }
  }
}
