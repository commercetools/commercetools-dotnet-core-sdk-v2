using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importsinks
{
    public partial class ImportSinkPagedResponse : IImportSinkPagedResponse
    {
        public int Limit { get; set;}
        
        public long Offset { get; set;}
        
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public List<IImportSink> Results { get; set;}
    }
}
