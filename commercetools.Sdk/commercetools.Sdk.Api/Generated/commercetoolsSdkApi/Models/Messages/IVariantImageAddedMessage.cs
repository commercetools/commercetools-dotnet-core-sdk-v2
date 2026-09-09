using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantImageAddedMessage))]
    public partial interface IVariantImageAddedMessage : IMessage
    {
        IProductReference Product { get; set; }

        IImage Image { get; set; }

        bool Staged { get; set; }

    }
}
