using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class ItemShippingDetails : IItemShippingDetails
    {
        public List<IItemShippingTarget> Targets { get; set;}
        
        public bool Valid { get; set;}
    }
}
