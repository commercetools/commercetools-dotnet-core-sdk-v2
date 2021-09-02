using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingPrices : IMissingPrices
    {
        public IProductReference Product { get; set; }

        public long VariantId { get; set; }
    }
}
