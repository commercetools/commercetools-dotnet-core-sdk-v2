

namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{

    public partial class TimeToLiveRetentionPolicy : ITimeToLiveRetentionPolicy
    {
        public IStrategyEnum Strategy { get; set; }

        public ITimeToLiveConfig Config { get; set; }
        public TimeToLiveRetentionPolicy()
        {
            this.Strategy = IStrategyEnum.FindEnum("ttl");
        }
    }
}
