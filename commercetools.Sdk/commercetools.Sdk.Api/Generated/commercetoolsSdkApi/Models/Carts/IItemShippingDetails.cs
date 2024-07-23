using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ItemShippingDetails))]
    public partial interface IItemShippingDetails
    {
        IList<IItemShippingTarget> Targets { get; set; }
        IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }


        bool Valid { get; set; }

    }
}
