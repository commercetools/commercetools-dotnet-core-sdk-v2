using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetMetaTitleAction))]
    public partial interface ICategorySetMetaTitleAction : ICategoryUpdateAction
    {
        ILocalizedString MetaTitle { get; set;}
    }
}
