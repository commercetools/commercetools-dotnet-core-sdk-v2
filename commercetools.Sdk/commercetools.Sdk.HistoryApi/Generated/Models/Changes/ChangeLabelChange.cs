using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLabelChange : IChangeLabelChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedString NextValue { get; set; }

        public ILocalizedString PreviousValue { get; set; }
        public ChangeLabelChange()
        {
            this.Type = "ChangeLabelChange";
        }
    }
}
