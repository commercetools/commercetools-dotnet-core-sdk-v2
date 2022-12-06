using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute))]
    public partial interface INumberSetAttribute : IAttribute
    {
        IList<decimal> Value { get; set; }
        IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }


    }
}
