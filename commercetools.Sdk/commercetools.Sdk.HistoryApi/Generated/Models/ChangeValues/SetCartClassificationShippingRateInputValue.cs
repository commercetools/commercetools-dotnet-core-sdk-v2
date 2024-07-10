using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class SetCartClassificationShippingRateInputValue : ISetCartClassificationShippingRateInputValue
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
