using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest))]
    public partial interface IProductImportRequest : IImportRequest
    {
        List<IProductImport> Resources { get; set; }
    }
}
