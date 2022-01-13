using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.Hit))]
    public partial interface IHit
    {
        string Id { get; set; }

        long Version { get; set; }

        double Relevance { get; set; }
    }
}
