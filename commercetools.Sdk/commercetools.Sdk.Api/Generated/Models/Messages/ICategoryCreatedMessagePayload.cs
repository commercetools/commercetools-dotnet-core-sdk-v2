using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CategoryCreatedMessagePayload))]
    public partial interface ICategoryCreatedMessagePayload : IMessagePayload
    {
        ICategory Category { get; set; }
    }
}
