using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCompanyNameSetMessagePayload))]
    public partial interface ICustomerCompanyNameSetMessagePayload : IMessagePayload
    {
        string CompanyName { get; set; }

    }
}
