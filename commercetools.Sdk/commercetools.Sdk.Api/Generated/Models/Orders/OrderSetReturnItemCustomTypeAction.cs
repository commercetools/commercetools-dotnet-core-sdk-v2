using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnItemCustomTypeAction : IOrderSetReturnItemCustomTypeAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string ReturnItemKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetReturnItemCustomTypeAction()
        {
            this.Action = "setReturnItemCustomType";
        }
    }
}
