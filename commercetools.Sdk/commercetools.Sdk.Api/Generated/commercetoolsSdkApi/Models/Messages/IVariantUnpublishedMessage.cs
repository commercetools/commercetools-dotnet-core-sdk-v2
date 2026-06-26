using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantUnpublishedMessage))]
    public partial interface IVariantUnpublishedMessage : IMessage
    {
        IProductReference Product { get; set; }

    }
}
