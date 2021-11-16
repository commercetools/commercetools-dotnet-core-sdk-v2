using commercetools.ImportApi.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.ProductImportRequest))]
    public partial interface IProductImportRequest : IImportRequest
    {
        List<IProductImport> Resources { get; set; }
    }
}
