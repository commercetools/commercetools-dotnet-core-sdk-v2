using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartLock))]
    public partial interface ICartLock
    {
        DateTime CreatedAt { get; set; }

        string ClientId { get; set; }

    }
}
