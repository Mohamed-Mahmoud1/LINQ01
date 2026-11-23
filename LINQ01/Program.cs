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

            #region Q5

            //var result = Source.ProductList
            //  .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");


            #endregion

            #region Q6

            //var result = Source.ProductList
            // .Select(p=> new {Name= p.ProductName,price= p.UnitPrice , StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"});


            #endregion


            #region Q7

            //var result = Source.ProductList
            // .Select((p,i)=>$"{i + 1}. {p.ProductName}");


            #endregion

            #region Q8

            var result = Source.ProductList
            .OrderBy(p => p.Category)
            .ThenByDescending(p => p.UnitPrice);


            #endregion


        

        }
    }
}
