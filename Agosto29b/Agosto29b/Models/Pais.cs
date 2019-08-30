using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agosto29b.Models
{
  public class Pais
  {
    public string Nombre { set; get;}
    public int Poblacion { set; get;}

    // boton derecho -> quick action -> constructor

    public Pais()
    {
    }

    public Pais(string nombre, int poblacion)
    {
      Nombre = nombre;
      Poblacion = poblacion;
    }
  }
}
