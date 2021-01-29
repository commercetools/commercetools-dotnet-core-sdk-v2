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
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.CategoryImportRequest))]
    public partial interface ICategoryImportRequest : IImportRequest
    {
        List<ICategoryImport> Resources { get; set;}
    }
}
