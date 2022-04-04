using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchRequest))]
    public partial interface IOrderSearchRequest
    {
        IOrderSearchQuery Query { get; set; }

        string Sort { get; set; }

        int? Limit { get; set; }

        int? Offset { get; set; }
    }
}
