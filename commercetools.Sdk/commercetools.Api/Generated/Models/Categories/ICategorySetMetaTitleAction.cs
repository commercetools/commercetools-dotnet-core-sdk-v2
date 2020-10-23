using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Categories
{
    public interface ICategorySetMetaTitleAction : ICategoryUpdateAction
    {
        ILocalizedString MetaTitle { get; set;}
    }
}
