using System;

namespace YourNamespace
{
    class YourClass
    {
        public static void Main (string[] args)
        {
            int num1 = 0;
            int num2 = 1;

            Console.Write("Cantidad de Numeros de la Serie Fibonacci: ");
            int numUser = int.Parse(Console.ReadLine());

            for (int i = 0; i < numUser; i++){
                int flag = num1;
                num1 = num2;
                num2 = flag + num1;
                // 0 , 1, 
                Console.Write(num1+ ", ");
            }
        }
    } 
}
