using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class CartUpdate : ICartUpdate
    {
        public long Version { get; set;}
        
        public List<ICartUpdateAction> Actions { get; set;}
    }
}
