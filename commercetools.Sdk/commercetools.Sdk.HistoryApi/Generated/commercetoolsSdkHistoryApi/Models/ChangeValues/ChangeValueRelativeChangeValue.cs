

namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeValueRelativeChangeValue : IChangeValueRelativeChangeValue
    {
        public string Type { get; set; }

        public int Permyriad { get; set; }
        public ChangeValueRelativeChangeValue()
        {
            this.Type = "relative";
        }
    }
}
