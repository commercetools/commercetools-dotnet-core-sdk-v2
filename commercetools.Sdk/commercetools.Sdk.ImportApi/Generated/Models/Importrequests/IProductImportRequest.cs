using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.ProductImportRequest))]
    public partial interface IProductImportRequest : IImportRequest
    {
        List<IProductImport> Resources { get; set;}
    }
}
