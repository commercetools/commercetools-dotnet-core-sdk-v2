using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CategoryCreatedMessage))]
    public partial interface ICategoryCreatedMessage : IMessage
    {
        ICategory Category { get; set; }
    }
}
