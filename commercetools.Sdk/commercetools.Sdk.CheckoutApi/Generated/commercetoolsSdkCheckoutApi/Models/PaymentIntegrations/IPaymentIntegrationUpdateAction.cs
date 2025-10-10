using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationUpdateAction))]
    [SubTypeDiscriminator("setAutomatedReversalConfiguration", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationUpdateAction))]
    [SubTypeDiscriminator("setAutomatedReversalConfigurationPredicate", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationPredicateUpdateAction))]
    [SubTypeDiscriminator("setAutomatedReversalConfigurationStatus", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationStatusUpdateAction))]
    [SubTypeDiscriminator("setConnectorDeployment", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetConnectorDeploymentUpdateAction))]
    [SubTypeDiscriminator("setDisplayInfo", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoUpdateAction))]
    [SubTypeDiscriminator("setDisplayInfoDescription", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoDescriptionUpdateAction))]
    [SubTypeDiscriminator("setDisplayInfoLabel", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLabelUpdateAction))]
    [SubTypeDiscriminator("setDisplayInfoLogoUrl", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLogoUrlUpdateAction))]
    [SubTypeDiscriminator("setDisplayInfoPayButtonText", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoPayButtonTextUpdateAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetKeyUpdateAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetNameUpdateAction))]
    [SubTypeDiscriminator("setPredicate", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetPredicateUpdateAction))]
    [SubTypeDiscriminator("setSortingInfo", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetSortingInfoUpdateAction))]
    [SubTypeDiscriminator("setStatus", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetStatusUpdateAction))]
    [SubTypeDiscriminator("setType", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetTypeUpdateAction))]
    public partial interface IPaymentIntegrationUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationUpdateAction SetAutomatedReversalConfiguration(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationPredicateUpdateAction SetAutomatedReversalConfigurationPredicate(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationPredicateUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationPredicateUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationStatusUpdateAction SetAutomatedReversalConfigurationStatus(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationStatusUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationStatusUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetConnectorDeploymentUpdateAction SetConnectorDeployment(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetConnectorDeploymentUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetConnectorDeploymentUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoUpdateAction SetDisplayInfo(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoDescriptionUpdateAction SetDisplayInfoDescription(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoDescriptionUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoDescriptionUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLabelUpdateAction SetDisplayInfoLabel(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLabelUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLabelUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLogoUrlUpdateAction SetDisplayInfoLogoUrl(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLogoUrlUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoLogoUrlUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoPayButtonTextUpdateAction SetDisplayInfoPayButtonText(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoPayButtonTextUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetDisplayInfoPayButtonTextUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetKeyUpdateAction SetKey(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetKeyUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetKeyUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetNameUpdateAction SetName(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetNameUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetNameUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetPredicateUpdateAction SetPredicate(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetPredicateUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetPredicateUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetSortingInfoUpdateAction SetSortingInfo(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetSortingInfoUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetSortingInfoUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetStatusUpdateAction SetStatus(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetStatusUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetStatusUpdateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetTypeUpdateAction SetType(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetTypeUpdateAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetTypeUpdateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
