using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerTitleSetMessage))]
    public partial interface ICustomerTitleSetMessage : IMessage
    {
        string Title { get; set; }
    }
}
