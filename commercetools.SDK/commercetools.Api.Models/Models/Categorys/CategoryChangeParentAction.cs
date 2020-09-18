using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeParent")]
    public class CategoryChangeParentAction : CategoryUpdateAction
    {
        public CategoryResourceIdentifier Parent { get; set;}
    }
}
