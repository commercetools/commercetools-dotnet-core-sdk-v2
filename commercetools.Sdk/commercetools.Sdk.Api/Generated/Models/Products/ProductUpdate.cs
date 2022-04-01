using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductUpdate : IProductUpdate
    {
        public long Version { get; set; }

        public List<IProductUpdateAction> Actions { get; set; }
    }
}
