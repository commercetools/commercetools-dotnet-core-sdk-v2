using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setCustomType")]
    public partial class CategorySetCustomTypeAction : CategoryUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public CategorySetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
