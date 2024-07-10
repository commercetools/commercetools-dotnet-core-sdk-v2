using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction))]
    public partial interface IMyShoppingListChangeTextLineItemNameAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string TextLineItemKey { get; set; }

        ILocalizedString Name { get; set; }

    }
}
