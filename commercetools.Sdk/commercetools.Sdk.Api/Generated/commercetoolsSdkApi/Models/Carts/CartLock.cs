using System;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartLock : ICartLock
    {
        public DateTime CreatedAt { get; set; }

        public string ClientId { get; set; }
    }
}
