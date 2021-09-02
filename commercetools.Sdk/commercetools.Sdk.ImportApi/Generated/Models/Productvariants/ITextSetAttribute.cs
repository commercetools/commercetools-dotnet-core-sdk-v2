using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.TextSetAttribute))]
    public partial interface ITextSetAttribute : IAttribute
    {
        List<string> Value { get; set; }
    }
}
