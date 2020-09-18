using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [Discriminator(nameof(Action))]
    public abstract class CategoryUpdateAction 
    {
        public string Action { get; set;}
    }
}
