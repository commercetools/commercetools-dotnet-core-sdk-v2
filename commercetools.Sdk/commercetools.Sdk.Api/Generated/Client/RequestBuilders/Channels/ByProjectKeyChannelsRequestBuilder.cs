using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Channels;

namespace commercetools.Api.Client.RequestBuilders.Channels
{
   
   public class ByProjectKeyChannelsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyChannelsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyChannelsGet Get() {
           return new ByProjectKeyChannelsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyChannelsPost Post(commercetools.Api.Models.Channels.IChannelDraft channelDraft) {
           return new ByProjectKeyChannelsPost(ApiHttpClient, SerializerService, ProjectKey, channelDraft);
       }
       
       
       public ByProjectKeyChannelsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyChannelsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
