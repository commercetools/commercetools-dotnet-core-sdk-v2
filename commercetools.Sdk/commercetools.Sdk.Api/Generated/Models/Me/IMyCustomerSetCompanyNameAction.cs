using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetCompanyNameAction))]
    public partial interface IMyCustomerSetCompanyNameAction : IMyCustomerUpdateAction
    {
        string CompanyName { get; set;}
    }
}
