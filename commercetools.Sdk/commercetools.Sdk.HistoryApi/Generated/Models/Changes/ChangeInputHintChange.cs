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

    public partial class ChangeInputHintChange : IChangeInputHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITextInputHint PreviousValue { get; set; }

        public ITextInputHint NextValue { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public ChangeInputHintChange()
        {
            this.Type = "ChangeInputHintChange";
        }
    }
}
