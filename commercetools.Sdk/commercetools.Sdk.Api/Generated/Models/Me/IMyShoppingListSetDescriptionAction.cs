using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetDescriptionAction))]
    public partial interface IMyShoppingListSetDescriptionAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
