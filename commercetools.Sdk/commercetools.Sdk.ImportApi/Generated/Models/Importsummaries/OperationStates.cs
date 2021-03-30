using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsummaries
{
    public partial class OperationStates : IOperationStates
    {
        public long ValidationFailed { get; set;}
        
        public long Unresolved { get; set;}
        
        public long WaitForMasterVariant { get; set;}
        
        public long Imported { get; set;}
        
        public long Rejected { get; set;}
    }
}
