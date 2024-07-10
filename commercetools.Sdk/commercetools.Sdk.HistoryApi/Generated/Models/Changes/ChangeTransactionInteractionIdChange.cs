using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTransactionInteractionIdChange : IChangeTransactionInteractionIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public ITransactionChangeValue Transaction { get; set; }
        public ChangeTransactionInteractionIdChange()
        {
            this.Type = "ChangeTransactionInteractionIdChange";
        }
    }
}
