using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.CategoryOrderHints))]
    public partial interface ICategoryOrderHints : IDictionary<string, string>
    {
    }
}
