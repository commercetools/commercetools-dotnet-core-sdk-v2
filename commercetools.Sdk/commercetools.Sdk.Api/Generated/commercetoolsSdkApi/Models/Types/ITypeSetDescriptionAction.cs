using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeSetDescriptionAction))]
    public partial interface ITypeSetDescriptionAction : ITypeUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
