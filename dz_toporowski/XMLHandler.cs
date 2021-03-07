using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_toporowski
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Вы открыли XML файл!");
        }
        public override void Save()
        {
            Console.WriteLine("Нажмите 's' для сохранения");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.WriteLine("\nВы сохранили файл");
            }
        }
        public override void Create()
        {
            Console.WriteLine("Нажмите 'N' для создания файла");
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("Вы создали новый файл");
            }
        }
        public override void Change()
        {
            Console.WriteLine("Редактирование недоступно");
        }
    
    }
}
