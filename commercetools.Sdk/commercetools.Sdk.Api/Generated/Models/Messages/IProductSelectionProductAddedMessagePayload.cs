using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload))]
    public partial interface IProductSelectionProductAddedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }
    }
}
