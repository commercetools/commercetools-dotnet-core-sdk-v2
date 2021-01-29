using commercetools.ImportApi.Models.Categories;
using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class CategoryImportRequest : ICategoryImportRequest
    {
        public IImportResourceType Type { get; set;}
        
        public List<ICategoryImport> Resources { get; set;}
        public CategoryImportRequest()
        { 
           this.Type = IImportResourceType.FindEnum("category");
        }
    }
}
