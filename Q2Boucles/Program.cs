
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] moves = new string[32];

        for (int i = 0; i < moves.Length; i++)
        {
            Console.WriteLine("Entre un pas de danse (mettre done pour arrêter la saisie) : ");
            string pas = Console.ReadLine();

            if (pas == "done")
            {
                break;
            } else
            {
                moves[i] = pas;
            }
        }

        Console.WriteLine("Nombre d'itération ?");
        int interation = Convert.ToInt32(Console.ReadLine());
        for (int i = 0;i < interation; i++)
        {
            foreach (string move in moves) {
                Console.Write($"{move} ");
                //Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}