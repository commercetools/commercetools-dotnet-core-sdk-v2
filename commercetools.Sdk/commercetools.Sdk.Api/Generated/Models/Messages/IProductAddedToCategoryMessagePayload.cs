using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductAddedToCategoryMessagePayload))]
    public partial interface IProductAddedToCategoryMessagePayload : IMessagePayload
    {
        ICategoryReference Category { get; set; }

        bool Staged { get; set; }
    }
}
