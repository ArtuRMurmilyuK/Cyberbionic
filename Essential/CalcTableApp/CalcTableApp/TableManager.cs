namespace CalcTableApp
{
    internal class TableManager
    {
        public TabParams Analyzation(string[][] mulTab)
        {
            return new TabParams(){Width = mulTab[0][0].Length, Height = mulTab.Length};
        }
    }
}