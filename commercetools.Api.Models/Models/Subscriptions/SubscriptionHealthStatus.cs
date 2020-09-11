using System.ComponentModel;

namespace commercetools.Api.Models.Subscriptions
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
}
