using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessage))]
    public partial interface IProductSelectionProductRemovedMessage : IMessage
    {
        IProductReference Product { get; set; }

    }
}
