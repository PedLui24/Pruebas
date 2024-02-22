using System;
using System.Collections.Generic;

namespace YourNamespace
{
    class YourClass
    {
        public static void Main (string[] args)
        {
            
            int sumaTotal = 0;
            int[] numeros2 = {1, 2, 3, 4, 5};
            
            for(int i= 0; i < numeros2.Length; i++){
                sumaTotal = sumaTotal + numeros2[i];
            }
            int res = sumaTotal / numeros2.Length; 

            Console.WriteLine("La Media es " + res);
        } 
    }

}