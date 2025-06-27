using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetSortOrderAction))]
    public partial interface IDiscountGroupSetSortOrderAction : IDiscountGroupUpdateAction
    {
        string SortOrder { get; set; }

    }
}
