using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TextSetAttribute))]
    public partial interface ITextSetAttribute : IAttribute
    {
        IList<string> Value { get; set; }
        IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }


    }
}
