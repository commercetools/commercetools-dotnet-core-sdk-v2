using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeDraft))]
    public partial interface IProductTypeDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<IAttributeDefinitionDraft> Attributes { get; set; }
        IEnumerable<IAttributeDefinitionDraft> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
