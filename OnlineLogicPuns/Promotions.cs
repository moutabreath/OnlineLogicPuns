using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLogicPuns
{

   class PromotionsResult
   {

       /*
        * Complete the 'getNumberOfOptions' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER_ARRAY priceOfJeans
        *  2. INTEGER_ARRAY priceOfShoes
        *  3. INTEGER_ARRAY priceOfSkirts
        *  4. INTEGER_ARRAY priceOfTops
        *  5. INTEGER dollars
        */

       public static long GetNumberOfOptions(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirts, List<int> priceOfTops, int dollars)
       {
           if (dollars < 0)
           {
               return int.MinValue;
           }
           if (dollars == 0 || priceOfJeans.Count == 0 && priceOfShoes.Count == 0 && priceOfSkirts.Count == 0 && priceOfTops.Count == 0)
           {
               return 0;
           }
           return Math.Max
         (
             1 + Math.Max(
                 GetNumberOfOptions(TrimList(priceOfJeans), priceOfShoes, priceOfSkirts, priceOfTops, dollars - priceOfJeans.LastOrDefault()),
                 GetNumberOfOptions(priceOfJeans, TrimList(priceOfJeans), priceOfSkirts, priceOfTops, dollars - priceOfShoes.LastOrDefault())

             )
         ,
             1 + Math.Max(
                 GetNumberOfOptions(priceOfJeans, priceOfShoes, TrimList(priceOfSkirts).ToList(), priceOfTops, dollars - priceOfSkirts.LastOrDefault()),
                 GetNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, TrimList(priceOfTops).ToList(), dollars - priceOfTops.LastOrDefault())
             )
         );
       }

       private static List<int> TrimList(List<int> listToTrim)
       {
           if (listToTrim.Count >= 1)
           {
               return listToTrim.Take(listToTrim.Count - 1).ToList();
           }
           return listToTrim;
       }
   }

}
