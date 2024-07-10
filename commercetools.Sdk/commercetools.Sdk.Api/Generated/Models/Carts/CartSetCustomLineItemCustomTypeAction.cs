using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomLineItemCustomTypeAction : ICartSetCustomLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartSetCustomLineItemCustomTypeAction()
        {
            this.Action = "setCustomLineItemCustomType";
        }
    }
}
