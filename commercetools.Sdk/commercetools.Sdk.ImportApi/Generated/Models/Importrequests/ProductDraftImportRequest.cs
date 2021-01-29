using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Productdrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductDraftImportRequest : IProductDraftImportRequest
    {
        public IImportResourceType Type { get; set;}
        
        public List<IProductDraftImport> Resources { get; set;}
        public ProductDraftImportRequest()
        { 
           this.Type = IImportResourceType.FindEnum("product-draft");
        }
    }
}
