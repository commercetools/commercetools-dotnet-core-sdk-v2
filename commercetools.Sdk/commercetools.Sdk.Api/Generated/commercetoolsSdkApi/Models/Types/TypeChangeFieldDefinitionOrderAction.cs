using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeFieldDefinitionOrderAction : ITypeChangeFieldDefinitionOrderAction
    {
        public string Action { get; set; }

        public IList<string> FieldNames { get; set; }

        public IEnumerable<string> FieldNamesEnumerable { set => FieldNames = value.ToList(); }
        public TypeChangeFieldDefinitionOrderAction()
        {
            this.Action = "changeFieldDefinitionOrder";
        }
    }
}
