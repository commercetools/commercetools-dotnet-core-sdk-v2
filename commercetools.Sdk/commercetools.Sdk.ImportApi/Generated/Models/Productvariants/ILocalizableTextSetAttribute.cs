using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.LocalizableTextSetAttribute))]
    public partial interface ILocalizableTextSetAttribute : IAttribute
    {
        List<ILocalizedString> Value { get; set; }
    }
}
