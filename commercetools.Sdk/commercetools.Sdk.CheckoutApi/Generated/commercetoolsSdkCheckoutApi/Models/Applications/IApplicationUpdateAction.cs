using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationUpdateAction))]
    [SubTypeDiscriminator("addAgreement", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddApplicationAgreementUpdateAction))]
    [SubTypeDiscriminator("addAllowedOrigin", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddAllowedOriginUpdateAction))]
    [SubTypeDiscriminator("addCountry", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.AddCountryUpdateAction))]
    [SubTypeDiscriminator("removeAgreement", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveApplicationAgreementUpdateAction))]
    [SubTypeDiscriminator("removeAllowedOrigin", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveAllowedOriginUpdateAction))]
    [SubTypeDiscriminator("removeCountry", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.RemoveCountryUpdateAction))]
    [SubTypeDiscriminator("reorderAgreement", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ReorderApplicationAgreementUpdateAction))]
    [SubTypeDiscriminator("setActivePaymentComponentType", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetActivePaymentComponentTypeUpdateAction))]
    [SubTypeDiscriminator("setAgreementName", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementNameUpdateAction))]
    [SubTypeDiscriminator("setAgreements", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementsUpdateAction))]
    [SubTypeDiscriminator("setAgreementStatus", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementStatusUpdateAction))]
    [SubTypeDiscriminator("setAgreementText", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTextUpdateAction))]
    [SubTypeDiscriminator("setAgreementType", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTypeUpdateAction))]
    [SubTypeDiscriminator("setAllowAllOrigins", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowAllOriginsUpdateAction))]
    [SubTypeDiscriminator("setAllowedOrigins", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowedOriginsUpdateAction))]
    [SubTypeDiscriminator("setApplicationLogo", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationLogoUpdateAction))]
    [SubTypeDiscriminator("setCountries", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetCountriesUpdateAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetDescriptionUpdateAction))]
    [SubTypeDiscriminator("setDiscountsConfiguration", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetDiscountsConfigurationUpdateAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationNameUpdateAction))]
    [SubTypeDiscriminator("setPaymentReturnUrl", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentReturnUrlUpdateAction))]
    [SubTypeDiscriminator("setPaymentsConfiguration", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentsConfigurationUpdateAction))]
    [SubTypeDiscriminator("setStatus", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationStatusUpdateAction))]
    public partial interface IApplicationUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Applications.AddApplicationAgreementUpdateAction AddAgreement(Action<commercetools.Sdk.CheckoutApi.Models.Applications.AddApplicationAgreementUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.AddApplicationAgreementUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.AddAllowedOriginUpdateAction AddAllowedOrigin(Action<commercetools.Sdk.CheckoutApi.Models.Applications.AddAllowedOriginUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.AddAllowedOriginUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.AddCountryUpdateAction AddCountry(Action<commercetools.Sdk.CheckoutApi.Models.Applications.AddCountryUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.AddCountryUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.RemoveApplicationAgreementUpdateAction RemoveAgreement(Action<commercetools.Sdk.CheckoutApi.Models.Applications.RemoveApplicationAgreementUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.RemoveApplicationAgreementUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.RemoveAllowedOriginUpdateAction RemoveAllowedOrigin(Action<commercetools.Sdk.CheckoutApi.Models.Applications.RemoveAllowedOriginUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.RemoveAllowedOriginUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.RemoveCountryUpdateAction RemoveCountry(Action<commercetools.Sdk.CheckoutApi.Models.Applications.RemoveCountryUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.RemoveCountryUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.ReorderApplicationAgreementUpdateAction ReorderAgreement(Action<commercetools.Sdk.CheckoutApi.Models.Applications.ReorderApplicationAgreementUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.ReorderApplicationAgreementUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetActivePaymentComponentTypeUpdateAction SetActivePaymentComponentType(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetActivePaymentComponentTypeUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetActivePaymentComponentTypeUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementNameUpdateAction SetAgreementName(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementNameUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementNameUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementsUpdateAction SetAgreements(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementsUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementsUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementStatusUpdateAction SetAgreementStatus(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementStatusUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementStatusUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTextUpdateAction SetAgreementText(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTextUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTextUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTypeUpdateAction SetAgreementType(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTypeUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationAgreementTypeUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowAllOriginsUpdateAction SetAllowAllOrigins(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowAllOriginsUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowAllOriginsUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowedOriginsUpdateAction SetAllowedOrigins(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowedOriginsUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetAllowedOriginsUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationLogoUpdateAction SetApplicationLogo(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationLogoUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationLogoUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetCountriesUpdateAction SetCountries(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetCountriesUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetCountriesUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetDescriptionUpdateAction SetDescription(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetDescriptionUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetDescriptionUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetDiscountsConfigurationUpdateAction SetDiscountsConfiguration(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetDiscountsConfigurationUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetDiscountsConfigurationUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationNameUpdateAction SetName(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationNameUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationNameUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentReturnUrlUpdateAction SetPaymentReturnUrl(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentReturnUrlUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentReturnUrlUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentsConfigurationUpdateAction SetPaymentsConfiguration(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentsConfigurationUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetPaymentsConfigurationUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationStatusUpdateAction SetStatus(Action<commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationStatusUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationStatusUpdateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
