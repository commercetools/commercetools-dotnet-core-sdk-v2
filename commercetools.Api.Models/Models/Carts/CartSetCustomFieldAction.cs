using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetCustomFieldAction : CartUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
