using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductAddedToCategoryMessage))]
    public partial interface IProductAddedToCategoryMessage : IMessage
    {
        ICategoryReference Category { get; set;}
        
        bool Staged { get; set;}
    }
}
