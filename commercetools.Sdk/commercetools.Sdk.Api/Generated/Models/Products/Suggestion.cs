using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class Suggestion : ISuggestion
    {
        public string Text { get; set;}
    }
}
