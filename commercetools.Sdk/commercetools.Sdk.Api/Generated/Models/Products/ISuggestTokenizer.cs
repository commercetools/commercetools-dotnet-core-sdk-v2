using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Sdk.Api.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Sdk.Api.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Products.CustomTokenizer Custom(Action<commercetools.Sdk.Api.Models.Products.CustomTokenizer> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.CustomTokenizer();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.WhitespaceTokenizer Whitespace(Action<commercetools.Sdk.Api.Models.Products.WhitespaceTokenizer> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.WhitespaceTokenizer();
            init?.Invoke(t);
            return t;
        }
    }
}
