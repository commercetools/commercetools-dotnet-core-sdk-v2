using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionProductRemovedMessage))]
    public partial interface IProductSelectionProductRemovedMessage : IMessage
    {
        IProductReference Product { get; set; }
    }
}
