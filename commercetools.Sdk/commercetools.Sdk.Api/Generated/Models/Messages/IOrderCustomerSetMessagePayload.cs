using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomerSetMessagePayload))]
    public partial interface IOrderCustomerSetMessagePayload : IOrderMessagePayload
    {
        ICustomerReference Customer { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerReference OldCustomer { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }

    }
}
