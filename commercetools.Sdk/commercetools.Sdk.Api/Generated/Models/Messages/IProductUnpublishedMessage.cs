using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductUnpublishedMessage))]
    public partial interface IProductUnpublishedMessage : IMessage
    {
    }
}
