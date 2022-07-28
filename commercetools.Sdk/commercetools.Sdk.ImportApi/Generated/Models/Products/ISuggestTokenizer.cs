using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Products.SuggestTokenizer))]
    [SubTypeDiscriminator("custom", typeof(commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer))]
    [SubTypeDiscriminator("whitespace", typeof(commercetools.Sdk.ImportApi.Models.Products.WhitespaceTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }

        static commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer Custom(Action<commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Products.WhitespaceTokenizer Whitespace(Action<commercetools.Sdk.ImportApi.Models.Products.WhitespaceTokenizer> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Products.WhitespaceTokenizer();
            init?.Invoke(t);
            return t;
        }
    }
}
