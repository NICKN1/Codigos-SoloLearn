using System;

namespace Codigos_Sololearn
{
    class Program
    {
        static void codigo1()
        {
            /*============DESAFIO============
            We are going to write a program that will calculate the area of ​​a circle.
            The area enclosed by a circle of radius r is πr², where π (pi) is the constant ratio
            of the circumference of any circle to its diameter, and r is the radius.
            The given program declares a constant pi variable with a value of 3.14.
            Complete the program to take the radius as input, then calculate and output the area 
            of the circle.
            */
            //The value of const PI cannot be changed during program execution
            const double pi = 3.14;
            //Where radius take the input
            double radius = double.Parse(Console.ReadLine());
            double result = 0;
            
            result = radius * radius;
            Console.WriteLine(result * pi);
            
        }

        static void desafio2()
        {
            /*============DESAFIO============
            You are an elementary school teacher and explaining multiplication to students.
            You are going to use multiplication by 3 as your example.
            The program you are given takes N number as input. Write a program to output all numbers
            from 1 to N, replacing all numbers that are multiples of 3 by "*".
            */
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            
            while(x <= number)
            {
                //minha condição, se o resto da divisão de X com 3 for igual a 0, continue
                if(x % 3 == 0)
                {
                    Console.Write("*"); 
                }
                else{
                Console.Write(x);
                }
                x++;
            }
        }

        static int exemploMetodoRecursivo(int num)
        {
            //Neste Exemplo de metodo recursivo usando o calculo fatorial 

            //se o argumento for 1, retorne 1, pois o fatorial dele é 1
            if(num == 1){
            return 1;
            }
            // caso seja != 1 multiplique o argumento pelo metodo com o mesmo argumento -1
            //Ex: argumento 4---> 4*3*2*1
            return num * exemploMetodoRecursivo(num - 1);

            //Chamando no metodo MAIN: WriteLine(exemplo(4));
            //retornando o valor: 24
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(exemploMetodoRecursivo(4));
        }
    }
}
