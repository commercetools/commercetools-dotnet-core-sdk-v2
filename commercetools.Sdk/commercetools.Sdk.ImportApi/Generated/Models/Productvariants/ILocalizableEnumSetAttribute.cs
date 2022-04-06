using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute))]
    public partial interface ILocalizableEnumSetAttribute : IAttribute
    {
        List<string> Value { get; set; }
    }
}
