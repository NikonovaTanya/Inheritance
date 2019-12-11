using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public void openDocument()
        {
            Console.WriteLine("Документ открыт"); 
        }
        public virtual  void editDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual  void saveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про"); 
        }
    }
}
