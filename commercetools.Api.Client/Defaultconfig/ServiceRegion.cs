using System;
namespace commercetools.Api.Client.Defaultconfig
{
    public static class ServiceRegion
    {
        public readonly static RegionHosts GCP_EUROPE_WEST1 =
            new RegionHosts(
                "https://api.europe-west1.gcp.commercetools.com",
                "https://auth.europe-west1.gcp.commercetools.com");

        public readonly static RegionHosts GCP_US_CENTRAL1 =
            new RegionHosts(
                "https://api.us-central1.gcp.commercetools.com",
                "https://auth.us-central1.gcp.commercetools.com");

        public readonly static RegionHosts AWS_US_EAST_2 =
            new RegionHosts(
                "https://api.us-east-2.aws.commercetools.com",
                "https://auth.us-east-2.aws.commercetools.com");

        public readonly static RegionHosts AWS_EU_CENTRAL_1 =
            new RegionHosts(
                 "https://api.eu-central-1.aws.commercetools.com",
                 "https://auth.eu-central-1.aws.commercetools.com");

        public readonly static RegionHosts GCP_AUSTRALIA_SOUTHEAST1 =
            new RegionHosts(
                 "https://api.australia-southeast1.gcp.commercetools.com",
                 "https://auth.australia-southeast1.gcp.commercetools.com");
    }
}
