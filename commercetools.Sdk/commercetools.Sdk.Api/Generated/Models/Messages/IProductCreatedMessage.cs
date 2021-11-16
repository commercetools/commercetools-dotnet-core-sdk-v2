using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductCreatedMessage))]
    public partial interface IProductCreatedMessage : IMessage
    {
        IProductProjection ProductProjection { get; set;}
    }
}
