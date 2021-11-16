using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetCustomFieldAction))]
    public partial interface ICategorySetCustomFieldAction : ICategoryUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
