using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeChangeLocalizedEnumValueOrderAction : ITypeChangeLocalizedEnumValueOrderAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public IList<string> Keys { get; set; }
        public IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }

        public TypeChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
