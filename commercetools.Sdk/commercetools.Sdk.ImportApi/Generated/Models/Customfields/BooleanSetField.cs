using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class BooleanSetField : IBooleanSetField
    {
        public string Type { get; set; }

        public List<bool> Value { get; set; }
        public BooleanSetField()
        {
            this.Type = "BooleanSet";
        }
    }
}
