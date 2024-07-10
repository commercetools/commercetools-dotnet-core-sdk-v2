using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    public partial interface IProductVariantImportRequest : IImportRequest
    {
        IList<IProductVariantImport> Resources { get; set; }
        IEnumerable<IProductVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
