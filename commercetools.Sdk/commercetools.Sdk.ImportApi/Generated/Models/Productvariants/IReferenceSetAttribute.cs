using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.ReferenceSetAttribute))]
    public partial interface IReferenceSetAttribute : IAttribute
    {
        List<IKeyReference> Value { get; set;}
    }
}
