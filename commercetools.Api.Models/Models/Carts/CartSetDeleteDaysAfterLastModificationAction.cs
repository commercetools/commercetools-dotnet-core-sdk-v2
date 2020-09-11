using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetDeleteDaysAfterLastModificationAction : CartUpdateAction
    {
        public int DeleteDaysAfterLastModification { get; set;}
    }
}
