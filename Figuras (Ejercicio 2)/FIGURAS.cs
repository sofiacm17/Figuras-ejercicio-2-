using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras__Ejercicio_2_
{
    class FIGURAS
    {
        public decimal area { get; set; } //get y set son de tipo lectura, sintaxis para declarar un atributo
        decimal lado;
        decimal ancho;
        decimal radio;

        public void areaCuadrado()
        {
            Console.WriteLine("Añade el lado");
            lado = Convert.ToDecimal(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("el resultado del area es:" + area);

             
        }
        
    }
}
