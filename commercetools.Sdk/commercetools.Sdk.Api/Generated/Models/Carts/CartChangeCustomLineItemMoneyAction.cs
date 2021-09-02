using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartChangeCustomLineItemMoneyAction : ICartChangeCustomLineItemMoneyAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IMoney Money { get; set; }
        public CartChangeCustomLineItemMoneyAction()
        {
            this.Action = "changeCustomLineItemMoney";
        }
    }
}
