using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeModel))]
    [SubTypeDiscriminator("AddAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAddressChange))]
    [SubTypeDiscriminator("AddAssetChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange))]
    [SubTypeDiscriminator("AddAttributeDefinitionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAttributeDefinitionChange))]
    [SubTypeDiscriminator("AddBillingAddressIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddBillingAddressIdChange))]
    [SubTypeDiscriminator("AddChannelRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange))]
    [SubTypeDiscriminator("AddCustomLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddCustomLineItemChange))]
    [SubTypeDiscriminator("AddDeliveryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddDeliveryChange))]
    [SubTypeDiscriminator("AddDiscountCodeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddDiscountCodeChange))]
    [SubTypeDiscriminator("AddEnumValueChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddEnumValueChange))]
    [SubTypeDiscriminator("AddExternalImageChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddExternalImageChange))]
    [SubTypeDiscriminator("AddFieldDefinitionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddFieldDefinitionChange))]
    [SubTypeDiscriminator("AddInterfaceInteractionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange))]
    [SubTypeDiscriminator("AddItemShippingAddressesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddItemShippingAddressesChange))]
    [SubTypeDiscriminator("AddLocalizedEnumValueChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddLocalizedEnumValueChange))]
    [SubTypeDiscriminator("AddLocationChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddLocationChange))]
    [SubTypeDiscriminator("AddOrderLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddOrderLineItemChange))]
    [SubTypeDiscriminator("AddParcelToDeliveryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange))]
    [SubTypeDiscriminator("AddPaymentChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPaymentChange))]
    [SubTypeDiscriminator("AddPlainEnumValueChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange))]
    [SubTypeDiscriminator("AddPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPriceChange))]
    [SubTypeDiscriminator("AddProductChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddProductChange))]
    [SubTypeDiscriminator("AddPropertyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPropertyChange))]
    [SubTypeDiscriminator("AddReturnInfoChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddReturnInfoChange))]
    [SubTypeDiscriminator("AddShippingAddressIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddShippingAddressIdChange))]
    [SubTypeDiscriminator("AddShoppingListLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddShoppingListLineItemChange))]
    [SubTypeDiscriminator("AddStateRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddStateRolesChange))]
    [SubTypeDiscriminator("AddTaxRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddTaxRateChange))]
    [SubTypeDiscriminator("AddTextLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddTextLineItemChange))]
    [SubTypeDiscriminator("AddToCategoryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddToCategoryChange))]
    [SubTypeDiscriminator("AddTransactionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddTransactionChange))]
    [SubTypeDiscriminator("AddVariantChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddVariantChange))]
    [SubTypeDiscriminator("ChangeAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAddressChange))]
    [SubTypeDiscriminator("ChangeAmountAuthorizedChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange))]
    [SubTypeDiscriminator("ChangeAmountPlannedChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountPlannedChange))]
    [SubTypeDiscriminator("ChangeAssetNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetNameChange))]
    [SubTypeDiscriminator("ChangeAssetOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetOrderChange))]
    [SubTypeDiscriminator("ChangeAttributeConstraintChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeConstraintChange))]
    [SubTypeDiscriminator("ChangeAttributeOrderByNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeOrderByNameChange))]
    [SubTypeDiscriminator("ChangeCartDiscountsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartDiscountsChange))]
    [SubTypeDiscriminator("ChangeCartPredicateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartPredicateChange))]
    [SubTypeDiscriminator("ChangeCustomLineItemQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeDescriptionChange))]
    [SubTypeDiscriminator("ChangeEmailChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeEmailChange))]
    [SubTypeDiscriminator("ChangeEnumValueLabelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangeEnumValueOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangeFieldDefinitionOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange))]
    [SubTypeDiscriminator("ChangeGroupsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange))]
    [SubTypeDiscriminator("ChangeInitialChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeInitialChange))]
    [SubTypeDiscriminator("ChangeInputHintChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeInputHintChange))]
    [SubTypeDiscriminator("ChangeIsActiveChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsActiveChange))]
    [SubTypeDiscriminator("ChangeIsSearchableChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsSearchableChange))]
    [SubTypeDiscriminator("ChangeKeyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeKeyChange))]
    [SubTypeDiscriminator("ChangeLabelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLabelChange))]
    [SubTypeDiscriminator("ChangeLineItemQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeLocalizedDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange))]
    [SubTypeDiscriminator("ChangeLocalizedEnumValueLabelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangeLocalizedEnumValueOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangeLocalizedNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedNameChange))]
    [SubTypeDiscriminator("ChangeMasterVariantChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeMasterVariantChange))]
    [SubTypeDiscriminator("ChangeNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeNameChange))]
    [SubTypeDiscriminator("ChangeOrderHintChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderHintChange))]
    [SubTypeDiscriminator("ChangeOrderStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderStateChange))]
    [SubTypeDiscriminator("ChangeParentChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeParentChange))]
    [SubTypeDiscriminator("ChangePaymentStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePaymentStateChange))]
    [SubTypeDiscriminator("ChangePlainEnumValueLabelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangePlainEnumValueOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangePredicateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePredicateChange))]
    [SubTypeDiscriminator("ChangePriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceChange))]
    [SubTypeDiscriminator("ChangeQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuantityChange))]
    [SubTypeDiscriminator("ChangeQuoteRequestStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteRequestStateChange))]
    [SubTypeDiscriminator("ChangeQuoteStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteStateChange))]
    [SubTypeDiscriminator("ChangeRequiresDiscountCodeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange))]
    [SubTypeDiscriminator("ChangeReviewRatingStatisticsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange))]
    [SubTypeDiscriminator("ChangeShipmentStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShipmentStateChange))]
    [SubTypeDiscriminator("ChangeShoppingListLineItemQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeShoppingListLineItemsOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange))]
    [SubTypeDiscriminator("ChangeSlugChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeSlugChange))]
    [SubTypeDiscriminator("ChangeSortOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeSortOrderChange))]
    [SubTypeDiscriminator("ChangeStackingModeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange))]
    [SubTypeDiscriminator("ChangeStagedQuoteStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange))]
    [SubTypeDiscriminator("ChangeStateTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStateTypeChange))]
    [SubTypeDiscriminator("ChangeTargetChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTargetChange))]
    [SubTypeDiscriminator("ChangeTaxCalculationModeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange))]
    [SubTypeDiscriminator("ChangeTaxModeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxModeChange))]
    [SubTypeDiscriminator("ChangeTaxRoundingModeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange))]
    [SubTypeDiscriminator("ChangeTextLineItemNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemNameChange))]
    [SubTypeDiscriminator("ChangeTextLineItemQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeTextLineItemsOrderChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange))]
    [SubTypeDiscriminator("ChangeTransactionInteractionIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange))]
    [SubTypeDiscriminator("ChangeTransactionStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange))]
    [SubTypeDiscriminator("ChangeTransactionTimestampChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionTimestampChange))]
    [SubTypeDiscriminator("ChangeValueChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeValueChange))]
    [SubTypeDiscriminator("MoveImageToPositionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.MoveImageToPositionChange))]
    [SubTypeDiscriminator("PublishChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.PublishChange))]
    [SubTypeDiscriminator("RemoveAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveAddressChange))]
    [SubTypeDiscriminator("RemoveAssetChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssetChange))]
    [SubTypeDiscriminator("RemoveAttributeDefinitionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange))]
    [SubTypeDiscriminator("RemoveBillingAddressIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveBillingAddressIdChange))]
    [SubTypeDiscriminator("RemoveChannelRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveChannelRolesChange))]
    [SubTypeDiscriminator("RemoveCustomLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveCustomLineItemChange))]
    [SubTypeDiscriminator("RemoveDeliveryItemsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveDeliveryItemsChange))]
    [SubTypeDiscriminator("RemoveDiscountCodeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveDiscountCodeChange))]
    [SubTypeDiscriminator("RemoveEnumValuesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange))]
    [SubTypeDiscriminator("RemoveFieldDefinitionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveFieldDefinitionChange))]
    [SubTypeDiscriminator("RemoveFromCategoryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveFromCategoryChange))]
    [SubTypeDiscriminator("RemoveImageChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveImageChange))]
    [SubTypeDiscriminator("RemoveItemShippingAddressesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange))]
    [SubTypeDiscriminator("RemoveLocalizedEnumValuesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange))]
    [SubTypeDiscriminator("RemoveLocationChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocationChange))]
    [SubTypeDiscriminator("RemoveOrderLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveOrderLineItemChange))]
    [SubTypeDiscriminator("RemoveParcelFromDeliveryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange))]
    [SubTypeDiscriminator("RemovePaymentChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemovePaymentChange))]
    [SubTypeDiscriminator("RemovePriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemovePriceChange))]
    [SubTypeDiscriminator("RemoveProductChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveProductChange))]
    [SubTypeDiscriminator("RemovePropertyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemovePropertyChange))]
    [SubTypeDiscriminator("RemoveShippingAddressIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveShippingAddressIdChange))]
    [SubTypeDiscriminator("RemoveShoppingListLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange))]
    [SubTypeDiscriminator("RemoveStateRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveStateRolesChange))]
    [SubTypeDiscriminator("RemoveTaxRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange))]
    [SubTypeDiscriminator("RemoveTextLineItemChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveTextLineItemChange))]
    [SubTypeDiscriminator("RemoveVariantChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveVariantChange))]
    [SubTypeDiscriminator("SetAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAddressChange))]
    [SubTypeDiscriminator("SetAnonymousIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAnonymousIdChange))]
    [SubTypeDiscriminator("SetApplicationVersionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetApplicationVersionChange))]
    [SubTypeDiscriminator("SetAssetCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomFieldChange))]
    [SubTypeDiscriminator("SetAssetCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomTypeChange))]
    [SubTypeDiscriminator("SetAssetDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetDescriptionChange))]
    [SubTypeDiscriminator("SetAssetKeyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetKeyChange))]
    [SubTypeDiscriminator("SetAssetSourcesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetSourcesChange))]
    [SubTypeDiscriminator("SetAssetTagsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetTagsChange))]
    [SubTypeDiscriminator("SetAttributeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAttributeChange))]
    [SubTypeDiscriminator("SetAuthenticationModeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAuthenticationModeChange))]
    [SubTypeDiscriminator("SetAuthorNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAuthorNameChange))]
    [SubTypeDiscriminator("SetBillingAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetBillingAddressChange))]
    [SubTypeDiscriminator("SetCartPredicateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCartPredicateChange))]
    [SubTypeDiscriminator("SetCategoryOrderHintChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCategoryOrderHintChange))]
    [SubTypeDiscriminator("SetChannelRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetChannelRolesChange))]
    [SubTypeDiscriminator("SetCompanyNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCompanyNameChange))]
    [SubTypeDiscriminator("SetCountriesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange))]
    [SubTypeDiscriminator("SetCountryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCountryChange))]
    [SubTypeDiscriminator("SetCustomerChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerChange))]
    [SubTypeDiscriminator("SetCustomerEmailChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerEmailChange))]
    [SubTypeDiscriminator("SetCustomerGroupChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerGroupChange))]
    [SubTypeDiscriminator("SetCustomerIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerIdChange))]
    [SubTypeDiscriminator("SetCustomerNumberChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerNumberChange))]
    [SubTypeDiscriminator("SetCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomFieldChange))]
    [SubTypeDiscriminator("SetCustomLineItemCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetCustomLineItemCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetCustomLineItemMoneyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange))]
    [SubTypeDiscriminator("SetCustomLineItemShippingDetailsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxAmountChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxCategoryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxCategoryChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxRateChange))]
    [SubTypeDiscriminator("SetCustomLineItemTotalPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange))]
    [SubTypeDiscriminator("SetCustomShippingMethodChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomShippingMethodChange))]
    [SubTypeDiscriminator("SetCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomTypeChange))]
    [SubTypeDiscriminator("SetDateOfBirthChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDateOfBirthChange))]
    [SubTypeDiscriminator("SetDefaultBillingAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultBillingAddressChange))]
    [SubTypeDiscriminator("SetDefaultShippingAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultShippingAddressChange))]
    [SubTypeDiscriminator("SetDeleteDaysAfterLastModificationChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange))]
    [SubTypeDiscriminator("SetDeliveryAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange))]
    [SubTypeDiscriminator("SetDeliveryItemsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange))]
    [SubTypeDiscriminator("SetDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDescriptionChange))]
    [SubTypeDiscriminator("SetDiscountedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountedPriceChange))]
    [SubTypeDiscriminator("SetDistributionChannelsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange))]
    [SubTypeDiscriminator("SetExpectedDeliveryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetExpectedDeliveryChange))]
    [SubTypeDiscriminator("SetExternalIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetExternalIdChange))]
    [SubTypeDiscriminator("SetFirstNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetFirstNameChange))]
    [SubTypeDiscriminator("SetGeoLocationChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange))]
    [SubTypeDiscriminator("SetImageLabelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetImageLabelChange))]
    [SubTypeDiscriminator("SetInputTipChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetInputTipChange))]
    [SubTypeDiscriminator("SetInterfaceIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetInterfaceIdChange))]
    [SubTypeDiscriminator("SetIsValidChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetIsValidChange))]
    [SubTypeDiscriminator("SetKeyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetKeyChange))]
    [SubTypeDiscriminator("SetLanguagesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLanguagesChange))]
    [SubTypeDiscriminator("SetLastNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLastNameChange))]
    [SubTypeDiscriminator("SetLineItemDeactivatedAtChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDeactivatedAtChange))]
    [SubTypeDiscriminator("SetLineItemDiscountedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange))]
    [SubTypeDiscriminator("SetLineItemDiscountedPricePerQuantityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange))]
    [SubTypeDiscriminator("SetLineItemDistributionChannelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange))]
    [SubTypeDiscriminator("SetLineItemPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemPriceChange))]
    [SubTypeDiscriminator("SetLineItemProductKeyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductKeyChange))]
    [SubTypeDiscriminator("SetLineItemProductSlugChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductSlugChange))]
    [SubTypeDiscriminator("SetLineItemShippingDetailsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange))]
    [SubTypeDiscriminator("SetLineItemTaxAmountChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxAmountChange))]
    [SubTypeDiscriminator("SetLineItemTaxedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange))]
    [SubTypeDiscriminator("SetLineItemTaxRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxRateChange))]
    [SubTypeDiscriminator("SetLineItemTotalPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTotalPriceChange))]
    [SubTypeDiscriminator("SetLocaleChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLocaleChange))]
    [SubTypeDiscriminator("SetLocalizedDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLocalizedDescriptionChange))]
    [SubTypeDiscriminator("SetMaxApplicationsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsChange))]
    [SubTypeDiscriminator("SetMaxApplicationsPerCustomerChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsPerCustomerChange))]
    [SubTypeDiscriminator("SetMetaDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMetaDescriptionChange))]
    [SubTypeDiscriminator("SetMetaKeywordsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMetaKeywordsChange))]
    [SubTypeDiscriminator("SetMetaTitleChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMetaTitleChange))]
    [SubTypeDiscriminator("SetMethodInfoInterfaceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoInterfaceChange))]
    [SubTypeDiscriminator("SetMethodInfoMethodChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoMethodChange))]
    [SubTypeDiscriminator("SetMethodInfoNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoNameChange))]
    [SubTypeDiscriminator("SetMiddleNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMiddleNameChange))]
    [SubTypeDiscriminator("SetNameChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetNameChange))]
    [SubTypeDiscriminator("SetOrderLineItemCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetOrderLineItemCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetOrderNumberChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderNumberChange))]
    [SubTypeDiscriminator("SetOrderTaxedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTaxedPriceChange))]
    [SubTypeDiscriminator("SetOrderTotalPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalPriceChange))]
    [SubTypeDiscriminator("SetOrderTotalTaxChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalTaxChange))]
    [SubTypeDiscriminator("SetParcelItemsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetParcelItemsChange))]
    [SubTypeDiscriminator("SetParcelMeasurementsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetParcelMeasurementsChange))]
    [SubTypeDiscriminator("SetParcelTrackingDataChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetParcelTrackingDataChange))]
    [SubTypeDiscriminator("SetPricesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPricesChange))]
    [SubTypeDiscriminator("SetProductCountChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductCountChange))]
    [SubTypeDiscriminator("SetProductPriceCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange))]
    [SubTypeDiscriminator("SetProductPriceCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomTypeChange))]
    [SubTypeDiscriminator("SetProductSelectionsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange))]
    [SubTypeDiscriminator("SetProductVariantKeyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductVariantKeyChange))]
    [SubTypeDiscriminator("SetPropertyChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPropertyChange))]
    [SubTypeDiscriminator("SetPurchaseOrderNumberChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPurchaseOrderNumberChange))]
    [SubTypeDiscriminator("SetRatingChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetRatingChange))]
    [SubTypeDiscriminator("SetReservationsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange))]
    [SubTypeDiscriminator("SetRestockableInDaysChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetRestockableInDaysChange))]
    [SubTypeDiscriminator("SetReturnPaymentStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnPaymentStateChange))]
    [SubTypeDiscriminator("SetReturnShipmentStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnShipmentStateChange))]
    [SubTypeDiscriminator("SetSalutationChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSalutationChange))]
    [SubTypeDiscriminator("SetSearchKeywordsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSearchKeywordsChange))]
    [SubTypeDiscriminator("SetSellerCommentChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSellerCommentChange))]
    [SubTypeDiscriminator("SetShippingAddressChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingAddressChange))]
    [SubTypeDiscriminator("SetShippingInfoPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoPriceChange))]
    [SubTypeDiscriminator("SetShippingInfoTaxedPriceChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange))]
    [SubTypeDiscriminator("SetShippingMethodChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange))]
    [SubTypeDiscriminator("SetShippingMethodTaxAmountChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange))]
    [SubTypeDiscriminator("SetShippingMethodTaxRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange))]
    [SubTypeDiscriminator("SetShippingRateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateChange))]
    [SubTypeDiscriminator("SetShippingRateInputChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateInputChange))]
    [SubTypeDiscriminator("SetShoppingListLineItemCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetShoppingListLineItemCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetSkuChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSkuChange))]
    [SubTypeDiscriminator("SetSlugChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSlugChange))]
    [SubTypeDiscriminator("SetStateRolesChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange))]
    [SubTypeDiscriminator("SetStatusInterfaceCodeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceCodeChange))]
    [SubTypeDiscriminator("SetStatusInterfaceTextChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceTextChange))]
    [SubTypeDiscriminator("SetStoreChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStoreChange))]
    [SubTypeDiscriminator("SetStoresChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStoresChange))]
    [SubTypeDiscriminator("SetSupplyChannelChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelChange))]
    [SubTypeDiscriminator("SetSupplyChannelsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelsChange))]
    [SubTypeDiscriminator("SetTargetChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTargetChange))]
    [SubTypeDiscriminator("SetTaxCategoryChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTaxCategoryChange))]
    [SubTypeDiscriminator("SetTextChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTextChange))]
    [SubTypeDiscriminator("SetTextLineItemCustomFieldChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetTextLineItemCustomTypeChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetTextLineItemDescriptionChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemDescriptionChange))]
    [SubTypeDiscriminator("SetTitleChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTitleChange))]
    [SubTypeDiscriminator("SetTransitionsChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTransitionsChange))]
    [SubTypeDiscriminator("SetValidFromAndUntilChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromAndUntilChange))]
    [SubTypeDiscriminator("SetValidFromChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromChange))]
    [SubTypeDiscriminator("SetValidToChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValidToChange))]
    [SubTypeDiscriminator("SetValidUntilChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValidUntilChange))]
    [SubTypeDiscriminator("SetValueChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValueChange))]
    [SubTypeDiscriminator("SetVariantAvailabilityChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetVariantAvailabilityChange))]
    [SubTypeDiscriminator("SetVatIdChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetVatIdChange))]
    [SubTypeDiscriminator("TransitionCustomLineItemStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange))]
    [SubTypeDiscriminator("TransitionLineItemStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange))]
    [SubTypeDiscriminator("TransitionStateChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionStateChange))]
    [SubTypeDiscriminator("UnknownChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.UnknownChange))]
    [SubTypeDiscriminator("UnpublishChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.UnpublishChange))]
    [SubTypeDiscriminator("UpdateSyncInfoChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.UpdateSyncInfoChange))]
    [SubTypeDiscriminator("VerifyEmailChange", typeof(commercetools.Sdk.HistoryApi.Models.Changes.VerifyEmailChange))]
    public partial interface IChange
    {
        string Type { get; set; }

        string Change { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Changes.AddAddressChange AddAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange AddAssetChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddAttributeDefinitionChange AddAttributeDefinitionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddAttributeDefinitionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddAttributeDefinitionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddBillingAddressIdChange AddBillingAddressIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddBillingAddressIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddBillingAddressIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange AddChannelRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddCustomLineItemChange AddCustomLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddCustomLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddCustomLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddDeliveryChange AddDeliveryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddDeliveryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddDeliveryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddDiscountCodeChange AddDiscountCodeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddDiscountCodeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddDiscountCodeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddEnumValueChange AddEnumValueChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddEnumValueChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddEnumValueChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddExternalImageChange AddExternalImageChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddExternalImageChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddExternalImageChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddFieldDefinitionChange AddFieldDefinitionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddFieldDefinitionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddFieldDefinitionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange AddInterfaceInteractionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddItemShippingAddressesChange AddItemShippingAddressesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddItemShippingAddressesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddItemShippingAddressesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddLocalizedEnumValueChange AddLocalizedEnumValueChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddLocalizedEnumValueChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddLocalizedEnumValueChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddLocationChange AddLocationChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddLocationChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddLocationChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddOrderLineItemChange AddOrderLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddOrderLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddOrderLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange AddParcelToDeliveryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddPaymentChange AddPaymentChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddPaymentChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddPaymentChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange AddPlainEnumValueChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddPriceChange AddPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddProductChange AddProductChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddProductChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddProductChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddPropertyChange AddPropertyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddPropertyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddPropertyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddReturnInfoChange AddReturnInfoChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddReturnInfoChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddReturnInfoChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddShippingAddressIdChange AddShippingAddressIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddShippingAddressIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddShippingAddressIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddShoppingListLineItemChange AddShoppingListLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddShoppingListLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddShoppingListLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddStateRolesChange AddStateRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddStateRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddStateRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddTaxRateChange AddTaxRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddTaxRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddTaxRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddTextLineItemChange AddTextLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddTextLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddTextLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddToCategoryChange AddToCategoryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddToCategoryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddToCategoryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddTransactionChange AddTransactionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddTransactionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddTransactionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.AddVariantChange AddVariantChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.AddVariantChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.AddVariantChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAddressChange ChangeAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange ChangeAmountAuthorizedChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountPlannedChange ChangeAmountPlannedChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountPlannedChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAmountPlannedChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetNameChange ChangeAssetNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetOrderChange ChangeAssetOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeConstraintChange ChangeAttributeConstraintChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeConstraintChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeConstraintChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeOrderByNameChange ChangeAttributeOrderByNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeOrderByNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeOrderByNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartDiscountsChange ChangeCartDiscountsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartDiscountsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartDiscountsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartPredicateChange ChangeCartPredicateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartPredicateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeCartPredicateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange ChangeCustomLineItemQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeDescriptionChange ChangeDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeEmailChange ChangeEmailChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeEmailChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeEmailChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueLabelChange ChangeEnumValueLabelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueLabelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueLabelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueOrderChange ChangeEnumValueOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange ChangeFieldDefinitionOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange ChangeGroupsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeInitialChange ChangeInitialChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeInitialChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeInitialChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeInputHintChange ChangeInputHintChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeInputHintChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeInputHintChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsActiveChange ChangeIsActiveChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsActiveChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsActiveChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsSearchableChange ChangeIsSearchableChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsSearchableChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsSearchableChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeKeyChange ChangeKeyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeKeyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeKeyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLabelChange ChangeLabelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLabelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLabelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemQuantityChange ChangeLineItemQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange ChangeLocalizedDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange ChangeLocalizedEnumValueLabelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange ChangeLocalizedEnumValueOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedNameChange ChangeLocalizedNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeMasterVariantChange ChangeMasterVariantChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeMasterVariantChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeMasterVariantChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeNameChange ChangeNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderHintChange ChangeOrderHintChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderHintChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderHintChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderStateChange ChangeOrderStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeParentChange ChangeParentChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeParentChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeParentChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangePaymentStateChange ChangePaymentStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangePaymentStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangePaymentStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange ChangePlainEnumValueLabelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange ChangePlainEnumValueOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangePredicateChange ChangePredicateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangePredicateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangePredicateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceChange ChangePriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangePriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuantityChange ChangeQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteRequestStateChange ChangeQuoteRequestStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteRequestStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteRequestStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteStateChange ChangeQuoteStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuoteStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange ChangeRequiresDiscountCodeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange ChangeReviewRatingStatisticsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeShipmentStateChange ChangeShipmentStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeShipmentStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeShipmentStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange ChangeShoppingListLineItemQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange ChangeShoppingListLineItemsOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeSlugChange ChangeSlugChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeSlugChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeSlugChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeSortOrderChange ChangeSortOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeSortOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeSortOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange ChangeStackingModeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange ChangeStagedQuoteStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeStagedQuoteStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeStateTypeChange ChangeStateTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeStateTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeStateTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTargetChange ChangeTargetChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTargetChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTargetChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange ChangeTaxCalculationModeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxModeChange ChangeTaxModeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxModeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxModeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange ChangeTaxRoundingModeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemNameChange ChangeTextLineItemNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange ChangeTextLineItemQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange ChangeTextLineItemsOrderChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange ChangeTransactionInteractionIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange ChangeTransactionStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionTimestampChange ChangeTransactionTimestampChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionTimestampChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionTimestampChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.ChangeValueChange ChangeValueChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.ChangeValueChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.ChangeValueChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.MoveImageToPositionChange MoveImageToPositionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.MoveImageToPositionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.MoveImageToPositionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.PublishChange PublishChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.PublishChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.PublishChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveAddressChange RemoveAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssetChange RemoveAssetChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssetChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssetChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange RemoveAttributeDefinitionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveBillingAddressIdChange RemoveBillingAddressIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveBillingAddressIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveBillingAddressIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveChannelRolesChange RemoveChannelRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveChannelRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveChannelRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveCustomLineItemChange RemoveCustomLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveCustomLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveCustomLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveDeliveryItemsChange RemoveDeliveryItemsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveDeliveryItemsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveDeliveryItemsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveDiscountCodeChange RemoveDiscountCodeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveDiscountCodeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveDiscountCodeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange RemoveEnumValuesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveFieldDefinitionChange RemoveFieldDefinitionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveFieldDefinitionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveFieldDefinitionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveFromCategoryChange RemoveFromCategoryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveFromCategoryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveFromCategoryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveImageChange RemoveImageChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveImageChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveImageChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange RemoveItemShippingAddressesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange RemoveLocalizedEnumValuesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocationChange RemoveLocationChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocationChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocationChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveOrderLineItemChange RemoveOrderLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveOrderLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveOrderLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange RemoveParcelFromDeliveryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemovePaymentChange RemovePaymentChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemovePaymentChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemovePaymentChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemovePriceChange RemovePriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemovePriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemovePriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveProductChange RemoveProductChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveProductChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveProductChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemovePropertyChange RemovePropertyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemovePropertyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemovePropertyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveShippingAddressIdChange RemoveShippingAddressIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveShippingAddressIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveShippingAddressIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange RemoveShoppingListLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveStateRolesChange RemoveStateRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveStateRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveStateRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange RemoveTaxRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveTextLineItemChange RemoveTextLineItemChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveTextLineItemChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveTextLineItemChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.RemoveVariantChange RemoveVariantChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.RemoveVariantChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.RemoveVariantChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAddressChange SetAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAnonymousIdChange SetAnonymousIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAnonymousIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAnonymousIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetApplicationVersionChange SetApplicationVersionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetApplicationVersionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetApplicationVersionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomFieldChange SetAssetCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomTypeChange SetAssetCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetDescriptionChange SetAssetDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetKeyChange SetAssetKeyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetKeyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetKeyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetSourcesChange SetAssetSourcesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetSourcesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetSourcesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAssetTagsChange SetAssetTagsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAssetTagsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAssetTagsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAttributeChange SetAttributeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAttributeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAttributeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAuthenticationModeChange SetAuthenticationModeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAuthenticationModeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAuthenticationModeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetAuthorNameChange SetAuthorNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetAuthorNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetAuthorNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetBillingAddressChange SetBillingAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetBillingAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetBillingAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCartPredicateChange SetCartPredicateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCartPredicateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCartPredicateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCategoryOrderHintChange SetCategoryOrderHintChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCategoryOrderHintChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCategoryOrderHintChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetChannelRolesChange SetChannelRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetChannelRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetChannelRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCompanyNameChange SetCompanyNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCompanyNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCompanyNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange SetCountriesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCountryChange SetCountryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCountryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCountryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerChange SetCustomerChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerEmailChange SetCustomerEmailChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerEmailChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerEmailChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerGroupChange SetCustomerGroupChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerGroupChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerGroupChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerIdChange SetCustomerIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerNumberChange SetCustomerNumberChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerNumberChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerNumberChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomFieldChange SetCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange SetCustomLineItemCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange SetCustomLineItemCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange SetCustomLineItemMoneyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange SetCustomLineItemShippingDetailsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange SetCustomLineItemTaxAmountChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxCategoryChange SetCustomLineItemTaxCategoryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxCategoryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxCategoryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange SetCustomLineItemTaxedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxRateChange SetCustomLineItemTaxRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange SetCustomLineItemTotalPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomShippingMethodChange SetCustomShippingMethodChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomShippingMethodChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomShippingMethodChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetCustomTypeChange SetCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDateOfBirthChange SetDateOfBirthChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDateOfBirthChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDateOfBirthChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultBillingAddressChange SetDefaultBillingAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultBillingAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultBillingAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultShippingAddressChange SetDefaultShippingAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultShippingAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDefaultShippingAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange SetDeleteDaysAfterLastModificationChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange SetDeliveryAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange SetDeliveryItemsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDescriptionChange SetDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountedPriceChange SetDiscountedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange SetDistributionChannelsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetExpectedDeliveryChange SetExpectedDeliveryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetExpectedDeliveryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetExpectedDeliveryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetExternalIdChange SetExternalIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetExternalIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetExternalIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetFirstNameChange SetFirstNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetFirstNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetFirstNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange SetGeoLocationChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetGeoLocationChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetImageLabelChange SetImageLabelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetImageLabelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetImageLabelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetInputTipChange SetInputTipChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetInputTipChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetInputTipChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetInterfaceIdChange SetInterfaceIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetInterfaceIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetInterfaceIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetIsValidChange SetIsValidChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetIsValidChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetIsValidChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetKeyChange SetKeyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetKeyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetKeyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLanguagesChange SetLanguagesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLanguagesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLanguagesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLastNameChange SetLastNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLastNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLastNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDeactivatedAtChange SetLineItemDeactivatedAtChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDeactivatedAtChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDeactivatedAtChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange SetLineItemDiscountedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange SetLineItemDiscountedPricePerQuantityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange SetLineItemDistributionChannelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemPriceChange SetLineItemPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductKeyChange SetLineItemProductKeyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductKeyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductKeyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductSlugChange SetLineItemProductSlugChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductSlugChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemProductSlugChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange SetLineItemShippingDetailsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxAmountChange SetLineItemTaxAmountChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxAmountChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxAmountChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange SetLineItemTaxedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxRateChange SetLineItemTaxRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTotalPriceChange SetLineItemTotalPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTotalPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTotalPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLocaleChange SetLocaleChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLocaleChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLocaleChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetLocalizedDescriptionChange SetLocalizedDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetLocalizedDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetLocalizedDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsChange SetMaxApplicationsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsPerCustomerChange SetMaxApplicationsPerCustomerChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsPerCustomerChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMaxApplicationsPerCustomerChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMetaDescriptionChange SetMetaDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMetaDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMetaDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMetaKeywordsChange SetMetaKeywordsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMetaKeywordsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMetaKeywordsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMetaTitleChange SetMetaTitleChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMetaTitleChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMetaTitleChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoInterfaceChange SetMethodInfoInterfaceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoInterfaceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoInterfaceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoMethodChange SetMethodInfoMethodChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoMethodChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoMethodChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoNameChange SetMethodInfoNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetMiddleNameChange SetMiddleNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetMiddleNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetMiddleNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetNameChange SetNameChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetNameChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetNameChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange SetOrderLineItemCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomTypeChange SetOrderLineItemCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderNumberChange SetOrderNumberChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderNumberChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderNumberChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTaxedPriceChange SetOrderTaxedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTaxedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTaxedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalPriceChange SetOrderTotalPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalTaxChange SetOrderTotalTaxChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalTaxChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalTaxChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetParcelItemsChange SetParcelItemsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetParcelItemsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetParcelItemsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetParcelMeasurementsChange SetParcelMeasurementsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetParcelMeasurementsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetParcelMeasurementsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetParcelTrackingDataChange SetParcelTrackingDataChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetParcelTrackingDataChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetParcelTrackingDataChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetPricesChange SetPricesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetPricesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetPricesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetProductCountChange SetProductCountChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetProductCountChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetProductCountChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange SetProductPriceCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomTypeChange SetProductPriceCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange SetProductSelectionsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetProductVariantKeyChange SetProductVariantKeyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetProductVariantKeyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetProductVariantKeyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetPropertyChange SetPropertyChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetPropertyChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetPropertyChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetPurchaseOrderNumberChange SetPurchaseOrderNumberChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetPurchaseOrderNumberChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetPurchaseOrderNumberChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetRatingChange SetRatingChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetRatingChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetRatingChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange SetReservationsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetRestockableInDaysChange SetRestockableInDaysChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetRestockableInDaysChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetRestockableInDaysChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetReturnPaymentStateChange SetReturnPaymentStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetReturnPaymentStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetReturnPaymentStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetReturnShipmentStateChange SetReturnShipmentStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetReturnShipmentStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetReturnShipmentStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSalutationChange SetSalutationChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSalutationChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSalutationChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSearchKeywordsChange SetSearchKeywordsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSearchKeywordsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSearchKeywordsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSellerCommentChange SetSellerCommentChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSellerCommentChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSellerCommentChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingAddressChange SetShippingAddressChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingAddressChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingAddressChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoPriceChange SetShippingInfoPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange SetShippingInfoTaxedPriceChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange SetShippingMethodChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange SetShippingMethodTaxAmountChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange SetShippingMethodTaxRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateChange SetShippingRateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateInputChange SetShippingRateInputChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateInputChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateInputChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange SetShoppingListLineItemCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomTypeChange SetShoppingListLineItemCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSkuChange SetSkuChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSkuChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSkuChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSlugChange SetSlugChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSlugChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSlugChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange SetStateRolesChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceCodeChange SetStatusInterfaceCodeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceCodeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceCodeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceTextChange SetStatusInterfaceTextChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceTextChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetStatusInterfaceTextChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetStoreChange SetStoreChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetStoreChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetStoreChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetStoresChange SetStoresChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetStoresChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetStoresChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelChange SetSupplyChannelChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelsChange SetSupplyChannelsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTargetChange SetTargetChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTargetChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTargetChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTaxCategoryChange SetTaxCategoryChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTaxCategoryChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTaxCategoryChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTextChange SetTextChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTextChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTextChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange SetTextLineItemCustomFieldChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange SetTextLineItemCustomTypeChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemDescriptionChange SetTextLineItemDescriptionChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemDescriptionChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTextLineItemDescriptionChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTitleChange SetTitleChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTitleChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTitleChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetTransitionsChange SetTransitionsChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetTransitionsChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetTransitionsChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromAndUntilChange SetValidFromAndUntilChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromAndUntilChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromAndUntilChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromChange SetValidFromChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetValidFromChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetValidToChange SetValidToChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetValidToChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetValidToChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetValidUntilChange SetValidUntilChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetValidUntilChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetValidUntilChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetValueChange SetValueChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetValueChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetValueChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetVariantAvailabilityChange SetVariantAvailabilityChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetVariantAvailabilityChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetVariantAvailabilityChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.SetVatIdChange SetVatIdChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.SetVatIdChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.SetVatIdChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange TransitionCustomLineItemStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange TransitionLineItemStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.TransitionStateChange TransitionStateChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.TransitionStateChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.TransitionStateChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.UnknownChange UnknownChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.UnknownChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.UnknownChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.UnpublishChange UnpublishChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.UnpublishChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.UnpublishChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.UpdateSyncInfoChange UpdateSyncInfoChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.UpdateSyncInfoChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.UpdateSyncInfoChange();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Changes.VerifyEmailChange VerifyEmailChange(Action<commercetools.Sdk.HistoryApi.Models.Changes.VerifyEmailChange> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Changes.VerifyEmailChange();
            init?.Invoke(t);
            return t;
        }
    }
}
