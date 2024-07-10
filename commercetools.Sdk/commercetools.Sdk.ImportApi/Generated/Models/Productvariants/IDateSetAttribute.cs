using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute))]
    public partial interface IDateSetAttribute : IAttribute
    {
        IList<Date> Value { get; set; }
        IEnumerable<Date> ValueEnumerable { set => Value = value.ToList(); }


    }
}
