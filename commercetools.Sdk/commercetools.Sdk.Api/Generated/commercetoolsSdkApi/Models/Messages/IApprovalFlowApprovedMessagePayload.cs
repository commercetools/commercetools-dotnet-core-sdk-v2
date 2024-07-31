using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowApprovedMessagePayload))]
    public partial interface IApprovalFlowApprovedMessagePayload : IMessagePayload
    {
        ICustomerReference Associate { get; set; }

        IOrderReference Order { get; set; }

    }
}
