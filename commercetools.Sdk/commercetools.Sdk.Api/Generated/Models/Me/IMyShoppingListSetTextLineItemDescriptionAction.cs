using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IMyShoppingListSetTextLineItemDescriptionAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        ILocalizedString Description { get; set; }

    }
}
