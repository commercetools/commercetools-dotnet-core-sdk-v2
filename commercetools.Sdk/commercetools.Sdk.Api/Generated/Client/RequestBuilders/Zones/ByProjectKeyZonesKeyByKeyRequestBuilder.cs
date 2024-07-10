using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyZonesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyZonesKeyByKeyGet Get()
        {
            return new ByProjectKeyZonesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyZonesKeyByKeyHead Head()
        {
            return new ByProjectKeyZonesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyZonesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Zones.IZoneUpdate zoneUpdate)
        {
            return new ByProjectKeyZonesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, zoneUpdate);
        }

        public ByProjectKeyZonesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyZonesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
