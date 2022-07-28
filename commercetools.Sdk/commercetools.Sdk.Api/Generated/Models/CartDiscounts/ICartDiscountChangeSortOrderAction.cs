using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction))]
    public partial interface ICartDiscountChangeSortOrderAction : ICartDiscountUpdateAction
    {
        string SortOrder { get; set; }

    }
}
