using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchStringValue))]
    public partial interface IOrderSearchStringValue : IOrderSearchQueryExpressionValue
    {
        string Value { get; set; }

        string Language { get; set; }

        bool? CaseInsensitive { get; set; }

    }
}
