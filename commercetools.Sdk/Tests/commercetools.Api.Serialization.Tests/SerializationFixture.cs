using System;
using System.Collections.Generic;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.Serialization.Tests
{
    public class SerializationFixture
    {
        public SerializationFixture()
        {
            var services = new ServiceCollection();
            services.UseCommercetoolsApiSerialization();
            var serviceProvider = services.BuildServiceProvider();
            this.SerializerService = serviceProvider.GetService<IApiSerializerService>();
        }

        public ISerializerService SerializerService { get; private set; }
    }
}