using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategoryChangeParentAction : CategoryUpdateAction
    {
        public CategoryResourceIdentifier Parent { get; set;}
    }
}
