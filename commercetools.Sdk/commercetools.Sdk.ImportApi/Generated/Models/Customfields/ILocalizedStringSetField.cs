using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringSetField))]
    public partial interface ILocalizedStringSetField : ICustomField
    {
        List<ILocalizedString> Value { get; set;}
    }
}
