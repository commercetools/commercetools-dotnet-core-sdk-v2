using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Labels.Label))]
    [SubTypeDiscriminator("AssociateRoleLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.AssociateRoleLabel))]
    [SubTypeDiscriminator("BusinessUnitLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.BusinessUnitLabel))]
    [SubTypeDiscriminator("CustomerLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel))]
    [SubTypeDiscriminator("CustomObjectLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel))]
    [SubTypeDiscriminator("LocalizedLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel))]
    [SubTypeDiscriminator("OrderLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel))]
    [SubTypeDiscriminator("PaymentLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel))]
    [SubTypeDiscriminator("ProductLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel))]
    [SubTypeDiscriminator("QuoteLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.QuoteLabel))]
    [SubTypeDiscriminator("QuoteRequestLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.QuoteRequestLabel))]
    [SubTypeDiscriminator("ReviewLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel))]
    [SubTypeDiscriminator("ShippingMethodLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.ShippingMethodLabel))]
    [SubTypeDiscriminator("StagedQuoteLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.StagedQuoteLabel))]
    [SubTypeDiscriminator("StandalonePriceLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.StandalonePriceLabel))]
    [SubTypeDiscriminator("StringLabel", typeof(commercetools.Sdk.HistoryApi.Models.Labels.StringLabel))]
    public partial interface ILabel
    {
        string Type { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Labels.AssociateRoleLabel AssociateRoleLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.AssociateRoleLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.AssociateRoleLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.BusinessUnitLabel BusinessUnitLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.BusinessUnitLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.BusinessUnitLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel CustomerLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel CustomObjectLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel LocalizedLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel OrderLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel PaymentLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel ProductLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.QuoteLabel QuoteLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.QuoteLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.QuoteLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.QuoteRequestLabel QuoteRequestLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.QuoteRequestLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.QuoteRequestLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel ReviewLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.ShippingMethodLabel ShippingMethodLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.ShippingMethodLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.ShippingMethodLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.StagedQuoteLabel StagedQuoteLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.StagedQuoteLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.StagedQuoteLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.StandalonePriceLabel StandalonePriceLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.StandalonePriceLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.StandalonePriceLabel();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Labels.StringLabel StringLabel(Action<commercetools.Sdk.HistoryApi.Models.Labels.StringLabel> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Labels.StringLabel();
            init?.Invoke(t);
            return t;
        }
    }
}
