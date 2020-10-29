using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetCustomTypeAction))]
    public interface ICategorySetCustomTypeAction : ICategoryUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
