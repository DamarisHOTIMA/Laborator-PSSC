﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_PSSC.Domain
{
    public record UnvalidatedCart(ClientID Client, List<Product> Products);

}
