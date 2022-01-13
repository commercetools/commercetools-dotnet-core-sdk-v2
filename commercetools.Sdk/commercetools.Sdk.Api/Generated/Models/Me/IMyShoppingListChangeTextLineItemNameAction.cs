using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction))]
    public partial interface IMyShoppingListChangeTextLineItemNameAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        ILocalizedString Name { get; set; }
    }
}
