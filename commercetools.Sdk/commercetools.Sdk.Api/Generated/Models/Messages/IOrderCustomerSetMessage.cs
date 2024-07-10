using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessage))]
    public partial interface IOrderCustomerSetMessage : IOrderMessage
    {
        ICustomerReference Customer { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerReference OldCustomer { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }

    }
}
