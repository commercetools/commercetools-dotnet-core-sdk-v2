using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget))]
    public partial interface IMultiBuyCustomLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set;}
        
        int TriggerQuantity { get; set;}
        
        int DiscountedQuantity { get; set;}
        
        int? MaxOccurrence { get; set;}
        
        ISelectionMode SelectionMode { get; set;}
    }
}
