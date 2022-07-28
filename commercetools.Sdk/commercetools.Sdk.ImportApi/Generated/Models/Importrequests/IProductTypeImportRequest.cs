using commercetools.Sdk.ImportApi.Models.Producttypes;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    public partial interface IProductTypeImportRequest : IImportRequest
    {
        List<IProductTypeImport> Resources { get; set; }

    }
}
