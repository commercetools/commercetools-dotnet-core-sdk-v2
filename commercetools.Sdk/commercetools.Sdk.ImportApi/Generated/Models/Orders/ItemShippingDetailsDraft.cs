using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public List<IItemShippingTarget> Targets { get; set; }
    }
}
