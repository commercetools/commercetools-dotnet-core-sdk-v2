using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField))]
    public partial interface ILocalizedStringSetField : ICustomField
    {
        List<ILocalizedString> Value { get; set; }

    }
}
