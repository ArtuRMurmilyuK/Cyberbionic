using System;

namespace EmployeeBonus
{
    static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker >= hours)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Bonus()
        {
            Console.WriteLine(AskForBonus(Post.Mechanics, 101) == true
                ? "The employee deserves a bonus"
                : "The employee did not deserve the bonus");
        }
    }
}