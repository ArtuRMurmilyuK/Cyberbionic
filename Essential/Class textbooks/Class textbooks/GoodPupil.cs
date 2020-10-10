using System;

namespace Class_textbooks
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil: Study-Good");
        } 
        public override void Read()
        {
            Console.WriteLine("GoodPupil: Read-Good");
        } public override void Write()
        {
            Console.WriteLine("GoodPupil: Write-Good");
        } public override void Relax()
        {
            Console.WriteLine("GoodPupil: Relax-Good");
        }
    }
}
