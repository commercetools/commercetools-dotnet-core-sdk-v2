using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction))]
    public partial interface IProductDiscountChangeSortOrderAction : IProductDiscountUpdateAction
    {
        string SortOrder { get; set; }

    }
}
