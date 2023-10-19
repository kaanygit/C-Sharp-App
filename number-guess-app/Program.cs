using System;

namespace NumberGuessApplication
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Number-Guessing-Application");

            Random r=new Random();

            int winNum=r.Next(0,100);

            bool win=false;

            do{
                Console.Write("Guess a number inbetween 0 and 100 : "); 
                string s = Console.ReadLine();

                int i=int.Parse(s);

                if(i>winNum){
                    Console.WriteLine("To high! Guess Lower...");
                }else if(i<winNum){
                    Console.WriteLine("Go Low! Guess Lower...");
                }else if(i==winNum){
                    Console.WriteLine("You winn");
                    win=true;
                }
            }while(win==false);
            Console.WriteLine("Thank you playing the game");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}