using System;

namespace Class_textbooks
{
    class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil() );

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.ReadKey();
        }
    }
}
