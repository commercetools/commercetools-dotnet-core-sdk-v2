using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    public enum McpServerTool
    {
        [Description("all")]
        All,

        [Description("read_all")]
        ReadAll,

        [Description("create_applications")]
        CreateApplications,

        [Description("read_applications")]
        ReadApplications,

        [Description("update_applications")]
        UpdateApplications,

        [Description("create_attribute_groups")]
        CreateAttributeGroups,

        [Description("read_attribute_groups")]
        ReadAttributeGroups,

        [Description("update_attribute_groups")]
        UpdateAttributeGroups,

        [Description("create_bulk")]
        CreateBulk,

        [Description("update_bulk")]
        UpdateBulk,

        [Description("create_business_units")]
        CreateBusinessUnits,

        [Description("read_business_units")]
        ReadBusinessUnits,

        [Description("update_business_units")]
        UpdateBusinessUnits,

        [Description("create_cart_discounts")]
        CreateCartDiscounts,

        [Description("read_cart_discounts")]
        ReadCartDiscounts,

        [Description("update_cart_discounts")]
        UpdateCartDiscounts,

        [Description("create_carts")]
        CreateCarts,

        [Description("read_carts")]
        ReadCarts,

        [Description("update_carts")]
        UpdateCarts,

        [Description("replicate_carts")]
        ReplicateCarts,

        [Description("create_categories")]
        CreateCategories,

        [Description("read_categories")]
        ReadCategories,

        [Description("update_categories")]
        UpdateCategories,

        [Description("create_channels")]
        CreateChannels,

        [Description("read_channels")]
        ReadChannels,

        [Description("update_channels")]
        UpdateChannels,

        [Description("create_custom_objects")]
        CreateCustomObjects,

        [Description("read_custom_objects")]
        ReadCustomObjects,

        [Description("update_custom_objects")]
        UpdateCustomObjects,

        [Description("create_customer_groups")]
        CreateCustomerGroups,

        [Description("read_customer_groups")]
        ReadCustomerGroups,

        [Description("update_customer_groups")]
        UpdateCustomerGroups,

        [Description("read_customer_search")]
        ReadCustomerSearch,

        [Description("create_customers")]
        CreateCustomers,

        [Description("read_customers")]
        ReadCustomers,

        [Description("update_customers")]
        UpdateCustomers,

        [Description("create_discount_codes")]
        CreateDiscountCodes,

        [Description("read_discount_codes")]
        ReadDiscountCodes,

        [Description("update_discount_codes")]
        UpdateDiscountCodes,

        [Description("create_extensions")]
        CreateExtensions,

        [Description("read_extensions")]
        ReadExtensions,

        [Description("update_extensions")]
        UpdateExtensions,

        [Description("create_inventory")]
        CreateInventory,

        [Description("read_inventory")]
        ReadInventory,

        [Description("update_inventory")]
        UpdateInventory,

        [Description("read_messages")]
        ReadMessages,

        [Description("create_orders")]
        CreateOrders,

        [Description("read_orders")]
        ReadOrders,

        [Description("update_orders")]
        UpdateOrders,

        [Description("create_payment_integrations")]
        CreatePaymentIntegrations,

        [Description("read_payment_integrations")]
        ReadPaymentIntegrations,

        [Description("update_payment_integrations")]
        UpdatePaymentIntegrations,

        [Description("update_payment_intents")]
        UpdatePaymentIntents,

        [Description("create_payment_methods")]
        CreatePaymentMethods,

        [Description("read_payment_methods")]
        ReadPaymentMethods,

        [Description("update_payment_methods")]
        UpdatePaymentMethods,

        [Description("create_payments")]
        CreatePayments,

        [Description("read_payments")]
        ReadPayments,

        [Description("update_payments")]
        UpdatePayments,

        [Description("create_product_discounts")]
        CreateProductDiscounts,

        [Description("read_product_discounts")]
        ReadProductDiscounts,

        [Description("update_product_discounts")]
        UpdateProductDiscounts,

        [Description("read_product_projections")]
        ReadProductProjections,

        [Description("read_product_search")]
        ReadProductSearch,

        [Description("create_product_selections")]
        CreateProductSelections,

        [Description("read_product_selections")]
        ReadProductSelections,

        [Description("update_product_selections")]
        UpdateProductSelections,

        [Description("create_product_tailoring")]
        CreateProductTailoring,

        [Description("read_product_tailoring")]
        ReadProductTailoring,

        [Description("update_product_tailoring")]
        UpdateProductTailoring,

        [Description("create_product_types")]
        CreateProductTypes,

        [Description("read_product_types")]
        ReadProductTypes,

        [Description("update_product_types")]
        UpdateProductTypes,

        [Description("create_products")]
        CreateProducts,

        [Description("read_products")]
        ReadProducts,

        [Description("update_products")]
        UpdateProducts,

        [Description("read_project")]
        ReadProject,

        [Description("update_project")]
        UpdateProject,

        [Description("create_quote_requests")]
        CreateQuoteRequests,

        [Description("read_quote_requests")]
        ReadQuoteRequests,

        [Description("update_quote_requests")]
        UpdateQuoteRequests,

        [Description("create_quotes")]
        CreateQuotes,

        [Description("read_quotes")]
        ReadQuotes,

        [Description("update_quotes")]
        UpdateQuotes,

        [Description("create_recurring_orders")]
        CreateRecurringOrders,

        [Description("read_recurring_orders")]
        ReadRecurringOrders,

        [Description("update_recurring_orders")]
        UpdateRecurringOrders,

        [Description("create_reviews")]
        CreateReviews,

        [Description("read_reviews")]
        ReadReviews,

        [Description("update_reviews")]
        UpdateReviews,

        [Description("create_shipping_methods")]
        CreateShippingMethods,

        [Description("read_shipping_methods")]
        ReadShippingMethods,

        [Description("update_shipping_methods")]
        UpdateShippingMethods,

        [Description("create_shopping_lists")]
        CreateShoppingLists,

        [Description("read_shopping_lists")]
        ReadShoppingLists,

        [Description("update_shopping_lists")]
        UpdateShoppingLists,

        [Description("create_staged_quotes")]
        CreateStagedQuotes,

        [Description("read_staged_quotes")]
        ReadStagedQuotes,

        [Description("update_staged_quotes")]
        UpdateStagedQuotes,

        [Description("create_standalone_prices")]
        CreateStandalonePrices,

        [Description("read_standalone_prices")]
        ReadStandalonePrices,

        [Description("update_standalone_prices")]
        UpdateStandalonePrices,

        [Description("create_states")]
        CreateStates,

        [Description("read_states")]
        ReadStates,

        [Description("update_states")]
        UpdateStates,

        [Description("create_stores")]
        CreateStores,

        [Description("read_stores")]
        ReadStores,

        [Description("update_stores")]
        UpdateStores,

        [Description("create_subscriptions")]
        CreateSubscriptions,

        [Description("read_subscriptions")]
        ReadSubscriptions,

        [Description("update_subscriptions")]
        UpdateSubscriptions,

        [Description("create_tax_categories")]
        CreateTaxCategories,

        [Description("read_tax_categories")]
        ReadTaxCategories,

        [Description("update_tax_categories")]
        UpdateTaxCategories,

        [Description("create_transactions")]
        CreateTransactions,

        [Description("read_transactions")]
        ReadTransactions,

        [Description("create_types")]
        CreateTypes,

        [Description("read_types")]
        ReadTypes,

        [Description("update_types")]
        UpdateTypes,

        [Description("create_zones")]
        CreateZones,

        [Description("read_zones")]
        ReadZones,

        [Description("update_zones")]
        UpdateZones
    }

    public class McpServerToolWrapper : IMcpServerTool
    {
        public string JsonName { get; internal set; }
        public McpServerTool? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IMcpServerTool), "FindEnum")]
    public interface IMcpServerTool : IJsonName, IEnumerable<char>
    {
        public static IMcpServerTool All = new McpServerToolWrapper
        { Value = McpServerTool.All, JsonName = "all" };

        public static IMcpServerTool ReadAll = new McpServerToolWrapper
        { Value = McpServerTool.ReadAll, JsonName = "read_all" };

        public static IMcpServerTool CreateApplications = new McpServerToolWrapper
        { Value = McpServerTool.CreateApplications, JsonName = "create_applications" };

        public static IMcpServerTool ReadApplications = new McpServerToolWrapper
        { Value = McpServerTool.ReadApplications, JsonName = "read_applications" };

        public static IMcpServerTool UpdateApplications = new McpServerToolWrapper
        { Value = McpServerTool.UpdateApplications, JsonName = "update_applications" };

        public static IMcpServerTool CreateAttributeGroups = new McpServerToolWrapper
        { Value = McpServerTool.CreateAttributeGroups, JsonName = "create_attribute_groups" };

        public static IMcpServerTool ReadAttributeGroups = new McpServerToolWrapper
        { Value = McpServerTool.ReadAttributeGroups, JsonName = "read_attribute_groups" };

        public static IMcpServerTool UpdateAttributeGroups = new McpServerToolWrapper
        { Value = McpServerTool.UpdateAttributeGroups, JsonName = "update_attribute_groups" };

        public static IMcpServerTool CreateBulk = new McpServerToolWrapper
        { Value = McpServerTool.CreateBulk, JsonName = "create_bulk" };

        public static IMcpServerTool UpdateBulk = new McpServerToolWrapper
        { Value = McpServerTool.UpdateBulk, JsonName = "update_bulk" };

        public static IMcpServerTool CreateBusinessUnits = new McpServerToolWrapper
        { Value = McpServerTool.CreateBusinessUnits, JsonName = "create_business_units" };

        public static IMcpServerTool ReadBusinessUnits = new McpServerToolWrapper
        { Value = McpServerTool.ReadBusinessUnits, JsonName = "read_business_units" };

        public static IMcpServerTool UpdateBusinessUnits = new McpServerToolWrapper
        { Value = McpServerTool.UpdateBusinessUnits, JsonName = "update_business_units" };

        public static IMcpServerTool CreateCartDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.CreateCartDiscounts, JsonName = "create_cart_discounts" };

        public static IMcpServerTool ReadCartDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.ReadCartDiscounts, JsonName = "read_cart_discounts" };

        public static IMcpServerTool UpdateCartDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCartDiscounts, JsonName = "update_cart_discounts" };

        public static IMcpServerTool CreateCarts = new McpServerToolWrapper
        { Value = McpServerTool.CreateCarts, JsonName = "create_carts" };

        public static IMcpServerTool ReadCarts = new McpServerToolWrapper
        { Value = McpServerTool.ReadCarts, JsonName = "read_carts" };

        public static IMcpServerTool UpdateCarts = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCarts, JsonName = "update_carts" };

        public static IMcpServerTool ReplicateCarts = new McpServerToolWrapper
        { Value = McpServerTool.ReplicateCarts, JsonName = "replicate_carts" };

        public static IMcpServerTool CreateCategories = new McpServerToolWrapper
        { Value = McpServerTool.CreateCategories, JsonName = "create_categories" };

        public static IMcpServerTool ReadCategories = new McpServerToolWrapper
        { Value = McpServerTool.ReadCategories, JsonName = "read_categories" };

        public static IMcpServerTool UpdateCategories = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCategories, JsonName = "update_categories" };

        public static IMcpServerTool CreateChannels = new McpServerToolWrapper
        { Value = McpServerTool.CreateChannels, JsonName = "create_channels" };

        public static IMcpServerTool ReadChannels = new McpServerToolWrapper
        { Value = McpServerTool.ReadChannels, JsonName = "read_channels" };

        public static IMcpServerTool UpdateChannels = new McpServerToolWrapper
        { Value = McpServerTool.UpdateChannels, JsonName = "update_channels" };

        public static IMcpServerTool CreateCustomObjects = new McpServerToolWrapper
        { Value = McpServerTool.CreateCustomObjects, JsonName = "create_custom_objects" };

        public static IMcpServerTool ReadCustomObjects = new McpServerToolWrapper
        { Value = McpServerTool.ReadCustomObjects, JsonName = "read_custom_objects" };

        public static IMcpServerTool UpdateCustomObjects = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCustomObjects, JsonName = "update_custom_objects" };

        public static IMcpServerTool CreateCustomerGroups = new McpServerToolWrapper
        { Value = McpServerTool.CreateCustomerGroups, JsonName = "create_customer_groups" };

        public static IMcpServerTool ReadCustomerGroups = new McpServerToolWrapper
        { Value = McpServerTool.ReadCustomerGroups, JsonName = "read_customer_groups" };

        public static IMcpServerTool UpdateCustomerGroups = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCustomerGroups, JsonName = "update_customer_groups" };

        public static IMcpServerTool ReadCustomerSearch = new McpServerToolWrapper
        { Value = McpServerTool.ReadCustomerSearch, JsonName = "read_customer_search" };

        public static IMcpServerTool CreateCustomers = new McpServerToolWrapper
        { Value = McpServerTool.CreateCustomers, JsonName = "create_customers" };

        public static IMcpServerTool ReadCustomers = new McpServerToolWrapper
        { Value = McpServerTool.ReadCustomers, JsonName = "read_customers" };

        public static IMcpServerTool UpdateCustomers = new McpServerToolWrapper
        { Value = McpServerTool.UpdateCustomers, JsonName = "update_customers" };

        public static IMcpServerTool CreateDiscountCodes = new McpServerToolWrapper
        { Value = McpServerTool.CreateDiscountCodes, JsonName = "create_discount_codes" };

        public static IMcpServerTool ReadDiscountCodes = new McpServerToolWrapper
        { Value = McpServerTool.ReadDiscountCodes, JsonName = "read_discount_codes" };

        public static IMcpServerTool UpdateDiscountCodes = new McpServerToolWrapper
        { Value = McpServerTool.UpdateDiscountCodes, JsonName = "update_discount_codes" };

        public static IMcpServerTool CreateExtensions = new McpServerToolWrapper
        { Value = McpServerTool.CreateExtensions, JsonName = "create_extensions" };

        public static IMcpServerTool ReadExtensions = new McpServerToolWrapper
        { Value = McpServerTool.ReadExtensions, JsonName = "read_extensions" };

        public static IMcpServerTool UpdateExtensions = new McpServerToolWrapper
        { Value = McpServerTool.UpdateExtensions, JsonName = "update_extensions" };

        public static IMcpServerTool CreateInventory = new McpServerToolWrapper
        { Value = McpServerTool.CreateInventory, JsonName = "create_inventory" };

        public static IMcpServerTool ReadInventory = new McpServerToolWrapper
        { Value = McpServerTool.ReadInventory, JsonName = "read_inventory" };

        public static IMcpServerTool UpdateInventory = new McpServerToolWrapper
        { Value = McpServerTool.UpdateInventory, JsonName = "update_inventory" };

        public static IMcpServerTool ReadMessages = new McpServerToolWrapper
        { Value = McpServerTool.ReadMessages, JsonName = "read_messages" };

        public static IMcpServerTool CreateOrders = new McpServerToolWrapper
        { Value = McpServerTool.CreateOrders, JsonName = "create_orders" };

        public static IMcpServerTool ReadOrders = new McpServerToolWrapper
        { Value = McpServerTool.ReadOrders, JsonName = "read_orders" };

        public static IMcpServerTool UpdateOrders = new McpServerToolWrapper
        { Value = McpServerTool.UpdateOrders, JsonName = "update_orders" };

        public static IMcpServerTool CreatePaymentIntegrations = new McpServerToolWrapper
        { Value = McpServerTool.CreatePaymentIntegrations, JsonName = "create_payment_integrations" };

        public static IMcpServerTool ReadPaymentIntegrations = new McpServerToolWrapper
        { Value = McpServerTool.ReadPaymentIntegrations, JsonName = "read_payment_integrations" };

        public static IMcpServerTool UpdatePaymentIntegrations = new McpServerToolWrapper
        { Value = McpServerTool.UpdatePaymentIntegrations, JsonName = "update_payment_integrations" };

        public static IMcpServerTool UpdatePaymentIntents = new McpServerToolWrapper
        { Value = McpServerTool.UpdatePaymentIntents, JsonName = "update_payment_intents" };

        public static IMcpServerTool CreatePaymentMethods = new McpServerToolWrapper
        { Value = McpServerTool.CreatePaymentMethods, JsonName = "create_payment_methods" };

        public static IMcpServerTool ReadPaymentMethods = new McpServerToolWrapper
        { Value = McpServerTool.ReadPaymentMethods, JsonName = "read_payment_methods" };

        public static IMcpServerTool UpdatePaymentMethods = new McpServerToolWrapper
        { Value = McpServerTool.UpdatePaymentMethods, JsonName = "update_payment_methods" };

        public static IMcpServerTool CreatePayments = new McpServerToolWrapper
        { Value = McpServerTool.CreatePayments, JsonName = "create_payments" };

        public static IMcpServerTool ReadPayments = new McpServerToolWrapper
        { Value = McpServerTool.ReadPayments, JsonName = "read_payments" };

        public static IMcpServerTool UpdatePayments = new McpServerToolWrapper
        { Value = McpServerTool.UpdatePayments, JsonName = "update_payments" };

        public static IMcpServerTool CreateProductDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.CreateProductDiscounts, JsonName = "create_product_discounts" };

        public static IMcpServerTool ReadProductDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductDiscounts, JsonName = "read_product_discounts" };

        public static IMcpServerTool UpdateProductDiscounts = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProductDiscounts, JsonName = "update_product_discounts" };

        public static IMcpServerTool ReadProductProjections = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductProjections, JsonName = "read_product_projections" };

        public static IMcpServerTool ReadProductSearch = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductSearch, JsonName = "read_product_search" };

        public static IMcpServerTool CreateProductSelections = new McpServerToolWrapper
        { Value = McpServerTool.CreateProductSelections, JsonName = "create_product_selections" };

        public static IMcpServerTool ReadProductSelections = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductSelections, JsonName = "read_product_selections" };

        public static IMcpServerTool UpdateProductSelections = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProductSelections, JsonName = "update_product_selections" };

        public static IMcpServerTool CreateProductTailoring = new McpServerToolWrapper
        { Value = McpServerTool.CreateProductTailoring, JsonName = "create_product_tailoring" };

        public static IMcpServerTool ReadProductTailoring = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductTailoring, JsonName = "read_product_tailoring" };

        public static IMcpServerTool UpdateProductTailoring = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProductTailoring, JsonName = "update_product_tailoring" };

        public static IMcpServerTool CreateProductTypes = new McpServerToolWrapper
        { Value = McpServerTool.CreateProductTypes, JsonName = "create_product_types" };

        public static IMcpServerTool ReadProductTypes = new McpServerToolWrapper
        { Value = McpServerTool.ReadProductTypes, JsonName = "read_product_types" };

        public static IMcpServerTool UpdateProductTypes = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProductTypes, JsonName = "update_product_types" };

        public static IMcpServerTool CreateProducts = new McpServerToolWrapper
        { Value = McpServerTool.CreateProducts, JsonName = "create_products" };

        public static IMcpServerTool ReadProducts = new McpServerToolWrapper
        { Value = McpServerTool.ReadProducts, JsonName = "read_products" };

        public static IMcpServerTool UpdateProducts = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProducts, JsonName = "update_products" };

        public static IMcpServerTool ReadProject = new McpServerToolWrapper
        { Value = McpServerTool.ReadProject, JsonName = "read_project" };

        public static IMcpServerTool UpdateProject = new McpServerToolWrapper
        { Value = McpServerTool.UpdateProject, JsonName = "update_project" };

        public static IMcpServerTool CreateQuoteRequests = new McpServerToolWrapper
        { Value = McpServerTool.CreateQuoteRequests, JsonName = "create_quote_requests" };

        public static IMcpServerTool ReadQuoteRequests = new McpServerToolWrapper
        { Value = McpServerTool.ReadQuoteRequests, JsonName = "read_quote_requests" };

        public static IMcpServerTool UpdateQuoteRequests = new McpServerToolWrapper
        { Value = McpServerTool.UpdateQuoteRequests, JsonName = "update_quote_requests" };

        public static IMcpServerTool CreateQuotes = new McpServerToolWrapper
        { Value = McpServerTool.CreateQuotes, JsonName = "create_quotes" };

        public static IMcpServerTool ReadQuotes = new McpServerToolWrapper
        { Value = McpServerTool.ReadQuotes, JsonName = "read_quotes" };

        public static IMcpServerTool UpdateQuotes = new McpServerToolWrapper
        { Value = McpServerTool.UpdateQuotes, JsonName = "update_quotes" };

        public static IMcpServerTool CreateRecurringOrders = new McpServerToolWrapper
        { Value = McpServerTool.CreateRecurringOrders, JsonName = "create_recurring_orders" };

        public static IMcpServerTool ReadRecurringOrders = new McpServerToolWrapper
        { Value = McpServerTool.ReadRecurringOrders, JsonName = "read_recurring_orders" };

        public static IMcpServerTool UpdateRecurringOrders = new McpServerToolWrapper
        { Value = McpServerTool.UpdateRecurringOrders, JsonName = "update_recurring_orders" };

        public static IMcpServerTool CreateReviews = new McpServerToolWrapper
        { Value = McpServerTool.CreateReviews, JsonName = "create_reviews" };

        public static IMcpServerTool ReadReviews = new McpServerToolWrapper
        { Value = McpServerTool.ReadReviews, JsonName = "read_reviews" };

        public static IMcpServerTool UpdateReviews = new McpServerToolWrapper
        { Value = McpServerTool.UpdateReviews, JsonName = "update_reviews" };

        public static IMcpServerTool CreateShippingMethods = new McpServerToolWrapper
        { Value = McpServerTool.CreateShippingMethods, JsonName = "create_shipping_methods" };

        public static IMcpServerTool ReadShippingMethods = new McpServerToolWrapper
        { Value = McpServerTool.ReadShippingMethods, JsonName = "read_shipping_methods" };

        public static IMcpServerTool UpdateShippingMethods = new McpServerToolWrapper
        { Value = McpServerTool.UpdateShippingMethods, JsonName = "update_shipping_methods" };

        public static IMcpServerTool CreateShoppingLists = new McpServerToolWrapper
        { Value = McpServerTool.CreateShoppingLists, JsonName = "create_shopping_lists" };

        public static IMcpServerTool ReadShoppingLists = new McpServerToolWrapper
        { Value = McpServerTool.ReadShoppingLists, JsonName = "read_shopping_lists" };

        public static IMcpServerTool UpdateShoppingLists = new McpServerToolWrapper
        { Value = McpServerTool.UpdateShoppingLists, JsonName = "update_shopping_lists" };

        public static IMcpServerTool CreateStagedQuotes = new McpServerToolWrapper
        { Value = McpServerTool.CreateStagedQuotes, JsonName = "create_staged_quotes" };

        public static IMcpServerTool ReadStagedQuotes = new McpServerToolWrapper
        { Value = McpServerTool.ReadStagedQuotes, JsonName = "read_staged_quotes" };

        public static IMcpServerTool UpdateStagedQuotes = new McpServerToolWrapper
        { Value = McpServerTool.UpdateStagedQuotes, JsonName = "update_staged_quotes" };

        public static IMcpServerTool CreateStandalonePrices = new McpServerToolWrapper
        { Value = McpServerTool.CreateStandalonePrices, JsonName = "create_standalone_prices" };

        public static IMcpServerTool ReadStandalonePrices = new McpServerToolWrapper
        { Value = McpServerTool.ReadStandalonePrices, JsonName = "read_standalone_prices" };

        public static IMcpServerTool UpdateStandalonePrices = new McpServerToolWrapper
        { Value = McpServerTool.UpdateStandalonePrices, JsonName = "update_standalone_prices" };

        public static IMcpServerTool CreateStates = new McpServerToolWrapper
        { Value = McpServerTool.CreateStates, JsonName = "create_states" };

        public static IMcpServerTool ReadStates = new McpServerToolWrapper
        { Value = McpServerTool.ReadStates, JsonName = "read_states" };

        public static IMcpServerTool UpdateStates = new McpServerToolWrapper
        { Value = McpServerTool.UpdateStates, JsonName = "update_states" };

        public static IMcpServerTool CreateStores = new McpServerToolWrapper
        { Value = McpServerTool.CreateStores, JsonName = "create_stores" };

        public static IMcpServerTool ReadStores = new McpServerToolWrapper
        { Value = McpServerTool.ReadStores, JsonName = "read_stores" };

        public static IMcpServerTool UpdateStores = new McpServerToolWrapper
        { Value = McpServerTool.UpdateStores, JsonName = "update_stores" };

        public static IMcpServerTool CreateSubscriptions = new McpServerToolWrapper
        { Value = McpServerTool.CreateSubscriptions, JsonName = "create_subscriptions" };

        public static IMcpServerTool ReadSubscriptions = new McpServerToolWrapper
        { Value = McpServerTool.ReadSubscriptions, JsonName = "read_subscriptions" };

        public static IMcpServerTool UpdateSubscriptions = new McpServerToolWrapper
        { Value = McpServerTool.UpdateSubscriptions, JsonName = "update_subscriptions" };

        public static IMcpServerTool CreateTaxCategories = new McpServerToolWrapper
        { Value = McpServerTool.CreateTaxCategories, JsonName = "create_tax_categories" };

        public static IMcpServerTool ReadTaxCategories = new McpServerToolWrapper
        { Value = McpServerTool.ReadTaxCategories, JsonName = "read_tax_categories" };

        public static IMcpServerTool UpdateTaxCategories = new McpServerToolWrapper
        { Value = McpServerTool.UpdateTaxCategories, JsonName = "update_tax_categories" };

        public static IMcpServerTool CreateTransactions = new McpServerToolWrapper
        { Value = McpServerTool.CreateTransactions, JsonName = "create_transactions" };

        public static IMcpServerTool ReadTransactions = new McpServerToolWrapper
        { Value = McpServerTool.ReadTransactions, JsonName = "read_transactions" };

        public static IMcpServerTool CreateTypes = new McpServerToolWrapper
        { Value = McpServerTool.CreateTypes, JsonName = "create_types" };

        public static IMcpServerTool ReadTypes = new McpServerToolWrapper
        { Value = McpServerTool.ReadTypes, JsonName = "read_types" };

        public static IMcpServerTool UpdateTypes = new McpServerToolWrapper
        { Value = McpServerTool.UpdateTypes, JsonName = "update_types" };

        public static IMcpServerTool CreateZones = new McpServerToolWrapper
        { Value = McpServerTool.CreateZones, JsonName = "create_zones" };

        public static IMcpServerTool ReadZones = new McpServerToolWrapper
        { Value = McpServerTool.ReadZones, JsonName = "read_zones" };

        public static IMcpServerTool UpdateZones = new McpServerToolWrapper
        { Value = McpServerTool.UpdateZones, JsonName = "update_zones" };

        McpServerTool? Value { get; }

        static IMcpServerTool[] Values()
        {
            return new[]
            {
                 All ,
                 ReadAll ,
                 CreateApplications ,
                 ReadApplications ,
                 UpdateApplications ,
                 CreateAttributeGroups ,
                 ReadAttributeGroups ,
                 UpdateAttributeGroups ,
                 CreateBulk ,
                 UpdateBulk ,
                 CreateBusinessUnits ,
                 ReadBusinessUnits ,
                 UpdateBusinessUnits ,
                 CreateCartDiscounts ,
                 ReadCartDiscounts ,
                 UpdateCartDiscounts ,
                 CreateCarts ,
                 ReadCarts ,
                 UpdateCarts ,
                 ReplicateCarts ,
                 CreateCategories ,
                 ReadCategories ,
                 UpdateCategories ,
                 CreateChannels ,
                 ReadChannels ,
                 UpdateChannels ,
                 CreateCustomObjects ,
                 ReadCustomObjects ,
                 UpdateCustomObjects ,
                 CreateCustomerGroups ,
                 ReadCustomerGroups ,
                 UpdateCustomerGroups ,
                 ReadCustomerSearch ,
                 CreateCustomers ,
                 ReadCustomers ,
                 UpdateCustomers ,
                 CreateDiscountCodes ,
                 ReadDiscountCodes ,
                 UpdateDiscountCodes ,
                 CreateExtensions ,
                 ReadExtensions ,
                 UpdateExtensions ,
                 CreateInventory ,
                 ReadInventory ,
                 UpdateInventory ,
                 ReadMessages ,
                 CreateOrders ,
                 ReadOrders ,
                 UpdateOrders ,
                 CreatePaymentIntegrations ,
                 ReadPaymentIntegrations ,
                 UpdatePaymentIntegrations ,
                 UpdatePaymentIntents ,
                 CreatePaymentMethods ,
                 ReadPaymentMethods ,
                 UpdatePaymentMethods ,
                 CreatePayments ,
                 ReadPayments ,
                 UpdatePayments ,
                 CreateProductDiscounts ,
                 ReadProductDiscounts ,
                 UpdateProductDiscounts ,
                 ReadProductProjections ,
                 ReadProductSearch ,
                 CreateProductSelections ,
                 ReadProductSelections ,
                 UpdateProductSelections ,
                 CreateProductTailoring ,
                 ReadProductTailoring ,
                 UpdateProductTailoring ,
                 CreateProductTypes ,
                 ReadProductTypes ,
                 UpdateProductTypes ,
                 CreateProducts ,
                 ReadProducts ,
                 UpdateProducts ,
                 ReadProject ,
                 UpdateProject ,
                 CreateQuoteRequests ,
                 ReadQuoteRequests ,
                 UpdateQuoteRequests ,
                 CreateQuotes ,
                 ReadQuotes ,
                 UpdateQuotes ,
                 CreateRecurringOrders ,
                 ReadRecurringOrders ,
                 UpdateRecurringOrders ,
                 CreateReviews ,
                 ReadReviews ,
                 UpdateReviews ,
                 CreateShippingMethods ,
                 ReadShippingMethods ,
                 UpdateShippingMethods ,
                 CreateShoppingLists ,
                 ReadShoppingLists ,
                 UpdateShoppingLists ,
                 CreateStagedQuotes ,
                 ReadStagedQuotes ,
                 UpdateStagedQuotes ,
                 CreateStandalonePrices ,
                 ReadStandalonePrices ,
                 UpdateStandalonePrices ,
                 CreateStates ,
                 ReadStates ,
                 UpdateStates ,
                 CreateStores ,
                 ReadStores ,
                 UpdateStores ,
                 CreateSubscriptions ,
                 ReadSubscriptions ,
                 UpdateSubscriptions ,
                 CreateTaxCategories ,
                 ReadTaxCategories ,
                 UpdateTaxCategories ,
                 CreateTransactions ,
                 ReadTransactions ,
                 CreateTypes ,
                 ReadTypes ,
                 UpdateTypes ,
                 CreateZones ,
                 ReadZones ,
                 UpdateZones
             };
        }
        static IMcpServerTool FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new McpServerToolWrapper() { JsonName = value };
        }
    }
}
