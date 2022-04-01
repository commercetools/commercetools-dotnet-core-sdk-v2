using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public partial class ProductTypeUpdate : IProductTypeUpdate
    {
        public long Version { get; set; }

        public List<IProductTypeUpdateAction> Actions { get; set; }
    }
}
