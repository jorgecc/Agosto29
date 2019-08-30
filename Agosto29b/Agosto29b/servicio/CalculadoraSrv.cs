

using Agosto29b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agosto29b.servicio
{
  public class CalculadoraSrv
  {
    // OJO (el argumento es Calculadora)
    public static int Sumar(Calculadora calc)
    {
      return calc.Num1+calc.Num2;
    }

    public static Calculadora Factory(string texto1,string texto2)
    {
      var calc=new Calculadora();
      calc.Num1=Convert.ToInt32(texto1);
      calc.Num2=Convert.ToInt32(texto2);
      return calc;
    }




  }
}
