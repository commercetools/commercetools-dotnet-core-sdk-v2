using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeEnumValueOrderAction : ITypeChangeEnumValueOrderAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public IList<string> Keys { get; set; }

        public IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }
        public TypeChangeEnumValueOrderAction()
        {
            this.Action = "changeEnumValueOrder";
        }
    }
}
