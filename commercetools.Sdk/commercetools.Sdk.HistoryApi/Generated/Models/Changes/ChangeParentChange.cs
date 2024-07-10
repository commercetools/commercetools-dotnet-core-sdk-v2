using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeParentChange : IChangeParentChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference PreviousValue { get; set; }

        public IReference NextValue { get; set; }
        public ChangeParentChange()
        {
            this.Type = "ChangeParentChange";
        }
    }
}
