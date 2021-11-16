using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeEnumValueOrderAction : ITypeChangeEnumValueOrderAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public List<string> Keys { get; set; }
        public TypeChangeEnumValueOrderAction()
        {
            this.Action = "changeEnumValueOrder";
        }
    }
}
