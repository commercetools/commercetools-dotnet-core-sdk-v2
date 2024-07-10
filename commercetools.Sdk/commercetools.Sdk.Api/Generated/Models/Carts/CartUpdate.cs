using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartUpdate : ICartUpdate
    {
        public long Version { get; set; }

        public IList<ICartUpdateAction> Actions { get; set; }
        public IEnumerable<ICartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
