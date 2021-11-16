using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.IronMqDestination))]
    public partial interface IIronMqDestination : IDestination
    {
        string Uri { get; set; }
    }
}
