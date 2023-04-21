using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchFullTextValue))]
    public partial interface IOrderSearchFullTextValue : IOrderSearchQueryExpressionValue
    {
        string Value { get; set; }

        string Language { get; set; }

        IOrderSearchMatchType MustMatch { get; set; }

    }
}
