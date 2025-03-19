using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessagePayload))]
    public partial interface ICustomerGroupAssignmentAddedMessagePayload : IMessagePayload
    {
        ICustomerGroupAssignment CustomerGroupAssignment { get; set; }

    }
}
