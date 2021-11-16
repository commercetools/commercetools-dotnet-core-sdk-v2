using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetLocaleAction))]
    public partial interface IMyCustomerSetLocaleAction : IMyCustomerUpdateAction
    {
        string Locale { get; set;}
    }
}
