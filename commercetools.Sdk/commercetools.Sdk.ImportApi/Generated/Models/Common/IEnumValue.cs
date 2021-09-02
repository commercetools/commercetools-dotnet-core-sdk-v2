using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.EnumValue))]
    public partial interface IEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }
    }
}
