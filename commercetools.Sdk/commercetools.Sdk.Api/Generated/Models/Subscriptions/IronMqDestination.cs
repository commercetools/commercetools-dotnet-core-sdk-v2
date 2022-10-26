using System;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class IronMqDestination : IIronMqDestination
    {
        public string Type { get; set; }

        public string Uri { get; set; }
        public IronMqDestination()
        {
            this.Type = "IronMQ";
        }
    }
}
