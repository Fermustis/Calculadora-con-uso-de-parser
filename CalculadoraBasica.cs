using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace _24_02_2022_WFCalculadoraX1
{
    internal class CalculadoraBasica
    {
        double x, y, r;
        

        public CalculadoraBasica()
        {

        }

        public string Suma(double x, double y,ref double r )//paso por valor x,y Y paso por referencia
        {

            r = x + y;
            return ("suma");
        }

        public string division(double x, double y, ref double r)//paso por valor x,y Y paso por referencia
        {

            r = x / y;
            return ("suma");
        }
        public string cos(double x, double y, ref double r)//paso por valor x,y Y paso por referencia
        {

            r = Math.Cos(x);
            return ("cos");
        }
        //dos variables
        public string fu2(double x,double y, string fxy, ref double r)//paso por valor x,y Y paso por referencia
        {
            r = fuxy(x,y, fxy);
            return ("Funcion de x & y");

        }
        public double fuxy(double x,double y, string fxy)//paso por valor x,y Y paso por referencia
        {
           ExpressionParser vparser =new ExpressionParser();
            vparser.Values.Add("x", x);
            vparser.Values.Add("y", y);
            return (vparser.Parse(fxy));

        }
        //una variable
        public string fu(double x, string fx, ref double r)//paso por valor x,y Y paso por referencia
        {
            r = fux(x, fx);
            return ("Funcion de x");

        }
        public double fux(double x, string fx)//paso por valor x,y Y paso por referencia
        {
            ExpressionParser vparser = new ExpressionParser();//creando una variable
            vparser.Values.Add("x",x);// sa cadena x la represente como variable x
            return (vparser.Parse(fx));//calcula el valor numerico de la cadena hecho funcion
             

        }
    }
}
