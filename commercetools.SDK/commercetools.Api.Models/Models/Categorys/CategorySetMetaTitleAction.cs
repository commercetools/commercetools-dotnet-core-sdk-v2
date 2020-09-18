using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setMetaTitle")]
    public class CategorySetMetaTitleAction : CategoryUpdateAction
    {
        public LocalizedString MetaTitle { get; set;}
    }
}
