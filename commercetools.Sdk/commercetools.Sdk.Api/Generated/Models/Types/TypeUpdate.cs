using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeUpdate : ITypeUpdate
    {
        public long Version { get; set; }

        public List<ITypeUpdateAction> Actions { get; set; }
    }
}
