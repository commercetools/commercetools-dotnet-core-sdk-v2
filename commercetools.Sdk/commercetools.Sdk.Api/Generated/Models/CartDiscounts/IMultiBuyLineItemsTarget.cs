using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    public partial interface IMultiBuyLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set; }

        int TriggerQuantity { get; set; }

        int DiscountedQuantity { get; set; }

        int? MaxOccurrence { get; set; }

        ISelectionMode SelectionMode { get; set; }
    }
}
