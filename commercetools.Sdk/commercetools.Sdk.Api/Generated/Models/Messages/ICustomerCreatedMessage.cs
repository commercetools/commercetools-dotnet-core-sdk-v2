using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCreatedMessage))]
    public partial interface ICustomerCreatedMessage : IMessage
    {
        ICustomer Customer { get; set; }
    }
}
