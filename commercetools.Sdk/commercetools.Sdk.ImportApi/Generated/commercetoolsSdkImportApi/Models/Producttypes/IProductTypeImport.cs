using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.ProductTypeImport))]
    public partial interface IProductTypeImport : IImportResource
    {
        new string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<IAttributeDefinition> Attributes { get; set; }

        IEnumerable<IAttributeDefinition> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
