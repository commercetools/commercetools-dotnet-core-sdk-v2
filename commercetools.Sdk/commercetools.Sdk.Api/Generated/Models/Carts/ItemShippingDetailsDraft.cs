using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public IList<IItemShippingTarget> Targets { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }

    }
}
