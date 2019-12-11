using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class ClassRoom
    {
        private Pupil [] student = new Pupil[5]; 
        public Pupil this [int index]
        { get
            { return student[index];
            }
            set
            {
                student[index] = value;
            }
        }
        public ClassRoom(params Pupil [] st)
        {
            student = st;
        }
        public void printStudy()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil elem in student)
                elem.Study();
        }
        public void printRead()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil elem in student)
                elem.Read();
        }
        public void printIWrite()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil elem in student)
                elem.Write();
        }
        public void printRelax()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil elem in student)
                elem.Relax();
        }
    }
}
