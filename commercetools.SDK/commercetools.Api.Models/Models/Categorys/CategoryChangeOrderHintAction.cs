using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeOrderHint")]
    public class CategoryChangeOrderHintAction : CategoryUpdateAction
    {
        public string OrderHint { get; set;}
    }
}
