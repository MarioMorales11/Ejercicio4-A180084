using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularArea
{
    /// <summary>
    /// Descripción breve de AreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal Cuadrado(decimal Base, decimal Altura)
        {
            CalcularArea c = new CalcularArea();
            {
                c.num1 = Base;
                c.num2 = Altura;
            }
            return c.Cuadrado();
        }
        [WebMethod]
        public decimal Triangulo(decimal Base, decimal Altura)
        {
            CalcularArea c = new CalcularArea();
            return c.Triangulo(Base, Altura);
        }
        [WebMethod]
        public decimal Circulo(double Radio)
        {
            CalcularArea c = new CalcularArea();
            return c.Circulo(Radio);
        }
    }
}
