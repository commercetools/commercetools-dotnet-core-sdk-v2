using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerTitleSetMessage))]
    public partial interface ICustomerTitleSetMessage : IMessage
    {
        string Title { get; set;}
    }
}
