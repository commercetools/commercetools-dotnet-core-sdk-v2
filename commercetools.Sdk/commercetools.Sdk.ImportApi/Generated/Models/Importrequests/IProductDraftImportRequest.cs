using commercetools.ImportApi.Models.Productdrafts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    public partial interface IProductDraftImportRequest : IImportRequest
    {
        List<IProductDraftImport> Resources { get; set; }
    }
}
