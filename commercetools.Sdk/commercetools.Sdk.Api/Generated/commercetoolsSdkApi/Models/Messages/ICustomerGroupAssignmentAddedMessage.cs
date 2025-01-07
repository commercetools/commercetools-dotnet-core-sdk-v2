using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentAddedMessage))]
    public partial interface ICustomerGroupAssignmentAddedMessage : IMessage
    {
        ICustomerGroupAssignment CustomerGroupAssignment { get; set; }

    }
}
