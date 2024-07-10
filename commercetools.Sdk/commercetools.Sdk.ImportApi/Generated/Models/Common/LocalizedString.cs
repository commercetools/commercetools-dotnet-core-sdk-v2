using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class LocalizedString : Dictionary<string, string>, ILocalizedString
    {
    }
}
