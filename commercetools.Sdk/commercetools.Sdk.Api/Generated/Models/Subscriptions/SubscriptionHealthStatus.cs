using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum SubscriptionHealthStatus
    {
        [Description("Healthy")]
        Healthy,

        [Description("ConfigurationError")]
        ConfigurationError,

        [Description("ConfigurationErrorDeliveryStopped")]
        ConfigurationErrorDeliveryStopped,

        [Description("TemporaryError")]
        TemporaryError
    }

    public class SubscriptionHealthStatusWrapper : ISubscriptionHealthStatus
    {
        public string JsonName { get; internal set; }
        public SubscriptionHealthStatus? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(ISubscriptionHealthStatus), "FindEnum")]
    public interface ISubscriptionHealthStatus : IJsonName, IEnumerable<char>
    {
        public static ISubscriptionHealthStatus Healthy = new SubscriptionHealthStatusWrapper
        { Value = SubscriptionHealthStatus.Healthy, JsonName = "Healthy" };

        public static ISubscriptionHealthStatus ConfigurationError = new SubscriptionHealthStatusWrapper
        { Value = SubscriptionHealthStatus.ConfigurationError, JsonName = "ConfigurationError" };

        public static ISubscriptionHealthStatus ConfigurationErrorDeliveryStopped = new SubscriptionHealthStatusWrapper
        { Value = SubscriptionHealthStatus.ConfigurationErrorDeliveryStopped, JsonName = "ConfigurationErrorDeliveryStopped" };

        public static ISubscriptionHealthStatus TemporaryError = new SubscriptionHealthStatusWrapper
        { Value = SubscriptionHealthStatus.TemporaryError, JsonName = "TemporaryError" };

        SubscriptionHealthStatus? Value { get; }

        static ISubscriptionHealthStatus[] Values()
        {
            return new[]
            {
                 Healthy ,
                 ConfigurationError ,
                 ConfigurationErrorDeliveryStopped ,
                 TemporaryError
             };
        }
        static ISubscriptionHealthStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SubscriptionHealthStatusWrapper() { JsonName = value };
        }
    }
}
