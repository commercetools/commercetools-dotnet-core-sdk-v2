using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.Hit))]
    public partial interface IHit
    {
        string Id { get; set; }

        long Version { get; set; }

        decimal? Relevance { get; set; }

    }
}
