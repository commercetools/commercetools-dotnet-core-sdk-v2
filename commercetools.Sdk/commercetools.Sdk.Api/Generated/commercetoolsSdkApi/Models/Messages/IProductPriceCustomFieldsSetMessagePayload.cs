using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessagePayload))]
    public partial interface IProductPriceCustomFieldsSetMessagePayload : IMessagePayload
    {
        string PriceId { get; set; }

        long VariantId { get; set; }

        bool Staged { get; set; }

        ICustomFields CustomField { get; set; }

        string OldTypeId { get; set; }

    }
}
