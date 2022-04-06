using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class ItemShippingDetails : IItemShippingDetails
    {
        public List<IItemShippingTarget> Targets { get; set; }

        public bool Valid { get; set; }
    }
}
