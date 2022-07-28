using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeNameAction))]
    public partial interface ITypeChangeNameAction : ITypeUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
