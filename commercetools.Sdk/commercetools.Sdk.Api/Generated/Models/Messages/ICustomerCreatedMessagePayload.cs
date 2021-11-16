using commercetools.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerCreatedMessagePayload))]
    public partial interface ICustomerCreatedMessagePayload : IMessagePayload
    {
        ICustomer Customer { get; set; }
    }
}
