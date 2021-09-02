using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class DiscountCodeInfo : IDiscountCodeInfo
    {
        public IReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }
    }
}
