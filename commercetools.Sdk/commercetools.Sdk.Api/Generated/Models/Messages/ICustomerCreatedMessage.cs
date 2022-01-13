using commercetools.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerCreatedMessage))]
    public partial interface ICustomerCreatedMessage : IMessage
    {
        ICustomer Customer { get; set; }
    }
}
