using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerCompanyNameSetMessagePayload))]
    public partial interface ICustomerCompanyNameSetMessagePayload : IMessagePayload
    {
        string CompanyName { get; set; }
    }
}
