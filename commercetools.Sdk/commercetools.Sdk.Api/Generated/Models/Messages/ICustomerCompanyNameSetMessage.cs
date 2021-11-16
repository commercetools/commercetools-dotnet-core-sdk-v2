using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    public partial interface ICustomerCompanyNameSetMessage : IMessage
    {
        string CompanyName { get; set;}
    }
}
