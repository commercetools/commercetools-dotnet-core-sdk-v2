using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSearchRequest))]
    public partial interface IOrderSearchRequest
    {
        object Query { get; set; }

        string Sort { get; set; }

        int? Limit { get; set; }

        int? Offset { get; set; }
    }
}
