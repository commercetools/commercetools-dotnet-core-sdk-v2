using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemovePropertyChange : IRemovePropertyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public Object PreviousValue { get; set; }

        public string Path { get; set; }
        public RemovePropertyChange()
        {
            this.Type = "RemovePropertyChange";
        }
    }
}
