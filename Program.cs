using System;

namespace U6_programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,contprimos;
            contprimos=0;
            for (int i = 0; i < 10; i++)
            {
                int contador=0;
                Console.WriteLine("Ingrese un numero por favor");
                numero=int.Parse(Console.ReadLine());
                for (int x = 1; x <=numero; x++){
                     if (numero%x==0){                
                        contador++;
                    }
                }

                if (contador==2){
                    contprimos++;
                }
            }
           Console.WriteLine("la cantidad de numeros primos es "+ contprimos); 
            
        }
    }
}
