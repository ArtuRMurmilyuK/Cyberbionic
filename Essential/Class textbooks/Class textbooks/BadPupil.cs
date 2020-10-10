using System;

namespace Class_textbooks
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil: Study-Bad");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil: Read-Bad");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil: Write-Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil: Relax-Bad");
        }
    }
}
