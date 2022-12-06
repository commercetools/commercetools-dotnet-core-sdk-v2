using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute))]
    public partial interface IBooleanSetAttribute : IAttribute
    {
        IList<bool> Value { get; set; }
        IEnumerable<bool> ValueEnumerable { set => Value = value.ToList(); }


    }
}
