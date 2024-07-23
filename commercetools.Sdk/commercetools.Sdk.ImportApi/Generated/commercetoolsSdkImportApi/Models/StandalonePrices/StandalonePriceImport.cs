using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.StandalonePrices
{

    public partial class StandalonePriceImport : IStandalonePriceImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public ITypedMoney Value { get; set; }

        public string Country { get; set; }

        public ICustomerGroupKeyReference CustomerGroup { get; set; }

        public IChannelKeyReference Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public IList<IPriceTier> Tiers { get; set; }
        public IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        public IDiscountedPrice Discounted { get; set; }

        public ICustom Custom { get; set; }
    }
}
