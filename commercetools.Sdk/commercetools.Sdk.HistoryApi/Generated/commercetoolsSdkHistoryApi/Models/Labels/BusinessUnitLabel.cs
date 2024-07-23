namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class BusinessUnitLabel : IBusinessUnitLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
        public BusinessUnitLabel()
        {
            this.Type = "BusinessUnitLabel";
        }
    }
}
