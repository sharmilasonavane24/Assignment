using System.Collections.Generic;
using Crm.Infra.Models;

namespace Crm.Infra.Database
{
  public  static class CutomerData
    { 
         public static List<Customer> CustomerList;
        static CutomerData()
        {
        CustomerList = new List<Customer>()
            {
                new Customer(){id=1,Name = "Sharmila"},
                new Customer(){id=2,Name = "Amit"},
                new Customer(){id=3,Name = "Ashley"}
            };
        }

       
    }
 
}
