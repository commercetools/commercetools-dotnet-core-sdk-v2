using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    public partial class DiscountCodeUpdate : IDiscountCodeUpdate
    {
        public long Version { get; set; }

        public List<IDiscountCodeUpdateAction> Actions { get; set; }
    }
}
