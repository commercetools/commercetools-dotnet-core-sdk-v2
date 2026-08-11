using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class ParameterOverride : IParameterOverride
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Object Const { get; set; }

        public Object Default { get; set; }

        public IList<Object> AllowedTypes { get; set; }

        public IEnumerable<Object> AllowedTypesEnumerable { set => AllowedTypes = value.ToList(); }
    }
}
