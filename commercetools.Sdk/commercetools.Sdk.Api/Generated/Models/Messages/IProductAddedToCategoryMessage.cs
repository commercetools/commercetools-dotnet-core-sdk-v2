using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessage))]
    public partial interface IProductAddedToCategoryMessage : IMessage
    {
        ICategoryReference Category { get; set; }

        bool Staged { get; set; }

    }
}
