using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.EnumSetAttribute))]
    public partial interface IEnumSetAttribute : IAttribute
    {
        List<string> Value { get; set; }
    }
}
