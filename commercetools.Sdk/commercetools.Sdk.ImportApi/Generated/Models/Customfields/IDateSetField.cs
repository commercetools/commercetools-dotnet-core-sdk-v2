using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateSetField))]
    public partial interface IDateSetField : ICustomField
    {
        IList<Date> Value { get; set; }
        IEnumerable<Date> ValueEnumerable { set => Value = value.ToList(); }


    }
}
