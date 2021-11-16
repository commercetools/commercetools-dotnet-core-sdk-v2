using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction))]
    public partial interface IMyShoppingListSetDeleteDaysAfterLastModificationAction : IMyShoppingListUpdateAction
    {
        long? DeleteDaysAfterLastModification { get; set;}
    }
}
