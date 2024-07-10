using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductSelectionSetting : IProductSelectionSetting
    {
        public IReference ProductSelection { get; set; }

        public bool Active { get; set; }
    }
}
