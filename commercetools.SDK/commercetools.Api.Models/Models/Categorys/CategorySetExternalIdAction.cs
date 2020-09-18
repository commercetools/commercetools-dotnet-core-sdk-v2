using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setExternalId")]
    public class CategorySetExternalIdAction : CategoryUpdateAction
    {
        public string ExternalId { get; set;}
    }
}
