using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeValueExternalChangeValue : IChangeValueExternalChangeValue
    {
        public string Type { get; set; }
        public ChangeValueExternalChangeValue()
        {
            this.Type = "external";
        }
    }
}
