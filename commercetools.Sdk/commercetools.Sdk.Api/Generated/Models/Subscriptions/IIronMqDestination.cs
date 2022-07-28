using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination))]
    public partial interface IIronMqDestination : IDestination
    {
        string Uri { get; set; }

    }
}
