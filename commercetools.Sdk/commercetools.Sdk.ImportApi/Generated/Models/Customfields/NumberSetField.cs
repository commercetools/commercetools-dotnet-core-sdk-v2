using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    public partial class NumberSetField : INumberSetField
    {
        public string Type { get; set; }

        public List<decimal> Value { get; set; }
        public NumberSetField()
        {
            this.Type = "NumberSet";
        }
    }
}
