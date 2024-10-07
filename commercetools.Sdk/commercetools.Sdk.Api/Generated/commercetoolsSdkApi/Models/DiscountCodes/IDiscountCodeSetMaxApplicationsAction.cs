using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsAction))]
    public partial interface IDiscountCodeSetMaxApplicationsAction : IDiscountCodeUpdateAction
    {
        long? MaxApplications { get; set; }

    }
}
