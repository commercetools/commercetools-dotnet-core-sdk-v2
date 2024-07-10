using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class CustomObjectLabel : ICustomObjectLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Container { get; set; }
        public CustomObjectLabel()
        {
            this.Type = "CustomObjectLabel";
        }
    }
}
