using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLabelAction))]
    public partial interface ITypeChangeLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ILocalizedString Label { get; set; }

    }
}
