using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class StringLabel : IStringLabel
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public StringLabel()
        {
            this.Type = "StringLabel";
        }
    }
}
