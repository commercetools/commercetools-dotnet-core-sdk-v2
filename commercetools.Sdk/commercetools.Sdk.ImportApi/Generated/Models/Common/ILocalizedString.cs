using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.LocalizedString))]
    public interface ILocalizedString : IDictionary<string, string>
    {
    }
}
