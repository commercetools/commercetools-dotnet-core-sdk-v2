using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartUpdate : ICartUpdate
    {
        public long Version { get; set; }

        public List<ICartUpdateAction> Actions { get; set; }
    }
}
