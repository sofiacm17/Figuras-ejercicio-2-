using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras__Ejercicio_2_
{
    class FIGURAS
    {
        //declaramos las variables
        double area = 0;
        double lado = 0;
        double ancho = 0;
        double radio = 0;

        public void areaCuadrado()
        {
            Console.WriteLine("Añade el lado");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El resultado del area es:" + area);

        }
        public void arearectangulo()
        {
            Console.WriteLine("Añade el largo");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Añade el ancho");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = lado * ancho;
            Console.WriteLine("El resultado del area es:" + area);

        }
        public void areaCirculo()
        {
            Console.WriteLine("Añade el radio");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El resultado del area es:" + area);
        }
    }
}
