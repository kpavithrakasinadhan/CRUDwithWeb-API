using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwithWeb_API
{
    public class SuperMarketShope
    {
       public int ShopId {get;set;}
       public string Name  {get;set;}

       public string OwnerName { get; set; }
       public long NumberOfProduct { get; set; }
       public long ContactNumber  { get; set; }

       public string Emailid { get; set; }

        public string Location { get; set; }
    }
}
