using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class CategoryOrderHints : Dictionary<string, string>, ICategoryOrderHints
    {
    }
}
