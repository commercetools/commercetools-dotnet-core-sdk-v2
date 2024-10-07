using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDeleteDaysAfterLastModificationAction))]
    public partial interface ICartSetDeleteDaysAfterLastModificationAction : ICartUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set; }

    }
}
