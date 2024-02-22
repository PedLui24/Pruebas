using System;
using System.Collections.Generic;

namespace YourNamespace
{
    class YourClass
    {
        public static void Main (string[] args)
        {
            int[] numeros = {1, 2, 4, 4, 5, 5, 2, 2};
            
            for(int i= 0; i < numeros.Length; i++){
                int repeat = 0;
                for(int j = 1; j < numeros.Length; j++){
                    if(numeros[i] == numeros[j]){
                        repeat++;
                    }
                }
                Console.WriteLine("El elemento " + numeros[i] + " se repite " + repeat);
            }
        } 
    }

}