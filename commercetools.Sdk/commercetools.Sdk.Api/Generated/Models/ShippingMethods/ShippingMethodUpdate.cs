using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodUpdate : IShippingMethodUpdate
    {
        public long Version { get; set; }

        public List<IShippingMethodUpdateAction> Actions { get; set; }
    }
}
