using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void saveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
