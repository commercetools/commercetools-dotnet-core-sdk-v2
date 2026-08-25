using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.EstimatedDelivery))]
    public partial interface IEstimatedDelivery
    {
        DateTime? From { get; set; }

        DateTime? Until { get; set; }

    }
}
