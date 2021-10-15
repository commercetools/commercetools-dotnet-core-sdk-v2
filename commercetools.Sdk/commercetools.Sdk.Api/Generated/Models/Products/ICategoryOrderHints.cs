using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.CategoryOrderHints))]
    public interface ICategoryOrderHints : IDictionary<string, string>
    {
    }
}
