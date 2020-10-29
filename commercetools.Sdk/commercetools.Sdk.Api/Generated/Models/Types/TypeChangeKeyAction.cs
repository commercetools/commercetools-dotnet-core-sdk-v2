using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeKeyAction : ITypeChangeKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public TypeChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
