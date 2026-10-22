

namespace commercetools.Sdk.Api.Models.Warnings
{

    public partial class StoreSettingOngoingWarning : IStoreSettingOngoingWarning
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public StoreSettingOngoingWarning()
        {
            this.Code = "StoreSettingOngoing";
        }
    }
}
