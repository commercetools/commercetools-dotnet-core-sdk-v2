using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeNameAction))]
    public partial interface IMyShoppingListChangeNameAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
