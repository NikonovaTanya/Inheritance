using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class ProDocumentWorker: DocumentWorker
    {
        public override void editDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void saveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
