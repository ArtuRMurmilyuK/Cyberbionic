using System;

namespace Class_textbooks
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcellentPupil: Study-excellent");
        }
        public override void Read()
        {
            Console.WriteLine("ExcellentPupil: Read-excellent");
        } 
        public override void Write()
        {
            Console.WriteLine("ExcellentPupil: Write-excellent");
        } 
        public override void Relax()
        {
            Console.WriteLine("ExcellentPupil: Relax-excellent");
        }
    }
}
