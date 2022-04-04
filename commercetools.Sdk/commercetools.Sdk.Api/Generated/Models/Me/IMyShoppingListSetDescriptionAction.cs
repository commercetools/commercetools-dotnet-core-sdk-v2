using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetDescriptionAction))]
    public partial interface IMyShoppingListSetDescriptionAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Description { get; set; }
    }
}
