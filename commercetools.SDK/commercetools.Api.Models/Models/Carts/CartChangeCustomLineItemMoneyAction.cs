using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeCustomLineItemMoney")]
    public class CartChangeCustomLineItemMoneyAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
    }
}
