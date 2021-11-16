using System.Collections.Generic;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateEnumValuesError : IDuplicateEnumValuesError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public List<string> Duplicates { get; set;}
        public DuplicateEnumValuesError()
        { 
           this.Code = "DuplicateEnumValues";
        }
    }
}
