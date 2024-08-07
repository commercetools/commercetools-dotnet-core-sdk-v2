using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionChangeNameAction))]
    public partial interface IProductSelectionChangeNameAction : IProductSelectionUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
