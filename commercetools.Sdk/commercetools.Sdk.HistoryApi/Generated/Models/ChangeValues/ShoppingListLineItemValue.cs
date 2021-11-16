using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ShoppingListLineItemValue : IShoppingListLineItemValue
    {
        public string Id { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public int VariantId { get; set;}
    }
}
