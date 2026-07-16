using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.ParameterOverride))]
    public partial interface IParameterOverride
    {
        string Name { get; set; }

        string Description { get; set; }

        Object Const { get; set; }

        Object Default { get; set; }

        IList<Object> AllowedTypes { get; set; }

        IEnumerable<Object> AllowedTypesEnumerable { set => AllowedTypes = value.ToList(); }

    }
}
