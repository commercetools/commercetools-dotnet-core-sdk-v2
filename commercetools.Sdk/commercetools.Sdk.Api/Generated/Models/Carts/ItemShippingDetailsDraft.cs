using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public List<IItemShippingTarget> Targets { get; set; }
    }
}
