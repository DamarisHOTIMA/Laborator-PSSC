using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_LivrareComanda
{
    
        public record DeliveryAddress
        {
            public string deliveryAddress;
            public DeliveryAddress(string addr) { deliveryAddress = addr; }
            public override string ToString() { return deliveryAddress; }
        }
    
}
