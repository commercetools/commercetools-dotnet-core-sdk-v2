using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    public partial interface IDiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeUpdateAction
    {
        long? MaxApplicationsPerCustomer { get; set; }

    }
}
