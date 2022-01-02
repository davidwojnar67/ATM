using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUI {
   public class HomeMethods {
      public string LoggedUsername { get; private set; }

      public HomeMethods(string loggedUsername) {
         LoggedUsername = loggedUsername;
      }
   }
}
