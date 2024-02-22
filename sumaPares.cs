using System;

namespace YourNamespace
{
    class YourClass
    {
        public static void Main (string[] args)
        {
            int total = 0;
            
            Console.Write("Cantidad de Numeros Pares: ");
            int numUser = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= (numUser*2); i++)
            {
                if((i%2)==0){
                    total = total + i;   
                }
            }

            Console.WriteLine("Suma total " + total);
        } 
    }

}