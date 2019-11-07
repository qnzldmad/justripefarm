using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paractical07_re_
{
    class wholesale
    {
        private int quantity;
        private string supplierId;
        private DateTime purchaseDate;
        

        public int Quantity { get => quantity; set => quantity = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
      
    }
}
