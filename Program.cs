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

        static void codigo2()
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
        
        static void exemploPiramide(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)                
                {
                    Console.WriteLine(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)                
                {
                    Console.WriteLine("*" + " ");
                }

                Console.WriteLine();
            }
        }

        static void codigo3()
        {
            /*==================DESAFIO=================
            Passing the first level of a video game awards the player 1 point. For each subsequent
             level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, 
             and so on). The program you are given takes the number of passed levels as input. 
             Complete the given function to take that number as an argument, and recursively 
             calculate and return the total number of points given for all passed levels.
            */
            /*
            static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }
            */
            static int Points(int levels)
        {
            //your code goes here
            if(levels == 1)
            {
                return 1;
            }

            return levels + Points(levels - 1);

        }
        }
    
    static void codigo4()
    {
        /*================DESAFIO==============
        You are making a social network application and want to add post creation functionality.
        As a user creates a post, the text "New post" should be automatically outputted so that then
        the user can add the text he/she wants to share. The program you are given declares a Post 
        class with a text private field, and the ShowPost() method which outputs the content.
        Complete the class with
        - a constructor, which outputs "New post" as called,
        - Text property, which will allow you to get and set the value of the text field.
        */

        /*
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
        */
    /*class Post
    {
        private string text;
        
        //write a constructor here
        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        //write a property for member text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
        */
    }
    
    static void Main(string[] args)
        {

            
        }
}
}
