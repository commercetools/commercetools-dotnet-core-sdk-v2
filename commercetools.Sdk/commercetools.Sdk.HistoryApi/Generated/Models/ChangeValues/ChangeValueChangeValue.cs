using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeValueChangeValue : IChangeValueChangeValue
    {
        public string Type { get; set;}
    }
}
