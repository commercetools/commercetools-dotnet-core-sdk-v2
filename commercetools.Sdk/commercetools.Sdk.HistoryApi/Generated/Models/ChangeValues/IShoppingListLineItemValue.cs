using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ShoppingListLineItemValue))]
    public partial interface IShoppingListLineItemValue
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        int VariantId { get; set; }

    }
}
