using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    public partial interface IDiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeUpdateAction
    {
        long? MaxApplicationsPerCustomer { get; set; }
    }
}
