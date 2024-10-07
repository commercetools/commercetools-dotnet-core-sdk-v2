using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetCompanyNameAction))]
    public partial interface IMyCustomerSetCompanyNameAction : IMyCustomerUpdateAction
    {
        string CompanyName { get; set; }

    }
}
