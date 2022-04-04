using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeChangeLocalizedEnumValueOrderAction : ITypeChangeLocalizedEnumValueOrderAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public List<string> Keys { get; set; }
        public TypeChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
