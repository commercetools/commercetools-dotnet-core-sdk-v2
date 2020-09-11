using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategoryChangeOrderHintAction : CategoryUpdateAction
    {
        public string OrderHint { get; set;}
    }
}
