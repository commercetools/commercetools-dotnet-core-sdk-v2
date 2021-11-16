using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction))]
    public partial interface ICartSetDeleteDaysAfterLastModificationAction : ICartUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set;}
    }
}
