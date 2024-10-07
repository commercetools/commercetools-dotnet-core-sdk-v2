using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeNameAction))]
    public partial interface IMyShoppingListChangeNameAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
