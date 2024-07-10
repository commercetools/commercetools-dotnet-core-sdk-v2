using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ShoppingListLineItemValue : IShoppingListLineItemValue
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public int VariantId { get; set; }
    }
}
