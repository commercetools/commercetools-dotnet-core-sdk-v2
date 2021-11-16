using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductCreatedMessagePayload))]
    public partial interface IProductCreatedMessagePayload : IMessagePayload
    {
        IProductProjection ProductProjection { get; set; }
    }
}
