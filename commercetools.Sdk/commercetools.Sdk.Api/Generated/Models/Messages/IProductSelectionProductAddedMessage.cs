using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionProductAddedMessage))]
    public partial interface IProductSelectionProductAddedMessage : IMessage
    {
        IProductReference Product { get; set; }
    }
}
