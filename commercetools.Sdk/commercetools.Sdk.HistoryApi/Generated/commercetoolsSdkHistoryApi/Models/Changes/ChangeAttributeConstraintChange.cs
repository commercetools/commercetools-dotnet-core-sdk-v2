using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAttributeConstraintChange : IChangeAttributeConstraintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeConstraintEnum PreviousValue { get; set; }

        public IAttributeConstraintEnum NextValue { get; set; }

        public string AttributeName { get; set; }
        public ChangeAttributeConstraintChange()
        {
            this.Type = "ChangeAttributeConstraintChange";
        }
    }
}
