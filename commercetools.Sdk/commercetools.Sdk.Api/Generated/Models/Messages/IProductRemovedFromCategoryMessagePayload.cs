using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductRemovedFromCategoryMessagePayload))]
    public partial interface IProductRemovedFromCategoryMessagePayload : IMessagePayload
    {
        ICategoryReference Category { get; set; }

        bool Staged { get; set; }
    }
}
