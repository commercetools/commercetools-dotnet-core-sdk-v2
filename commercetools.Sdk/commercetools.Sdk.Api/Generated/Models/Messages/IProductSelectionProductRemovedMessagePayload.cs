using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload))]
    public partial interface IProductSelectionProductRemovedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }
    }
}
