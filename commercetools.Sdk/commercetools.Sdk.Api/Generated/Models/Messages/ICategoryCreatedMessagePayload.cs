using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CategoryCreatedMessagePayload))]
    public partial interface ICategoryCreatedMessagePayload : IMessagePayload
    {
        ICategory Category { get; set; }
    }
}
