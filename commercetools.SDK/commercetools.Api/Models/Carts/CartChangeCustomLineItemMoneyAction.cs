using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeCustomLineItemMoney")]
    public partial class CartChangeCustomLineItemMoneyAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
        public CartChangeCustomLineItemMoneyAction()
        { 
           this.Action = "changeCustomLineItemMoney";
        }
    }
}
