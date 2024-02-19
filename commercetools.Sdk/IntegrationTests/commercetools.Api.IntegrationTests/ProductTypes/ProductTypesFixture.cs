using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.ProductTypes
{
    public class ProductTypesFixture
    {
        public static ProductTypeDraft DefaultProductTypeDraft(ProductTypeDraft productTypeDraft)
        {
            productTypeDraft.Key = TestingUtility.RandomString();
            productTypeDraft.Name = TestingUtility.RandomString();
            productTypeDraft.Description = TestingUtility.RandomString();
            productTypeDraft.Attributes = new List<IAttributeDefinitionDraft>()
            {
                new AttributeDefinitionDraft()
                {
                    Name = "number",
                    Type = new AttributeNumberType(),
                    IsRequired = false,
                    IsSearchable = true,
                    Label = new LocalizedString() { { "en", "number" } }
                },
                new AttributeDefinitionDraft()
                {
                    Name = "integer",
                    Type = new AttributeNumberType(),
                    IsRequired = false,
                    IsSearchable = true,
                    Label = new LocalizedString() { { "en", "integer" } }
                },
                new AttributeDefinitionDraft()
                {
                    Name = "text",
                    Type = new AttributeTextType(),
                    IsRequired = false,
                    IsSearchable = true,
                    Label = new LocalizedString() { { "en", "text" } }
                }

            };
            return productTypeDraft;
        }

        #region CreateAndDelete

        public static async Task<IProductType> CreateProductType(ProjectApiRoot apiRoot, ProductTypeDraft productTypeDraft)
        {
            return await apiRoot
                .ProductTypes()
                .Post(productTypeDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteProductType(ProjectApiRoot apiRoot, IProductType productType)
        {
            try
            {
                await apiRoot
                    .ProductTypes()
                    .WithId(productType.Id)
                    .Delete()
                    .WithVersion(productType.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static async Task<IProductType> CreateOrRetrieveProductType(ProjectApiRoot apiRoot, ProductTypeDraft productTypeDraft)
        {
            IProductType productType = null;
            try
            {
                productType = await apiRoot
                    .ProductTypes()
                    .WithKey(productTypeDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                productType = await apiRoot
                    .ProductTypes()
                    .Post(productTypeDraft).ExecuteAsync();
            }

            return productType;
        }
        #endregion

        public static async Task WithProductType(ProjectApiRoot apiRoot, Func<IProductType, Task> func)
        {
            await WithAsync(apiRoot, new ProductTypeDraft(), DefaultProductTypeDraft, func, CreateProductType, DeleteProductType);
        }
    }
}