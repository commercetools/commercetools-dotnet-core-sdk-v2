using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction))]
    public partial interface IMyShoppingListSetDeleteDaysAfterLastModificationAction : IMyShoppingListUpdateAction
    {
        long? DeleteDaysAfterLastModification { get; set; }

    }
}
