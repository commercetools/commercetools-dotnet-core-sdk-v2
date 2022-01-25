using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSelectionProductAddedMessagePayload))]
    public partial interface IProductSelectionProductAddedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }
    }
}
