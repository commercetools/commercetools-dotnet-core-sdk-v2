using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryReference : ICategoryReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public ICategory Obj { get; set;}
        public CategoryReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("category");
        }
    }
}
