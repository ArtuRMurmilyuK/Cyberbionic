using System;

namespace EmployeeBonus
{
    static class Accauntant
    {
        public static bool AskForBonus(int worker, int hours)
        {
            return !(worker >= hours);
        }

        public static string Bonus()
        {
            return (AskForBonus((int)Post.Mechanics, 101) == true
                ? "The employee deserves a bonus"
                : "The employee did not deserve the bonus");
        }
    }
}