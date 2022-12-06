using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        IList<IItemShippingTarget> Targets { get; set; }
        IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }


    }
}
