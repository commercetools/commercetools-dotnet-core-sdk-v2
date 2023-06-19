using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute))]
    public partial interface IReferenceSetAttribute : IAttribute
    {
        IList<IKeyReference> Value { get; set; }
        IEnumerable<IKeyReference> ValueEnumerable { set => Value = value.ToList(); }


    }
}
