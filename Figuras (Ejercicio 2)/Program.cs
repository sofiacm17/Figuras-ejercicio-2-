using System;

namespace Figuras__Ejercicio_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("¿Desea realizar el cálculo del área de alguna figura? <S/N>");
                    string valor = Console.ReadLine();
                    if (valor == "S"|| valor=="s")
                    {
                        Console.WriteLine("Elija el área de la figura que desea calcular: \n" + "1.Área de un cuadrado \n" + "2.Área de un rectangulo \n" + "3.Área de un circulo");
                        string opcion = Console.ReadLine();
                        FIGURAS Figuras = new FIGURAS(); //instanciando a la clase figuras

                        switch (opcion)
                        {
                            case "1": Figuras.areaCuadrado(); break;

                            case "2": Figuras.arearectangulo(); break;

                            case "3": Figuras.areaCirculo(); break;

                            default:
                                Console.WriteLine("La opción elegida no es válida");
                                break;
                        }

                        
                        n++;
                    }
                    else if(valor=="N" ||valor== "n")
                    {
                        return;
                    }

                    
                }
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha tenido un fallo, contacte con el soporte técnico" + ex.Message);
                //throw;
            }
         



        }
    }
}
