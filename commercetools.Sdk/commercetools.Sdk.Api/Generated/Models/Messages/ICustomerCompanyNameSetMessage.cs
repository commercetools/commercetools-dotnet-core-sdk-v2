using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessage))]
    public partial interface ICustomerCompanyNameSetMessage : IMessage
    {
        string CompanyName { get; set; }
    }
}
