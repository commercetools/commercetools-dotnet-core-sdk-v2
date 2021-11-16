using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute))]
    public partial interface ILocalizableEnumSetAttribute : IAttribute
    {
        List<string> Value { get; set; }
    }
}
