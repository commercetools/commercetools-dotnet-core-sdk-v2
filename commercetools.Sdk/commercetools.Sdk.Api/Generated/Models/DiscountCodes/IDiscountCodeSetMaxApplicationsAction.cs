using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction))]
    public partial interface IDiscountCodeSetMaxApplicationsAction : IDiscountCodeUpdateAction
    {
        long? MaxApplications { get; set;}
    }
}
