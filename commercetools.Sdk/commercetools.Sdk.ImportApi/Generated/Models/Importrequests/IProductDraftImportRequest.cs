using commercetools.Sdk.ImportApi.Models.Productdrafts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductDraftImportRequest))]
    public partial interface IProductDraftImportRequest : IImportRequest
    {
        IList<IProductDraftImport> Resources { get; set; }
        IEnumerable<IProductDraftImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
