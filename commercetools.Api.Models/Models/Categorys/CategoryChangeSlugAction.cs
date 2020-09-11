using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategoryChangeSlugAction : CategoryUpdateAction
    {
        public LocalizedString Slug { get; set;}
    }
}
