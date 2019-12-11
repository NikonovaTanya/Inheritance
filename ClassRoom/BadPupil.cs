using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class BadPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("BadPupil Study");
        }
        public override void Read()
        { Console.WriteLine("BadPupil Read");
        }
        public override void Write()
        { Console.WriteLine("BadPupil Write");
        }
        public override void Relax()
        { Console.WriteLine("BadPupil Relax");
        }
    }
}
