using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using static D10_mine.ListGenerators;

namespace D10_mine
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(ProductList[0]);
            ///linq to object 

            #region Where - Filteration
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;


            //Result = ProductList.Where(P => (P.UnitsInStock == 0) && (P.Category == "Meat/Poultry"));


            //Result = from P in ProductList
            //         where (P.UnitsInStock == 0) && (P.Category == "Meat/Poultry")
            //         select P;


            //Result = ProductList.Where((P, i) => P.UnitsInStock == 0 && i <= 10);

            ///Indexed Where Valid only in Fluent Syntax
            ///Can't be written using Query Expression
            ///
            #endregion

            #region Select : Transformation Operator

            ///Project\Transform every Element in Input Seq to A new Element in Output Seq of New DataType (or same Type)

            //var Result = ProductList.Select(P => P.ProductName);
            ///Product => String

            //Result = from P in ProductList
            //         select P.ProductName;

            //var Result = ProductList.Where(P => P.UnitsInStock == 0)
            //                        .Select(P => new { Id = P.ProductID, P.ProductName });

            var DiscountedLst = ProductList.Select(P => new Product()
            {
                ProductID = P.ProductID,
                Category = P.Category,
                ProductName = P.ProductName,
                UnitsInStock = P.UnitsInStock,
                UnitPrice = 0.9M * P.UnitPrice
            });

            #endregion




            foreach (var item in DiscountedLst)
               Console.WriteLine(item);


        }
    }
}
