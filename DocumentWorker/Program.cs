using System;

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker document;
            Console.WriteLine("Введите ключ: 0 - бесплатная версия, 1 - pro-версия, 2 - exp-версия. 9 - выход из программы");
            int key = int.Parse(Console.ReadLine());
            do {
                switch (key)
                {
                    case 0:
                        {
                            document = new DocumentWorker();
                            document.openDocument();
                            document.editDocument();
                            document.saveDocument();
                            break;

                        }
                    case 1:
                        { document = new ProDocumentWorker();
                            document.openDocument();
                            document.editDocument();
                            document.saveDocument();
                            break;
                        }
                    case 2:
                        {
                            document = new ExpertDocumentWorker();
                            document.openDocument();
                            document.saveDocument();
                            break;
                        }
                    default:
                        {
                            break;

                        }
                }
                key = int.Parse(Console.ReadLine());
            } while (key != 9);
        }
    }
}
