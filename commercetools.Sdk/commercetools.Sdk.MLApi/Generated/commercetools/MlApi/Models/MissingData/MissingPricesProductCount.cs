using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingPricesProductCount : IMissingPricesProductCount
    {
        public long Total { get; set; }

        public long MissingPrices { get; set; }
    }
}
