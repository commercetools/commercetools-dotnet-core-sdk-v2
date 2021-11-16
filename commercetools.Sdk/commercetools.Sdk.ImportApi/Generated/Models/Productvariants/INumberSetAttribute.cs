using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.NumberSetAttribute))]
    public partial interface INumberSetAttribute : IAttribute
    {
        List<double> Value { get; set; }
    }
}
