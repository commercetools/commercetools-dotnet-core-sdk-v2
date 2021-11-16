using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class TypeUpdate : ITypeUpdate
    {
        public long Version { get; set;}
        
        public List<ITypeUpdateAction> Actions { get; set;}
    }
}
