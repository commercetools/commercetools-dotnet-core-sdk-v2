using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetLocaleAction))]
    public partial interface IMyCustomerSetLocaleAction : IMyCustomerUpdateAction
    {
        string Locale { get; set; }

    }
}
