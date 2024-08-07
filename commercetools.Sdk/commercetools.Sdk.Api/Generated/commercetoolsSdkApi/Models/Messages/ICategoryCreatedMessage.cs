using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessage))]
    public partial interface ICategoryCreatedMessage : IMessage
    {
        ICategory Category { get; set; }

    }
}
