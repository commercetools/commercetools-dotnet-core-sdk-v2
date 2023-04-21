using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchQueryExpressionValue))]
    public partial interface IOrderSearchQueryExpressionValue
    {
        string Field { get; set; }

        int? Boost { get; set; }

        string CustomType { get; set; }

    }
}
