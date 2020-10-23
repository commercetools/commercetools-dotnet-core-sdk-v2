using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class TypeSetDescriptionAction : ITypeSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public TypeSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
