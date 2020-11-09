using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Api.Models.Products.WhitespaceTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Api.Models.Products.CustomTokenizer))]
    public partial interface ISuggestTokenizer 
    {
        string Type { get; set;}
    }
}
