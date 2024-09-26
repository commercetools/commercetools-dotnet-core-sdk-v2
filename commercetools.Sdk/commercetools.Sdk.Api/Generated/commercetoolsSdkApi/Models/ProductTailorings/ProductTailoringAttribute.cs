using System;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringAttribute : IProductTailoringAttribute
    {
        public string Name { get; set; }

        public Object Value { get; set; }
    }
}
