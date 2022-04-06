using commercetools.Sdk.ImportApi.Models.Productdrafts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    public partial interface IProductDraftImportRequest : IImportRequest
    {
        List<IProductDraftImport> Resources { get; set; }
    }
}
