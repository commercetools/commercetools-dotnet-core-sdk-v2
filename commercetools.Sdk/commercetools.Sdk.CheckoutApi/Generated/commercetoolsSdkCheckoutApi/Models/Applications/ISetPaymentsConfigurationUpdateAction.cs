using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentsConfigurationUpdateAction))]
    public partial interface ISetPaymentsConfigurationUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IPaymentsConfiguration PaymentsConfiguration { get; set; }

    }
}
