using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantSkuSetMessagePayload))]
    public partial interface IVariantSkuSetMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        string Sku { get; set; }

        string OldSku { get; set; }

        bool Staged { get; set; }

    }
}
