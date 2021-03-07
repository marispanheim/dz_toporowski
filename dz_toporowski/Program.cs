using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_toporowski

{

    class Program
    {
        static void Main(string[] args)
        {

            TXTHandler txt = new TXTHandler();
            DOCHandler doc = new DOCHandler();
            XMLHandler xml = new XMLHandler();
            Console.WriteLine("Выберете формат файла : TXT/DOC/XML ");



            //if (Console.ReadLine() == "TXT" || Console.ReadLine() == "txt")
            //{
            //    txt.Create();
            //}


            //if (Console.ReadLine() == "DOC" || Console.ReadLine() == "doc")
            //{
            //    txt.Create();
            //}

            //if (Console.ReadLine() == "XML" || Console.ReadLine() == "xml")
            //{
            //    txt.Create();
            //}
            switch (Console.ReadLine())
            {
                case "TXT":
                    txt.Create();
                        break;
                case "txt":
                    txt.Create();
                    break;
                case "DOC":
                    txt.Create();
                    break;
                case "doc":
                    doc.Create();
                    break;
                case "XML":
                    xml.Create();
                    break;
                case "xml":
                    xml.Create();
                    break;
                default:
                    break;
            }
        }
    }
}
