using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination))]
    [Obsolete]
    public partial interface IIronMqDestination : IDestination
    {
        string Uri { get; set; }

    }
}
