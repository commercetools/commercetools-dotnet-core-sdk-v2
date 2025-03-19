using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupAssignmentRemovedMessage))]
    public partial interface ICustomerGroupAssignmentRemovedMessage : IMessage
    {
        ICustomerGroupAssignment CustomerGroupAssignment { get; set; }

    }
}
