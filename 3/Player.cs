using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Player : IRecodable, IPlayable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Нажмите 'p', чтобы поставить запись на паузу");
            if (Console.ReadKey().Key == ConsoleKey.P)
            {
                Console.WriteLine("\nЗапись остановлена");
            }
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Нажмите 'u', чтобы поставить воспроизведение на паузу");

            if (Console.ReadKey().Key == ConsoleKey.U)
            {
                Console.WriteLine("\nВоспроизведение остановлено");
            }
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Нажмите 's', чтобы остановить воспроизведение");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.WriteLine("\nВоспроизведение остановлено");
            }
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Нажмите 'q', чтобы оставить запись");
            if (Console.ReadKey().Key == ConsoleKey.Q)
            {
                Console.WriteLine("\nЗапись остановлена");
            }
        }
        void IPlayable.Play()
        {
            Console.WriteLine("Нажмите 'w', чтобы начать воспроизведение");
            if (Console.ReadKey().Key == ConsoleKey.W)
            {
                Console.WriteLine("\nВоспроизведение начато");
            }
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Нажмите 'r', чтобы начать запись");
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.WriteLine("\nЗапись начата");
            }
        }
    }
}
