using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime agora=DateTime.Now;
            TimeSpan MaisTarde= new TimeSpan(6, 30, 00);
            Console.Write($"Agora é: {agora}, Mais tarde é: ");
            Console.WriteLine(agora + MaisTarde);
            
            
            
        }
    }
}
