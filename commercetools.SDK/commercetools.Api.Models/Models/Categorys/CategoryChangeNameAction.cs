using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeName")]
    public partial class CategoryChangeNameAction : CategoryUpdateAction
    {
        public LocalizedString Name { get; set;}
        public CategoryChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
