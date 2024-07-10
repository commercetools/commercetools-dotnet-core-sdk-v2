using commercetools.Sdk.HistoryApi.Models.ChangeValues;
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

    public partial class SetShippingMethodTaxAmountChange : ISetShippingMethodTaxAmountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShippingMethodTaxAmountChangeValue PreviousValue { get; set; }

        public IShippingMethodTaxAmountChangeValue NextValue { get; set; }

        public ITaxMode TaxMode { get; set; }
        public SetShippingMethodTaxAmountChange()
        {
            this.Type = "SetShippingMethodTaxAmountChange";
        }
    }
}
