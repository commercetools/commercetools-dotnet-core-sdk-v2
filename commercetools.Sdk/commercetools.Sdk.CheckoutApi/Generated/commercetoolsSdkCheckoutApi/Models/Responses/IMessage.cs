using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Responses
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Responses.MessageModel))]
    [SubTypeDiscriminator("add_discount_code_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.AddDiscountCodeError))]
    [SubTypeDiscriminator("application_disabled", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ApplicationDeactivated))]
    [SubTypeDiscriminator("cart_emptied_during_checkout", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CartEmptiedDuringCheckout))]
    [SubTypeDiscriminator("cart_empty", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CartEmpty))]
    [SubTypeDiscriminator("cart_not_found", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CartNotFound))]
    [SubTypeDiscriminator("cart_with_exisiting_payment", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CartWithExistingPayment))]
    [SubTypeDiscriminator("checkout_cancelled", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCancelled))]
    [SubTypeDiscriminator("checkout_completed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCompleted))]
    [SubTypeDiscriminator("checkout_loaded", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutLoaded))]
    [SubTypeDiscriminator("checkout_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutStarted))]
    [SubTypeDiscriminator("connector_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ConnectorError))]
    [SubTypeDiscriminator("deprecated_fields", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.DeprecatedFields))]
    [SubTypeDiscriminator("discount_code_not_applicable", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.DiscountCodeNotApplicable))]
    [SubTypeDiscriminator("error_loading_all_payment_integrations", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ErrorLoadingAllPaymentIntegrations))]
    [SubTypeDiscriminator("expired_session", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ExpiredSession))]
    [SubTypeDiscriminator("external_terms_and_conditions_pending", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ExternalTermsAndConditionsPending))]
    [SubTypeDiscriminator("failed_to_refresh_session", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.FailedToRefreshSession))]
    [SubTypeDiscriminator("gift_card_balance_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceError))]
    [SubTypeDiscriminator("gift_card_balance_removed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceRemoved))]
    [SubTypeDiscriminator("gift_card_balance_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceStarted))]
    [SubTypeDiscriminator("gift_card_balance_success", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceSuccess))]
    [SubTypeDiscriminator("gift_card_redeem_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemError))]
    [SubTypeDiscriminator("gift_card_redeem_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemStarted))]
    [SubTypeDiscriminator("gift_card_redeem_success", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemSuccess))]
    [SubTypeDiscriminator("init_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.InitError))]
    [SubTypeDiscriminator("init_timeout", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.InitTimeout))]
    [SubTypeDiscriminator("invalid_fields", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.BadInputData))]
    [SubTypeDiscriminator("invalid_locale", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.InvalidLocale))]
    [SubTypeDiscriminator("invalid_mode", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.InvalidMode))]
    [SubTypeDiscriminator("multiple_vendor_button_containers", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.MultipleVendorButtonContainers))]
    [SubTypeDiscriminator("no_payment_integrations", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.NoPaymentIntegrations))]
    [SubTypeDiscriminator("no_shipping_methods", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.NoShippingMethods))]
    [SubTypeDiscriminator("non_orderable_cart_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.NonOrderableCartError))]
    [SubTypeDiscriminator("not_applicable_discount_code_removed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.NotApplicableDiscountCodeRemoved))]
    [SubTypeDiscriminator("order_created", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreated))]
    [SubTypeDiscriminator("order_creation_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreationError))]
    [SubTypeDiscriminator("order_verification_retry_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationRetryError))]
    [SubTypeDiscriminator("order_verification_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationStarted))]
    [SubTypeDiscriminator("order_verification_timeout", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationTimeout))]
    [SubTypeDiscriminator("payment_cancelled", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentCancelled))]
    [SubTypeDiscriminator("payment_failed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentFailed))]
    [SubTypeDiscriminator("payment_integration_loaded", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoaded))]
    [SubTypeDiscriminator("payment_integration_loading", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoading))]
    [SubTypeDiscriminator("payment_integration_loading_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoadingError))]
    [SubTypeDiscriminator("payment_integration_not_available", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationNotAvailable))]
    [SubTypeDiscriminator("payment_integration_selected", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelected))]
    [SubTypeDiscriminator("payment_integration_selection_confirmation", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmation))]
    [SubTypeDiscriminator("payment_integration_selection_confirmation_failed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmationFailed))]
    [SubTypeDiscriminator("payment_integrations_received", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationsReceived))]
    [SubTypeDiscriminator("payment_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentStarted))]
    [SubTypeDiscriminator("payment_validation_failed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationFailed))]
    [SubTypeDiscriminator("payment_validation_passed", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationPassed))]
    [SubTypeDiscriminator("payment_validation_started", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationStarted))]
    [SubTypeDiscriminator("project_deactivated", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ProjectIsDeactivated))]
    [SubTypeDiscriminator("remove_discount_code_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.RemoveDiscountCodeError))]
    [SubTypeDiscriminator("set_shipping_address_error", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.SetShippingAddressError))]
    [SubTypeDiscriminator("shipping_address_missing", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ShippingAddressMissingError))]
    [SubTypeDiscriminator("shipping_method_does_not_match_cart", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodDoesNotMatchCart))]
    [SubTypeDiscriminator("shipping_method_selected", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelected))]
    [SubTypeDiscriminator("shipping_method_selection_confirmation", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelectionConfirmation))]
    [SubTypeDiscriminator("unavailable_locale", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.UnavailableLocale))]
    [SubTypeDiscriminator("unsupported_country", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.UnsupportedCountry))]
    [SubTypeDiscriminator("updated_fields", typeof(commercetools.Sdk.CheckoutApi.Models.Responses.UpdatedFields))]
    public partial interface IMessage
    {
        string Code { get; set; }

        string Severity { get; set; }

        string Message { get; set; }

        string CorrelationId { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Responses.AddDiscountCodeError AddDiscountCodeError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.AddDiscountCodeError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.AddDiscountCodeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ApplicationDeactivated ApplicationDisabled(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ApplicationDeactivated> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ApplicationDeactivated();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CartEmptiedDuringCheckout CartEmptiedDuringCheckout(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CartEmptiedDuringCheckout> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CartEmptiedDuringCheckout();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CartEmpty CartEmpty(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CartEmpty> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CartEmpty();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CartNotFound CartNotFound(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CartNotFound> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CartNotFound();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CartWithExistingPayment CartWithExisitingPayment(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CartWithExistingPayment> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CartWithExistingPayment();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCancelled CheckoutCancelled(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCancelled> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCancelled();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCompleted CheckoutCompleted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCompleted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutCompleted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutLoaded CheckoutLoaded(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutLoaded> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutLoaded();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutStarted CheckoutStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.CheckoutStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ConnectorError ConnectorError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ConnectorError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ConnectorError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.DeprecatedFields DeprecatedFields(Action<commercetools.Sdk.CheckoutApi.Models.Responses.DeprecatedFields> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.DeprecatedFields();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.DiscountCodeNotApplicable DiscountCodeNotApplicable(Action<commercetools.Sdk.CheckoutApi.Models.Responses.DiscountCodeNotApplicable> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.DiscountCodeNotApplicable();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ErrorLoadingAllPaymentIntegrations ErrorLoadingAllPaymentIntegrations(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ErrorLoadingAllPaymentIntegrations> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ErrorLoadingAllPaymentIntegrations();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ExpiredSession ExpiredSession(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ExpiredSession> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ExpiredSession();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ExternalTermsAndConditionsPending ExternalTermsAndConditionsPending(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ExternalTermsAndConditionsPending> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ExternalTermsAndConditionsPending();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.FailedToRefreshSession FailedToRefreshSession(Action<commercetools.Sdk.CheckoutApi.Models.Responses.FailedToRefreshSession> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.FailedToRefreshSession();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceError GiftCardBalanceError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceRemoved GiftCardBalanceRemoved(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceRemoved> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceRemoved();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceStarted GiftCardBalanceStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceSuccess GiftCardBalanceSuccess(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceSuccess> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardBalanceSuccess();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemError GiftCardRedeemError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemStarted GiftCardRedeemStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemSuccess GiftCardRedeemSuccess(Action<commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemSuccess> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.GiftCardRedeemSuccess();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.InitError InitError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.InitError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.InitError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.InitTimeout InitTimeout(Action<commercetools.Sdk.CheckoutApi.Models.Responses.InitTimeout> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.InitTimeout();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.BadInputData InvalidFields(Action<commercetools.Sdk.CheckoutApi.Models.Responses.BadInputData> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.BadInputData();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.InvalidLocale InvalidLocale(Action<commercetools.Sdk.CheckoutApi.Models.Responses.InvalidLocale> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.InvalidLocale();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.InvalidMode InvalidMode(Action<commercetools.Sdk.CheckoutApi.Models.Responses.InvalidMode> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.InvalidMode();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.MultipleVendorButtonContainers MultipleVendorButtonContainers(Action<commercetools.Sdk.CheckoutApi.Models.Responses.MultipleVendorButtonContainers> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.MultipleVendorButtonContainers();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.NoPaymentIntegrations NoPaymentIntegrations(Action<commercetools.Sdk.CheckoutApi.Models.Responses.NoPaymentIntegrations> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.NoPaymentIntegrations();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.NoShippingMethods NoShippingMethods(Action<commercetools.Sdk.CheckoutApi.Models.Responses.NoShippingMethods> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.NoShippingMethods();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.NonOrderableCartError NonOrderableCartError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.NonOrderableCartError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.NonOrderableCartError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.NotApplicableDiscountCodeRemoved NotApplicableDiscountCodeRemoved(Action<commercetools.Sdk.CheckoutApi.Models.Responses.NotApplicableDiscountCodeRemoved> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.NotApplicableDiscountCodeRemoved();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreated OrderCreated(Action<commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreated> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreated();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreationError OrderCreationError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreationError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.OrderCreationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationRetryError OrderVerificationRetryError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationRetryError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationRetryError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationStarted OrderVerificationStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationTimeout OrderVerificationTimeout(Action<commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationTimeout> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.OrderVerificationTimeout();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentCancelled PaymentCancelled(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentCancelled> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentCancelled();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentFailed PaymentFailed(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentFailed> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentFailed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoaded PaymentIntegrationLoaded(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoaded> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoaded();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoading PaymentIntegrationLoading(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoading> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoading();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoadingError PaymentIntegrationLoadingError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoadingError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationLoadingError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationNotAvailable PaymentIntegrationNotAvailable(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationNotAvailable> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationNotAvailable();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelected PaymentIntegrationSelected(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelected> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelected();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmation PaymentIntegrationSelectionConfirmation(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmation> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmation();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmationFailed PaymentIntegrationSelectionConfirmationFailed(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmationFailed> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationSelectionConfirmationFailed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationsReceived PaymentIntegrationsReceived(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationsReceived> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentIntegrationsReceived();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentStarted PaymentStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationFailed PaymentValidationFailed(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationFailed> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationFailed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationPassed PaymentValidationPassed(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationPassed> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationPassed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationStarted PaymentValidationStarted(Action<commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationStarted> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.PaymentValidationStarted();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ProjectIsDeactivated ProjectDeactivated(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ProjectIsDeactivated> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ProjectIsDeactivated();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.RemoveDiscountCodeError RemoveDiscountCodeError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.RemoveDiscountCodeError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.RemoveDiscountCodeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.SetShippingAddressError SetShippingAddressError(Action<commercetools.Sdk.CheckoutApi.Models.Responses.SetShippingAddressError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.SetShippingAddressError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ShippingAddressMissingError ShippingAddressMissing(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ShippingAddressMissingError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ShippingAddressMissingError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodDoesNotMatchCart ShippingMethodDoesNotMatchCart(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodDoesNotMatchCart> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodDoesNotMatchCart();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelected ShippingMethodSelected(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelected> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelected();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelectionConfirmation ShippingMethodSelectionConfirmation(Action<commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelectionConfirmation> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelectionConfirmation();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.UnavailableLocale UnavailableLocale(Action<commercetools.Sdk.CheckoutApi.Models.Responses.UnavailableLocale> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.UnavailableLocale();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.UnsupportedCountry UnsupportedCountry(Action<commercetools.Sdk.CheckoutApi.Models.Responses.UnsupportedCountry> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.UnsupportedCountry();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Responses.UpdatedFields UpdatedFields(Action<commercetools.Sdk.CheckoutApi.Models.Responses.UpdatedFields> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Responses.UpdatedFields();
            init?.Invoke(t);
            return t;
        }
    }
}
