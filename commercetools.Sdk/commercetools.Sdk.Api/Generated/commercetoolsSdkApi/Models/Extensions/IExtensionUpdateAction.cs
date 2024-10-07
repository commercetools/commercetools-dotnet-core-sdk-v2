using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdateAction))]
    [SubTypeDiscriminator("changeDestination", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    [SubTypeDiscriminator("changeTriggers", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction))]
    [SubTypeDiscriminator("setTimeoutInMs", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction ChangeDestination(Action<commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction ChangeTriggers(Action<commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction SetTimeoutInMs(Action<commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
