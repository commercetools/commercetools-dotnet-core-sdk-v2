using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomFieldChange : ISetCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }
        public SetCustomFieldChange()
        {
            this.Type = "SetCustomFieldChange";
        }
    }
}
