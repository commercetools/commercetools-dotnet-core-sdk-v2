using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomerGroupAssignmentAddedMessagePayload))]
    public partial interface IBusinessUnitCustomerGroupAssignmentAddedMessagePayload : IMessagePayload
    {
        ICustomerGroupAssignment CustomerGroupAssignment { get; set; }

    }
}
