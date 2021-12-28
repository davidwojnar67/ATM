using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUI {
   public class CreateAccMethods {

      public double RandomMonthlyInterest() {
         Random random = new();
         return Convert.ToDouble(random.Next(200, 300))/100;
      }

   }
}
