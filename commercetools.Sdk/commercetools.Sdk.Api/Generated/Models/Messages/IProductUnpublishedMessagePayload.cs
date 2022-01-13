using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductUnpublishedMessagePayload))]
    public partial interface IProductUnpublishedMessagePayload : IMessagePayload
    {
    }
}
