using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldAddedMessagePayload))]
    public partial interface IProductPriceCustomFieldAddedMessagePayload : IMessagePayload
    {
        string PriceId { get; set; }

        long VariantId { get; set; }

        bool Staged { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
