using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class NumberSetField : INumberSetField
    {
        public string Type { get; set;}
        
        public List<double> Value { get; set;}
        public NumberSetField()
        { 
           this.Type = "NumberSet";
        }
    }
}
