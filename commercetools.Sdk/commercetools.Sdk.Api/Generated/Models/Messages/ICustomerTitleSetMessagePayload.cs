using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerTitleSetMessagePayload))]
    public partial interface ICustomerTitleSetMessagePayload : IMessagePayload
    {
        string Title { get; set;}
    }
}
