namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .Select(p => new { p.ProductName, p.UnitPrice });
            #endregion


            #region Q2

            //var result = Source.ProductList
            //    .Select(p => p.ProductName);

            #endregion

            #region Q3

            //var result = Source.ProductList
            //  .OrderBy(p =>p.UnitPrice)
            //  .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Q4

            //var result = Source.ProductList
            //  .Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);


            #endregion

          

       

        }
    }
}
