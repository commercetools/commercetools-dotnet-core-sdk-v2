using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.DeliveryFormat))]
    [SubTypeDiscriminator("CloudEvents", typeof(commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat))]
    [SubTypeDiscriminator("Platform", typeof(commercetools.Sdk.Api.Models.Subscriptions.PlatformFormat))]
    public partial interface IDeliveryFormat
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat CloudEvents(Action<commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.PlatformFormat Platform(Action<commercetools.Sdk.Api.Models.Subscriptions.PlatformFormat> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.PlatformFormat();
            init?.Invoke(t);
            return t;
        }
    }
}
