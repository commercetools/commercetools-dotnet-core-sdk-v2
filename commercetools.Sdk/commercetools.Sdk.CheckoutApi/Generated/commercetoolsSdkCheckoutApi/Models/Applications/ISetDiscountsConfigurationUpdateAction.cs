using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetDiscountsConfigurationUpdateAction))]
    public partial interface ISetDiscountsConfigurationUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IDiscountsConfiguration DiscountsConfiguration { get; set; }

    }
}
