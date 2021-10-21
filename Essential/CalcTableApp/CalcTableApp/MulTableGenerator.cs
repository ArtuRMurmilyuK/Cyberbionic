using System;

namespace CalcTableApp
{
    internal class MulTableGenerator
    {
        public string[][] Create(int from, int till)
        {
            
            string[][] str = new string[till - from][];

            for (int i = 0; i < str.Length; i++, from++)
            {
                str[i] = new string[10];

                for (int j = 0, k = 1; j < 10; j++, k++)
                {
                    if (from * k >= 10 && k < 10)
                    {
                        str[i][j] = $" {from} *  {k} = {from * k} ";
                    }
                    else if (from * k >= 10)
                    {
                        str[i][j] = $" {from} * {k} = {from * k} ";
                    }
                    else
                    {
                        str[i][j] = $" {from} *  {k} =  {from * k} ";
                    }
                }
            }
            return str;
        }
    }
}