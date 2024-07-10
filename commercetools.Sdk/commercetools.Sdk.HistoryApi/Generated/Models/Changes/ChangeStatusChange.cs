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

    public partial class ChangeStatusChange : IChangeStatusChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitStatus PreviousValue { get; set; }

        public IBusinessUnitStatus NextValue { get; set; }
        public ChangeStatusChange()
        {
            this.Type = "ChangeStatusChange";
        }
    }
}
