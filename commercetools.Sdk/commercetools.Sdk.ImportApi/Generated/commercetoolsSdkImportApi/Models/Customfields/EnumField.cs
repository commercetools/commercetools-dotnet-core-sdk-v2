

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class EnumField : IEnumField
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public EnumField()
        {
            this.Type = "Enum";
        }
    }
}
