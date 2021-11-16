using commercetools.ImportApi.Models.Categories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.CategoryImportRequest))]
    public partial interface ICategoryImportRequest : IImportRequest
    {
        List<ICategoryImport> Resources { get; set;}
    }
}
