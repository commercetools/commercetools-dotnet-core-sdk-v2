using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ShoppingListLineItemValue))]
    public partial interface IShoppingListLineItemValue 
    {
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        int VariantId { get; set;}
    }
}
