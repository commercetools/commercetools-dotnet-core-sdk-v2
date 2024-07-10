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

    public partial class SetVariantSelectionChange : ISetVariantSelectionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductVariantSelection PreviousValue { get; set; }

        public IProductVariantSelection NextValue { get; set; }

        public IReference Product { get; set; }
        public SetVariantSelectionChange()
        {
            this.Type = "SetVariantSelectionChange";
        }
    }
}
