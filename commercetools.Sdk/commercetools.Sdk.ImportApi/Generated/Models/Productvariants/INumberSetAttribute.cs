using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute))]
    public partial interface INumberSetAttribute : IAttribute
    {
        List<double> Value { get; set; }
    }
}
