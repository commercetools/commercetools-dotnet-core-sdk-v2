using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.ReferenceAttribute))]
    public partial interface IReferenceAttribute : IAttribute
    {
        IKeyReference Value { get; set; }
    }
}
