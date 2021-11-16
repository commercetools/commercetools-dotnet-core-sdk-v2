using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction))]
    public partial interface ICartDiscountChangeSortOrderAction : ICartDiscountUpdateAction
    {
        string SortOrder { get; set; }
    }
}
