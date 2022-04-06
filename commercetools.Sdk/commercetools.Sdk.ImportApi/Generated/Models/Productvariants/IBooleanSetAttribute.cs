using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute))]
    public partial interface IBooleanSetAttribute : IAttribute
    {
        List<bool> Value { get; set; }
    }
}
