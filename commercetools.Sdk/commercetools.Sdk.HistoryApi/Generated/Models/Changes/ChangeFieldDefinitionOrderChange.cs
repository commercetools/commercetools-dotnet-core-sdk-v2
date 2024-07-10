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

    public partial class ChangeFieldDefinitionOrderChange : IChangeFieldDefinitionOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IFieldDefinitionOrderValue> PreviousValue { get; set; }
        public IEnumerable<IFieldDefinitionOrderValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IFieldDefinitionOrderValue> NextValue { get; set; }
        public IEnumerable<IFieldDefinitionOrderValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public ChangeFieldDefinitionOrderChange()
        {
            this.Type = "ChangeFieldDefinitionOrderChange";
        }
    }
}
