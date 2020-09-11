namespace commercetools.Api.Client.Defaultconfig
{
    public class RegionHosts
    {
        public string ApiUrl { get; set; }

        public string AuthUrl { get; set; }

        public string AuthTokenUrl
        {
            get
            {
                return this.AuthUrl + "/oauth/token";
            }
        }

        public RegionHosts(string apiUrl, string authUrl)
        {
            this.ApiUrl = apiUrl;
            this.AuthUrl = authUrl;
        }
    }
}
