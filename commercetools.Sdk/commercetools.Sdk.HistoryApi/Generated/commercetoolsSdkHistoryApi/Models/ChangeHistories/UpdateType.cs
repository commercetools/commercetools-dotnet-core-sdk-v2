using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public enum UpdateType
    {
        [Description("addAddress")]
        AddAddress,

        [Description("addAsset")]
        AddAsset,

        [Description("addAssociate")]
        AddAssociate,

        [Description("addAttributeDefinition")]
        AddAttributeDefinition,

        [Description("addBillingAddressId")]
        AddBillingAddressId,

        [Description("addCustomLineItem")]
        AddCustomLineItem,

        [Description("addDelivery")]
        AddDelivery,

        [Description("addDiscountCode")]
        AddDiscountCode,

        [Description("addEnumValue")]
        AddEnumValue,

        [Description("addExternalImage")]
        AddExternalImage,

        [Description("addFieldDefinition")]
        AddFieldDefinition,

        [Description("addInterfaceInteraction")]
        AddInterfaceInteraction,

        [Description("addItemShippingAddress")]
        AddItemShippingAddress,

        [Description("addLineItem")]
        AddLineItem,

        [Description("addLocalizedEnumValue")]
        AddLocalizedEnumValue,

        [Description("addLocation")]
        AddLocation,

        [Description("addParcelToDelivery")]
        AddParcelToDelivery,

        [Description("addPayment")]
        AddPayment,

        [Description("addPlainEnumValue")]
        AddPlainEnumValue,

        [Description("addPrice")]
        AddPrice,

        [Description("addProduct")]
        AddProduct,

        [Description("addProductSelection")]
        AddProductSelection,

        [Description("addProperty")]
        AddProperty,

        [Description("addReturnInfo")]
        AddReturnInfo,

        [Description("addRoles")]
        AddRoles,

        [Description("addShippingAddressId")]
        AddShippingAddressId,

        [Description("addTaxRate")]
        AddTaxRate,

        [Description("addTextLineItem")]
        AddTextLineItem,

        [Description("addToCategory")]
        AddToCategory,

        [Description("addTransaction")]
        AddTransaction,

        [Description("addVariant")]
        AddVariant,

        [Description("changeAddress")]
        ChangeAddress,

        [Description("changeAmountAuthorized")]
        ChangeAmountAuthorized,

        [Description("changeAmountPlanned")]
        ChangeAmountPlanned,

        [Description("changeAssetName")]
        ChangeAssetName,

        [Description("changeAssetOrder")]
        ChangeAssetOrder,

        [Description("changeAssociate")]
        ChangeAssociate,

        [Description("changeAssociateMode")]
        ChangeAssociateMode,

        [Description("changeAttributeConstraint")]
        ChangeAttributeConstraint,

        [Description("changeAttributeName")]
        ChangeAttributeName,

        [Description("changeAttributeOrderByName")]
        ChangeAttributeOrderByName,

        [Description("changeCartDiscounts")]
        ChangeCartDiscounts,

        [Description("changeCartPredicate")]
        ChangeCartPredicate,

        [Description("changeCustomLineItemQuantity")]
        ChangeCustomLineItemQuantity,

        [Description("changeDescription")]
        ChangeDescription,

        [Description("changeEmail")]
        ChangeEmail,

        [Description("changeEnumKey")]
        ChangeEnumKey,

        [Description("changeEnumValueLabel")]
        ChangeEnumValueLabel,

        [Description("changeEnumValueOrder")]
        ChangeEnumValueOrder,

        [Description("changeFieldDefinitionOrder")]
        ChangeFieldDefinitionOrder,

        [Description("changeGroups")]
        ChangeGroups,

        [Description("changeInitial")]
        ChangeInitial,

        [Description("changeInputHint")]
        ChangeInputHint,

        [Description("changeIsActive")]
        ChangeIsActive,

        [Description("changeIsSearchable")]
        ChangeIsSearchable,

        [Description("changeKey")]
        ChangeKey,

        [Description("changeLabel")]
        ChangeLabel,

        [Description("changeLineItemName")]
        ChangeLineItemName,

        [Description("changeLineItemQuantity")]
        ChangeLineItemQuantity,

        [Description("changeLineItemsOrder")]
        ChangeLineItemsOrder,

        [Description("changeLocalizedEnumValueLabel")]
        ChangeLocalizedEnumValueLabel,

        [Description("changeLocalizedEnumValueOrder")]
        ChangeLocalizedEnumValueOrder,

        [Description("changeMasterVariant")]
        ChangeMasterVariant,

        [Description("changeName")]
        ChangeName,

        [Description("changeOrderHint")]
        ChangeOrderHint,

        [Description("changeOrderState")]
        ChangeOrderState,

        [Description("changeParent")]
        ChangeParent,

        [Description("changeParentUnit")]
        ChangeParentUnit,

        [Description("changePaymentState")]
        ChangePaymentState,

        [Description("changePlainEnumValueLabel")]
        ChangePlainEnumValueLabel,

        [Description("changePredicate")]
        ChangePredicate,

        [Description("changePrice")]
        ChangePrice,

        [Description("changeProductSelectionActive")]
        ChangeProductSelectionActive,

        [Description("changeQuantity")]
        ChangeQuantity,

        [Description("changeQuoteRequestState")]
        ChangeQuoteRequestState,

        [Description("changeQuoteState")]
        ChangeQuoteState,

        [Description("changeRequiresDiscountCode")]
        ChangeRequiresDiscountCode,

        [Description("changeReviewRatingStatistics")]
        ChangeReviewRatingStatistics,

        [Description("changeShipmentState")]
        ChangeShipmentState,

        [Description("changeSlug")]
        ChangeSlug,

        [Description("changeSortOrder")]
        ChangeSortOrder,

        [Description("changeStackingMode")]
        ChangeStackingMode,

        [Description("changeStagedQuoteState")]
        ChangeStagedQuoteState,

        [Description("changeStatus")]
        ChangeStatus,

        [Description("changeTarget")]
        ChangeTarget,

        [Description("changeTaxCalculationMode")]
        ChangeTaxCalculationMode,

        [Description("changeTaxMode")]
        ChangeTaxMode,

        [Description("changeTaxRoundingMode")]
        ChangeTaxRoundingMode,

        [Description("changeTextLineItemName")]
        ChangeTextLineItemName,

        [Description("changeTextLineItemQuantity")]
        ChangeTextLineItemQuantity,

        [Description("changeTextLineItemsOrder")]
        ChangeTextLineItemsOrder,

        [Description("changeTransactionInteractionId")]
        ChangeTransactionInteractionId,

        [Description("changeTransactionState")]
        ChangeTransactionState,

        [Description("changeTransactionTimestamp")]
        ChangeTransactionTimestamp,

        [Description("changeType")]
        ChangeType,

        [Description("changeValue")]
        ChangeValue,

        [Description("moveImageToPosition")]
        MoveImageToPosition,

        [Description("publish")]
        Publish,

        [Description("removeAddress")]
        RemoveAddress,

        [Description("removeAsset")]
        RemoveAsset,

        [Description("removeAssociate")]
        RemoveAssociate,

        [Description("removeAttributeDefinition")]
        RemoveAttributeDefinition,

        [Description("removeBillingAddressId")]
        RemoveBillingAddressId,

        [Description("removeCustomLineItem")]
        RemoveCustomLineItem,

        [Description("removeDelivery")]
        RemoveDelivery,

        [Description("removeDiscountCode")]
        RemoveDiscountCode,

        [Description("removeEnumValues")]
        RemoveEnumValues,

        [Description("removeFieldDefinition")]
        RemoveFieldDefinition,

        [Description("removeFromCategory")]
        RemoveFromCategory,

        [Description("removeImage")]
        RemoveImage,

        [Description("removeItemShippingAddress")]
        RemoveItemShippingAddress,

        [Description("removeLineItem")]
        RemoveLineItem,

        [Description("removeLocation")]
        RemoveLocation,

        [Description("removeParcelFromDelivery")]
        RemoveParcelFromDelivery,

        [Description("removePayment")]
        RemovePayment,

        [Description("removePrice")]
        RemovePrice,

        [Description("removeProduct")]
        RemoveProduct,

        [Description("removeProductSelection")]
        RemoveProductSelection,

        [Description("removeProperty")]
        RemoveProperty,

        [Description("removeRoles")]
        RemoveRoles,

        [Description("removeShippingAddressId")]
        RemoveShippingAddressId,

        [Description("removeTaxRate")]
        RemoveTaxRate,

        [Description("removeTextLineItem")]
        RemoveTextLineItem,

        [Description("removeVariant")]
        RemoveVariant,

        [Description("requestQuoteRenegotiation")]
        RequestQuoteRenegotiation,

        [Description("setAddress")]
        SetAddress,

        [Description("setAddressCustomField")]
        SetAddressCustomField,

        [Description("setAddressCustomType")]
        SetAddressCustomType,

        [Description("setAnonymousId")]
        SetAnonymousId,

        [Description("setApplicationVersion")]
        SetApplicationVersion,

        [Description("setAssetCustomField")]
        SetAssetCustomField,

        [Description("setAssetCustomType")]
        SetAssetCustomType,

        [Description("setAssetDescription")]
        SetAssetDescription,

        [Description("setAssetSources")]
        SetAssetSources,

        [Description("setAssetTags")]
        SetAssetTags,

        [Description("setAssetKey")]
        SetAssetKey,

        [Description("setAttribute")]
        SetAttribute,

        [Description("setAuthenticationMode")]
        SetAuthenticationMode,

        [Description("setAuthorName")]
        SetAuthorName,

        [Description("setBillingAddress")]
        SetBillingAddress,

        [Description("setCartPredicate")]
        SetCartPredicate,

        [Description("setCategoryOrderHint")]
        SetCategoryOrderHint,

        [Description("setCompanyName")]
        SetCompanyName,

        [Description("setContactEmail")]
        SetContactEmail,

        [Description("setCountries")]
        SetCountries,

        [Description("setCountry")]
        SetCountry,

        [Description("setCustomField")]
        SetCustomField,

        [Description("setCustomLineItemCustomField")]
        SetCustomLineItemCustomField,

        [Description("setCustomLineItemCustomType")]
        SetCustomLineItemCustomType,

        [Description("setCustomLineItemMoney")]
        SetCustomLineItemMoney,

        [Description("setCustomLineItemShippingDetails")]
        SetCustomLineItemShippingDetails,

        [Description("setCustomLineItemTaxAmount")]
        SetCustomLineItemTaxAmount,

        [Description("setCustomLineItemTaxCategory")]
        SetCustomLineItemTaxCategory,

        [Description("setCustomLineItemTaxRate")]
        SetCustomLineItemTaxRate,

        [Description("setCustomLineItemTaxedPrice")]
        SetCustomLineItemTaxedPrice,

        [Description("setCustomLineItemTotalPrice")]
        SetCustomLineItemTotalPrice,

        [Description("setCustomShippingMethod")]
        SetCustomShippingMethod,

        [Description("setCustomType")]
        SetCustomType,

        [Description("setCustomer")]
        SetCustomer,

        [Description("setCustomerEmail")]
        SetCustomerEmail,

        [Description("setCustomerGroup")]
        SetCustomerGroup,

        [Description("setCustomerId")]
        SetCustomerId,

        [Description("setCustomerNumber")]
        SetCustomerNumber,

        [Description("setDateOfBirth")]
        SetDateOfBirth,

        [Description("setDefaultBillingAddress")]
        SetDefaultBillingAddress,

        [Description("setDefaultShippingAddress")]
        SetDefaultShippingAddress,

        [Description("setDeleteDaysAfterLastModification")]
        SetDeleteDaysAfterLastModification,

        [Description("setDeliveryAddress")]
        SetDeliveryAddress,

        [Description("setDeliveryItems")]
        SetDeliveryItems,

        [Description("setDescription")]
        SetDescription,

        [Description("setDiscountedPrice")]
        SetDiscountedPrice,

        [Description("setDistributionChannels")]
        SetDistributionChannels,

        [Description("setExpectedDelivery")]
        SetExpectedDelivery,

        [Description("setExternalId")]
        SetExternalId,

        [Description("setFirstName")]
        SetFirstName,

        [Description("setGeoLocation")]
        SetGeoLocation,

        [Description("setImageLabel")]
        SetImageLabel,

        [Description("setInputTip")]
        SetInputTip,

        [Description("setInterfaceId")]
        SetInterfaceId,

        [Description("setIsValid")]
        SetIsValid,

        [Description("setKey")]
        SetKey,

        [Description("setLanguages")]
        SetLanguages,

        [Description("setLastName")]
        SetLastName,

        [Description("setLineItemCustomField")]
        SetLineItemCustomField,

        [Description("setLineItemCustomType")]
        SetLineItemCustomType,

        [Description("setLineItemDeactivatedAt")]
        SetLineItemDeactivatedAt,

        [Description("setLineItemDiscountedPrice")]
        SetLineItemDiscountedPrice,

        [Description("setLineItemDiscountedPricePerQuantity")]
        SetLineItemDiscountedPricePerQuantity,

        [Description("setLineItemDistributionChannel")]
        SetLineItemDistributionChannel,

        [Description("setLineItemPrice")]
        SetLineItemPrice,

        [Description("setLineItemProductKey")]
        SetLineItemProductKey,

        [Description("setLineItemProductSlug")]
        SetLineItemProductSlug,

        [Description("setLineItemShippingDetails")]
        SetLineItemShippingDetails,

        [Description("setLineItemTaxAmount")]
        SetLineItemTaxAmount,

        [Description("setLineItemTaxRate")]
        SetLineItemTaxRate,

        [Description("setLineItemTaxedPrice")]
        SetLineItemTaxedPrice,

        [Description("setLineItemTotalPrice")]
        SetLineItemTotalPrice,

        [Description("setLocale")]
        SetLocale,

        [Description("setMaxApplications")]
        SetMaxApplications,

        [Description("setMaxApplicationsPerCustomer")]
        SetMaxApplicationsPerCustomer,

        [Description("setMetaDescription")]
        SetMetaDescription,

        [Description("setMetaKeywords")]
        SetMetaKeywords,

        [Description("setMetaTitle")]
        SetMetaTitle,

        [Description("setMethodInfoInterface")]
        SetMethodInfoInterface,

        [Description("setMethodInfoMethod")]
        SetMethodInfoMethod,

        [Description("setMethodInfoName")]
        SetMethodInfoName,

        [Description("setMiddleName")]
        SetMiddleName,

        [Description("setName")]
        SetName,

        [Description("setOrderNumber")]
        SetOrderNumber,

        [Description("setOrderTaxedPrice")]
        SetOrderTaxedPrice,

        [Description("setOrderTotalPrice")]
        SetOrderTotalPrice,

        [Description("setOrderTotalTax")]
        SetOrderTotalTax,

        [Description("setParcelItems")]
        SetParcelItems,

        [Description("setParcelMeasurements")]
        SetParcelMeasurements,

        [Description("setParcelTrackingData")]
        SetParcelTrackingData,

        [Description("setPassword")]
        SetPassword,

        [Description("setPrices")]
        SetPrices,

        [Description("setProductCount")]
        SetProductCount,

        [Description("setProductPriceCustomField")]
        SetProductPriceCustomField,

        [Description("setProductPriceCustomType")]
        SetProductPriceCustomType,

        [Description("setProductSelections")]
        SetProductSelections,

        [Description("setProductVariantKey")]
        SetProductVariantKey,

        [Description("setProperty")]
        SetProperty,

        [Description("setPurchaseOrderNumber")]
        SetPurchaseOrderNumber,

        [Description("setRating")]
        SetRating,

        [Description("setReservations")]
        SetReservations,

        [Description("setRestockableInDays")]
        SetRestockableInDays,

        [Description("setReturnPaymentState")]
        SetReturnPaymentState,

        [Description("setReturnShipmentState")]
        SetReturnShipmentState,

        [Description("setRoles")]
        SetRoles,

        [Description("setSalutation")]
        SetSalutation,

        [Description("setSearchKeywords")]
        SetSearchKeywords,

        [Description("setSellerComment")]
        SetSellerComment,

        [Description("setShippingAddress")]
        SetShippingAddress,

        [Description("setShippingInfoPrice")]
        SetShippingInfoPrice,

        [Description("setShippingInfoTaxedPrice")]
        SetShippingInfoTaxedPrice,

        [Description("setShippingMethod")]
        SetShippingMethod,

        [Description("setShippingMethodTaxAmount")]
        SetShippingMethodTaxAmount,

        [Description("setShippingMethodTaxRate")]
        SetShippingMethodTaxRate,

        [Description("setShippingRate")]
        SetShippingRate,

        [Description("setShippingRateInput")]
        SetShippingRateInput,

        [Description("setSku")]
        SetSku,

        [Description("setSlug")]
        SetSlug,

        [Description("setStatusInterfaceCode")]
        SetStatusInterfaceCode,

        [Description("setStatusInterfaceText")]
        SetStatusInterfaceText,

        [Description("setStore")]
        SetStore,

        [Description("setStoreMode")]
        SetStoreMode,

        [Description("setStores")]
        SetStores,

        [Description("setSupplyChannel")]
        SetSupplyChannel,

        [Description("setSupplyChannels")]
        SetSupplyChannels,

        [Description("setTarget")]
        SetTarget,

        [Description("setTaxCategory")]
        SetTaxCategory,

        [Description("setText")]
        SetText,

        [Description("setTextLineItemCustomField")]
        SetTextLineItemCustomField,

        [Description("setTextLineItemCustomType")]
        SetTextLineItemCustomType,

        [Description("setTextLineItemDescription")]
        SetTextLineItemDescription,

        [Description("setTitle")]
        SetTitle,

        [Description("setTransitions")]
        SetTransitions,

        [Description("setValidFrom")]
        SetValidFrom,

        [Description("setValidFromAndUntil")]
        SetValidFromAndUntil,

        [Description("setValidTo")]
        SetValidTo,

        [Description("setValidUntil")]
        SetValidUntil,

        [Description("setValue")]
        SetValue,

        [Description("setVariantAvailability")]
        SetVariantAvailability,

        [Description("setVariantSelection")]
        SetVariantSelection,

        [Description("setVatId")]
        SetVatId,

        [Description("transitionCustomLineItemState")]
        TransitionCustomLineItemState,

        [Description("transitionLineItemState")]
        TransitionLineItemState,

        [Description("transitionState")]
        TransitionState,

        [Description("unpublish")]
        Unpublish,

        [Description("updateItemShippingAddress")]
        UpdateItemShippingAddress,

        [Description("updateSyncInfo")]
        UpdateSyncInfo,

        [Description("verifyEmail")]
        VerifyEmail
    }

    public class UpdateTypeWrapper : IUpdateType
    {
        public string JsonName { get; internal set; }
        public UpdateType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IUpdateType), "FindEnum")]
    public interface IUpdateType : IJsonName, IEnumerable<char>
    {
        public static IUpdateType AddAddress = new UpdateTypeWrapper
        { Value = UpdateType.AddAddress, JsonName = "addAddress" };

        public static IUpdateType AddAsset = new UpdateTypeWrapper
        { Value = UpdateType.AddAsset, JsonName = "addAsset" };

        public static IUpdateType AddAssociate = new UpdateTypeWrapper
        { Value = UpdateType.AddAssociate, JsonName = "addAssociate" };

        public static IUpdateType AddAttributeDefinition = new UpdateTypeWrapper
        { Value = UpdateType.AddAttributeDefinition, JsonName = "addAttributeDefinition" };

        public static IUpdateType AddBillingAddressId = new UpdateTypeWrapper
        { Value = UpdateType.AddBillingAddressId, JsonName = "addBillingAddressId" };

        public static IUpdateType AddCustomLineItem = new UpdateTypeWrapper
        { Value = UpdateType.AddCustomLineItem, JsonName = "addCustomLineItem" };

        public static IUpdateType AddDelivery = new UpdateTypeWrapper
        { Value = UpdateType.AddDelivery, JsonName = "addDelivery" };

        public static IUpdateType AddDiscountCode = new UpdateTypeWrapper
        { Value = UpdateType.AddDiscountCode, JsonName = "addDiscountCode" };

        public static IUpdateType AddEnumValue = new UpdateTypeWrapper
        { Value = UpdateType.AddEnumValue, JsonName = "addEnumValue" };

        public static IUpdateType AddExternalImage = new UpdateTypeWrapper
        { Value = UpdateType.AddExternalImage, JsonName = "addExternalImage" };

        public static IUpdateType AddFieldDefinition = new UpdateTypeWrapper
        { Value = UpdateType.AddFieldDefinition, JsonName = "addFieldDefinition" };

        public static IUpdateType AddInterfaceInteraction = new UpdateTypeWrapper
        { Value = UpdateType.AddInterfaceInteraction, JsonName = "addInterfaceInteraction" };

        public static IUpdateType AddItemShippingAddress = new UpdateTypeWrapper
        { Value = UpdateType.AddItemShippingAddress, JsonName = "addItemShippingAddress" };

        public static IUpdateType AddLineItem = new UpdateTypeWrapper
        { Value = UpdateType.AddLineItem, JsonName = "addLineItem" };

        public static IUpdateType AddLocalizedEnumValue = new UpdateTypeWrapper
        { Value = UpdateType.AddLocalizedEnumValue, JsonName = "addLocalizedEnumValue" };

        public static IUpdateType AddLocation = new UpdateTypeWrapper
        { Value = UpdateType.AddLocation, JsonName = "addLocation" };

        public static IUpdateType AddParcelToDelivery = new UpdateTypeWrapper
        { Value = UpdateType.AddParcelToDelivery, JsonName = "addParcelToDelivery" };

        public static IUpdateType AddPayment = new UpdateTypeWrapper
        { Value = UpdateType.AddPayment, JsonName = "addPayment" };

        public static IUpdateType AddPlainEnumValue = new UpdateTypeWrapper
        { Value = UpdateType.AddPlainEnumValue, JsonName = "addPlainEnumValue" };

        public static IUpdateType AddPrice = new UpdateTypeWrapper
        { Value = UpdateType.AddPrice, JsonName = "addPrice" };

        public static IUpdateType AddProduct = new UpdateTypeWrapper
        { Value = UpdateType.AddProduct, JsonName = "addProduct" };

        public static IUpdateType AddProductSelection = new UpdateTypeWrapper
        { Value = UpdateType.AddProductSelection, JsonName = "addProductSelection" };

        public static IUpdateType AddProperty = new UpdateTypeWrapper
        { Value = UpdateType.AddProperty, JsonName = "addProperty" };

        public static IUpdateType AddReturnInfo = new UpdateTypeWrapper
        { Value = UpdateType.AddReturnInfo, JsonName = "addReturnInfo" };

        public static IUpdateType AddRoles = new UpdateTypeWrapper
        { Value = UpdateType.AddRoles, JsonName = "addRoles" };

        public static IUpdateType AddShippingAddressId = new UpdateTypeWrapper
        { Value = UpdateType.AddShippingAddressId, JsonName = "addShippingAddressId" };

        public static IUpdateType AddTaxRate = new UpdateTypeWrapper
        { Value = UpdateType.AddTaxRate, JsonName = "addTaxRate" };

        public static IUpdateType AddTextLineItem = new UpdateTypeWrapper
        { Value = UpdateType.AddTextLineItem, JsonName = "addTextLineItem" };

        public static IUpdateType AddToCategory = new UpdateTypeWrapper
        { Value = UpdateType.AddToCategory, JsonName = "addToCategory" };

        public static IUpdateType AddTransaction = new UpdateTypeWrapper
        { Value = UpdateType.AddTransaction, JsonName = "addTransaction" };

        public static IUpdateType AddVariant = new UpdateTypeWrapper
        { Value = UpdateType.AddVariant, JsonName = "addVariant" };

        public static IUpdateType ChangeAddress = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAddress, JsonName = "changeAddress" };

        public static IUpdateType ChangeAmountAuthorized = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAmountAuthorized, JsonName = "changeAmountAuthorized" };

        public static IUpdateType ChangeAmountPlanned = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAmountPlanned, JsonName = "changeAmountPlanned" };

        public static IUpdateType ChangeAssetName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAssetName, JsonName = "changeAssetName" };

        public static IUpdateType ChangeAssetOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAssetOrder, JsonName = "changeAssetOrder" };

        public static IUpdateType ChangeAssociate = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAssociate, JsonName = "changeAssociate" };

        public static IUpdateType ChangeAssociateMode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAssociateMode, JsonName = "changeAssociateMode" };

        public static IUpdateType ChangeAttributeConstraint = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAttributeConstraint, JsonName = "changeAttributeConstraint" };

        public static IUpdateType ChangeAttributeName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAttributeName, JsonName = "changeAttributeName" };

        public static IUpdateType ChangeAttributeOrderByName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeAttributeOrderByName, JsonName = "changeAttributeOrderByName" };

        public static IUpdateType ChangeCartDiscounts = new UpdateTypeWrapper
        { Value = UpdateType.ChangeCartDiscounts, JsonName = "changeCartDiscounts" };

        public static IUpdateType ChangeCartPredicate = new UpdateTypeWrapper
        { Value = UpdateType.ChangeCartPredicate, JsonName = "changeCartPredicate" };

        public static IUpdateType ChangeCustomLineItemQuantity = new UpdateTypeWrapper
        { Value = UpdateType.ChangeCustomLineItemQuantity, JsonName = "changeCustomLineItemQuantity" };

        public static IUpdateType ChangeDescription = new UpdateTypeWrapper
        { Value = UpdateType.ChangeDescription, JsonName = "changeDescription" };

        public static IUpdateType ChangeEmail = new UpdateTypeWrapper
        { Value = UpdateType.ChangeEmail, JsonName = "changeEmail" };

        public static IUpdateType ChangeEnumKey = new UpdateTypeWrapper
        { Value = UpdateType.ChangeEnumKey, JsonName = "changeEnumKey" };

        public static IUpdateType ChangeEnumValueLabel = new UpdateTypeWrapper
        { Value = UpdateType.ChangeEnumValueLabel, JsonName = "changeEnumValueLabel" };

        public static IUpdateType ChangeEnumValueOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeEnumValueOrder, JsonName = "changeEnumValueOrder" };

        public static IUpdateType ChangeFieldDefinitionOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeFieldDefinitionOrder, JsonName = "changeFieldDefinitionOrder" };

        public static IUpdateType ChangeGroups = new UpdateTypeWrapper
        { Value = UpdateType.ChangeGroups, JsonName = "changeGroups" };

        public static IUpdateType ChangeInitial = new UpdateTypeWrapper
        { Value = UpdateType.ChangeInitial, JsonName = "changeInitial" };

        public static IUpdateType ChangeInputHint = new UpdateTypeWrapper
        { Value = UpdateType.ChangeInputHint, JsonName = "changeInputHint" };

        public static IUpdateType ChangeIsActive = new UpdateTypeWrapper
        { Value = UpdateType.ChangeIsActive, JsonName = "changeIsActive" };

        public static IUpdateType ChangeIsSearchable = new UpdateTypeWrapper
        { Value = UpdateType.ChangeIsSearchable, JsonName = "changeIsSearchable" };

        public static IUpdateType ChangeKey = new UpdateTypeWrapper
        { Value = UpdateType.ChangeKey, JsonName = "changeKey" };

        public static IUpdateType ChangeLabel = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLabel, JsonName = "changeLabel" };

        public static IUpdateType ChangeLineItemName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLineItemName, JsonName = "changeLineItemName" };

        public static IUpdateType ChangeLineItemQuantity = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLineItemQuantity, JsonName = "changeLineItemQuantity" };

        public static IUpdateType ChangeLineItemsOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLineItemsOrder, JsonName = "changeLineItemsOrder" };

        public static IUpdateType ChangeLocalizedEnumValueLabel = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLocalizedEnumValueLabel, JsonName = "changeLocalizedEnumValueLabel" };

        public static IUpdateType ChangeLocalizedEnumValueOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeLocalizedEnumValueOrder, JsonName = "changeLocalizedEnumValueOrder" };

        public static IUpdateType ChangeMasterVariant = new UpdateTypeWrapper
        { Value = UpdateType.ChangeMasterVariant, JsonName = "changeMasterVariant" };

        public static IUpdateType ChangeName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeName, JsonName = "changeName" };

        public static IUpdateType ChangeOrderHint = new UpdateTypeWrapper
        { Value = UpdateType.ChangeOrderHint, JsonName = "changeOrderHint" };

        public static IUpdateType ChangeOrderState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeOrderState, JsonName = "changeOrderState" };

        public static IUpdateType ChangeParent = new UpdateTypeWrapper
        { Value = UpdateType.ChangeParent, JsonName = "changeParent" };

        public static IUpdateType ChangeParentUnit = new UpdateTypeWrapper
        { Value = UpdateType.ChangeParentUnit, JsonName = "changeParentUnit" };

        public static IUpdateType ChangePaymentState = new UpdateTypeWrapper
        { Value = UpdateType.ChangePaymentState, JsonName = "changePaymentState" };

        public static IUpdateType ChangePlainEnumValueLabel = new UpdateTypeWrapper
        { Value = UpdateType.ChangePlainEnumValueLabel, JsonName = "changePlainEnumValueLabel" };

        public static IUpdateType ChangePredicate = new UpdateTypeWrapper
        { Value = UpdateType.ChangePredicate, JsonName = "changePredicate" };

        public static IUpdateType ChangePrice = new UpdateTypeWrapper
        { Value = UpdateType.ChangePrice, JsonName = "changePrice" };

        public static IUpdateType ChangeProductSelectionActive = new UpdateTypeWrapper
        { Value = UpdateType.ChangeProductSelectionActive, JsonName = "changeProductSelectionActive" };

        public static IUpdateType ChangeQuantity = new UpdateTypeWrapper
        { Value = UpdateType.ChangeQuantity, JsonName = "changeQuantity" };

        public static IUpdateType ChangeQuoteRequestState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeQuoteRequestState, JsonName = "changeQuoteRequestState" };

        public static IUpdateType ChangeQuoteState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeQuoteState, JsonName = "changeQuoteState" };

        public static IUpdateType ChangeRequiresDiscountCode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeRequiresDiscountCode, JsonName = "changeRequiresDiscountCode" };

        public static IUpdateType ChangeReviewRatingStatistics = new UpdateTypeWrapper
        { Value = UpdateType.ChangeReviewRatingStatistics, JsonName = "changeReviewRatingStatistics" };

        public static IUpdateType ChangeShipmentState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeShipmentState, JsonName = "changeShipmentState" };

        public static IUpdateType ChangeSlug = new UpdateTypeWrapper
        { Value = UpdateType.ChangeSlug, JsonName = "changeSlug" };

        public static IUpdateType ChangeSortOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeSortOrder, JsonName = "changeSortOrder" };

        public static IUpdateType ChangeStackingMode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeStackingMode, JsonName = "changeStackingMode" };

        public static IUpdateType ChangeStagedQuoteState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeStagedQuoteState, JsonName = "changeStagedQuoteState" };

        public static IUpdateType ChangeStatus = new UpdateTypeWrapper
        { Value = UpdateType.ChangeStatus, JsonName = "changeStatus" };

        public static IUpdateType ChangeTarget = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTarget, JsonName = "changeTarget" };

        public static IUpdateType ChangeTaxCalculationMode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTaxCalculationMode, JsonName = "changeTaxCalculationMode" };

        public static IUpdateType ChangeTaxMode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTaxMode, JsonName = "changeTaxMode" };

        public static IUpdateType ChangeTaxRoundingMode = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTaxRoundingMode, JsonName = "changeTaxRoundingMode" };

        public static IUpdateType ChangeTextLineItemName = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTextLineItemName, JsonName = "changeTextLineItemName" };

        public static IUpdateType ChangeTextLineItemQuantity = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTextLineItemQuantity, JsonName = "changeTextLineItemQuantity" };

        public static IUpdateType ChangeTextLineItemsOrder = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTextLineItemsOrder, JsonName = "changeTextLineItemsOrder" };

        public static IUpdateType ChangeTransactionInteractionId = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTransactionInteractionId, JsonName = "changeTransactionInteractionId" };

        public static IUpdateType ChangeTransactionState = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTransactionState, JsonName = "changeTransactionState" };

        public static IUpdateType ChangeTransactionTimestamp = new UpdateTypeWrapper
        { Value = UpdateType.ChangeTransactionTimestamp, JsonName = "changeTransactionTimestamp" };

        public static IUpdateType ChangeType = new UpdateTypeWrapper
        { Value = UpdateType.ChangeType, JsonName = "changeType" };

        public static IUpdateType ChangeValue = new UpdateTypeWrapper
        { Value = UpdateType.ChangeValue, JsonName = "changeValue" };

        public static IUpdateType MoveImageToPosition = new UpdateTypeWrapper
        { Value = UpdateType.MoveImageToPosition, JsonName = "moveImageToPosition" };

        public static IUpdateType Publish = new UpdateTypeWrapper
        { Value = UpdateType.Publish, JsonName = "publish" };

        public static IUpdateType RemoveAddress = new UpdateTypeWrapper
        { Value = UpdateType.RemoveAddress, JsonName = "removeAddress" };

        public static IUpdateType RemoveAsset = new UpdateTypeWrapper
        { Value = UpdateType.RemoveAsset, JsonName = "removeAsset" };

        public static IUpdateType RemoveAssociate = new UpdateTypeWrapper
        { Value = UpdateType.RemoveAssociate, JsonName = "removeAssociate" };

        public static IUpdateType RemoveAttributeDefinition = new UpdateTypeWrapper
        { Value = UpdateType.RemoveAttributeDefinition, JsonName = "removeAttributeDefinition" };

        public static IUpdateType RemoveBillingAddressId = new UpdateTypeWrapper
        { Value = UpdateType.RemoveBillingAddressId, JsonName = "removeBillingAddressId" };

        public static IUpdateType RemoveCustomLineItem = new UpdateTypeWrapper
        { Value = UpdateType.RemoveCustomLineItem, JsonName = "removeCustomLineItem" };

        public static IUpdateType RemoveDelivery = new UpdateTypeWrapper
        { Value = UpdateType.RemoveDelivery, JsonName = "removeDelivery" };

        public static IUpdateType RemoveDiscountCode = new UpdateTypeWrapper
        { Value = UpdateType.RemoveDiscountCode, JsonName = "removeDiscountCode" };

        public static IUpdateType RemoveEnumValues = new UpdateTypeWrapper
        { Value = UpdateType.RemoveEnumValues, JsonName = "removeEnumValues" };

        public static IUpdateType RemoveFieldDefinition = new UpdateTypeWrapper
        { Value = UpdateType.RemoveFieldDefinition, JsonName = "removeFieldDefinition" };

        public static IUpdateType RemoveFromCategory = new UpdateTypeWrapper
        { Value = UpdateType.RemoveFromCategory, JsonName = "removeFromCategory" };

        public static IUpdateType RemoveImage = new UpdateTypeWrapper
        { Value = UpdateType.RemoveImage, JsonName = "removeImage" };

        public static IUpdateType RemoveItemShippingAddress = new UpdateTypeWrapper
        { Value = UpdateType.RemoveItemShippingAddress, JsonName = "removeItemShippingAddress" };

        public static IUpdateType RemoveLineItem = new UpdateTypeWrapper
        { Value = UpdateType.RemoveLineItem, JsonName = "removeLineItem" };

        public static IUpdateType RemoveLocation = new UpdateTypeWrapper
        { Value = UpdateType.RemoveLocation, JsonName = "removeLocation" };

        public static IUpdateType RemoveParcelFromDelivery = new UpdateTypeWrapper
        { Value = UpdateType.RemoveParcelFromDelivery, JsonName = "removeParcelFromDelivery" };

        public static IUpdateType RemovePayment = new UpdateTypeWrapper
        { Value = UpdateType.RemovePayment, JsonName = "removePayment" };

        public static IUpdateType RemovePrice = new UpdateTypeWrapper
        { Value = UpdateType.RemovePrice, JsonName = "removePrice" };

        public static IUpdateType RemoveProduct = new UpdateTypeWrapper
        { Value = UpdateType.RemoveProduct, JsonName = "removeProduct" };

        public static IUpdateType RemoveProductSelection = new UpdateTypeWrapper
        { Value = UpdateType.RemoveProductSelection, JsonName = "removeProductSelection" };

        public static IUpdateType RemoveProperty = new UpdateTypeWrapper
        { Value = UpdateType.RemoveProperty, JsonName = "removeProperty" };

        public static IUpdateType RemoveRoles = new UpdateTypeWrapper
        { Value = UpdateType.RemoveRoles, JsonName = "removeRoles" };

        public static IUpdateType RemoveShippingAddressId = new UpdateTypeWrapper
        { Value = UpdateType.RemoveShippingAddressId, JsonName = "removeShippingAddressId" };

        public static IUpdateType RemoveTaxRate = new UpdateTypeWrapper
        { Value = UpdateType.RemoveTaxRate, JsonName = "removeTaxRate" };

        public static IUpdateType RemoveTextLineItem = new UpdateTypeWrapper
        { Value = UpdateType.RemoveTextLineItem, JsonName = "removeTextLineItem" };

        public static IUpdateType RemoveVariant = new UpdateTypeWrapper
        { Value = UpdateType.RemoveVariant, JsonName = "removeVariant" };

        public static IUpdateType RequestQuoteRenegotiation = new UpdateTypeWrapper
        { Value = UpdateType.RequestQuoteRenegotiation, JsonName = "requestQuoteRenegotiation" };

        public static IUpdateType SetAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetAddress, JsonName = "setAddress" };

        public static IUpdateType SetAddressCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetAddressCustomField, JsonName = "setAddressCustomField" };

        public static IUpdateType SetAddressCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetAddressCustomType, JsonName = "setAddressCustomType" };

        public static IUpdateType SetAnonymousId = new UpdateTypeWrapper
        { Value = UpdateType.SetAnonymousId, JsonName = "setAnonymousId" };

        public static IUpdateType SetApplicationVersion = new UpdateTypeWrapper
        { Value = UpdateType.SetApplicationVersion, JsonName = "setApplicationVersion" };

        public static IUpdateType SetAssetCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetCustomField, JsonName = "setAssetCustomField" };

        public static IUpdateType SetAssetCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetCustomType, JsonName = "setAssetCustomType" };

        public static IUpdateType SetAssetDescription = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetDescription, JsonName = "setAssetDescription" };

        public static IUpdateType SetAssetSources = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetSources, JsonName = "setAssetSources" };

        public static IUpdateType SetAssetTags = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetTags, JsonName = "setAssetTags" };

        public static IUpdateType SetAssetKey = new UpdateTypeWrapper
        { Value = UpdateType.SetAssetKey, JsonName = "setAssetKey" };

        public static IUpdateType SetAttribute = new UpdateTypeWrapper
        { Value = UpdateType.SetAttribute, JsonName = "setAttribute" };

        public static IUpdateType SetAuthenticationMode = new UpdateTypeWrapper
        { Value = UpdateType.SetAuthenticationMode, JsonName = "setAuthenticationMode" };

        public static IUpdateType SetAuthorName = new UpdateTypeWrapper
        { Value = UpdateType.SetAuthorName, JsonName = "setAuthorName" };

        public static IUpdateType SetBillingAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetBillingAddress, JsonName = "setBillingAddress" };

        public static IUpdateType SetCartPredicate = new UpdateTypeWrapper
        { Value = UpdateType.SetCartPredicate, JsonName = "setCartPredicate" };

        public static IUpdateType SetCategoryOrderHint = new UpdateTypeWrapper
        { Value = UpdateType.SetCategoryOrderHint, JsonName = "setCategoryOrderHint" };

        public static IUpdateType SetCompanyName = new UpdateTypeWrapper
        { Value = UpdateType.SetCompanyName, JsonName = "setCompanyName" };

        public static IUpdateType SetContactEmail = new UpdateTypeWrapper
        { Value = UpdateType.SetContactEmail, JsonName = "setContactEmail" };

        public static IUpdateType SetCountries = new UpdateTypeWrapper
        { Value = UpdateType.SetCountries, JsonName = "setCountries" };

        public static IUpdateType SetCountry = new UpdateTypeWrapper
        { Value = UpdateType.SetCountry, JsonName = "setCountry" };

        public static IUpdateType SetCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomField, JsonName = "setCustomField" };

        public static IUpdateType SetCustomLineItemCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemCustomField, JsonName = "setCustomLineItemCustomField" };

        public static IUpdateType SetCustomLineItemCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemCustomType, JsonName = "setCustomLineItemCustomType" };

        public static IUpdateType SetCustomLineItemMoney = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemMoney, JsonName = "setCustomLineItemMoney" };

        public static IUpdateType SetCustomLineItemShippingDetails = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemShippingDetails, JsonName = "setCustomLineItemShippingDetails" };

        public static IUpdateType SetCustomLineItemTaxAmount = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemTaxAmount, JsonName = "setCustomLineItemTaxAmount" };

        public static IUpdateType SetCustomLineItemTaxCategory = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemTaxCategory, JsonName = "setCustomLineItemTaxCategory" };

        public static IUpdateType SetCustomLineItemTaxRate = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemTaxRate, JsonName = "setCustomLineItemTaxRate" };

        public static IUpdateType SetCustomLineItemTaxedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemTaxedPrice, JsonName = "setCustomLineItemTaxedPrice" };

        public static IUpdateType SetCustomLineItemTotalPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomLineItemTotalPrice, JsonName = "setCustomLineItemTotalPrice" };

        public static IUpdateType SetCustomShippingMethod = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomShippingMethod, JsonName = "setCustomShippingMethod" };

        public static IUpdateType SetCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomType, JsonName = "setCustomType" };

        public static IUpdateType SetCustomer = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomer, JsonName = "setCustomer" };

        public static IUpdateType SetCustomerEmail = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomerEmail, JsonName = "setCustomerEmail" };

        public static IUpdateType SetCustomerGroup = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomerGroup, JsonName = "setCustomerGroup" };

        public static IUpdateType SetCustomerId = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomerId, JsonName = "setCustomerId" };

        public static IUpdateType SetCustomerNumber = new UpdateTypeWrapper
        { Value = UpdateType.SetCustomerNumber, JsonName = "setCustomerNumber" };

        public static IUpdateType SetDateOfBirth = new UpdateTypeWrapper
        { Value = UpdateType.SetDateOfBirth, JsonName = "setDateOfBirth" };

        public static IUpdateType SetDefaultBillingAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetDefaultBillingAddress, JsonName = "setDefaultBillingAddress" };

        public static IUpdateType SetDefaultShippingAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetDefaultShippingAddress, JsonName = "setDefaultShippingAddress" };

        public static IUpdateType SetDeleteDaysAfterLastModification = new UpdateTypeWrapper
        { Value = UpdateType.SetDeleteDaysAfterLastModification, JsonName = "setDeleteDaysAfterLastModification" };

        public static IUpdateType SetDeliveryAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetDeliveryAddress, JsonName = "setDeliveryAddress" };

        public static IUpdateType SetDeliveryItems = new UpdateTypeWrapper
        { Value = UpdateType.SetDeliveryItems, JsonName = "setDeliveryItems" };

        public static IUpdateType SetDescription = new UpdateTypeWrapper
        { Value = UpdateType.SetDescription, JsonName = "setDescription" };

        public static IUpdateType SetDiscountedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetDiscountedPrice, JsonName = "setDiscountedPrice" };

        public static IUpdateType SetDistributionChannels = new UpdateTypeWrapper
        { Value = UpdateType.SetDistributionChannels, JsonName = "setDistributionChannels" };

        public static IUpdateType SetExpectedDelivery = new UpdateTypeWrapper
        { Value = UpdateType.SetExpectedDelivery, JsonName = "setExpectedDelivery" };

        public static IUpdateType SetExternalId = new UpdateTypeWrapper
        { Value = UpdateType.SetExternalId, JsonName = "setExternalId" };

        public static IUpdateType SetFirstName = new UpdateTypeWrapper
        { Value = UpdateType.SetFirstName, JsonName = "setFirstName" };

        public static IUpdateType SetGeoLocation = new UpdateTypeWrapper
        { Value = UpdateType.SetGeoLocation, JsonName = "setGeoLocation" };

        public static IUpdateType SetImageLabel = new UpdateTypeWrapper
        { Value = UpdateType.SetImageLabel, JsonName = "setImageLabel" };

        public static IUpdateType SetInputTip = new UpdateTypeWrapper
        { Value = UpdateType.SetInputTip, JsonName = "setInputTip" };

        public static IUpdateType SetInterfaceId = new UpdateTypeWrapper
        { Value = UpdateType.SetInterfaceId, JsonName = "setInterfaceId" };

        public static IUpdateType SetIsValid = new UpdateTypeWrapper
        { Value = UpdateType.SetIsValid, JsonName = "setIsValid" };

        public static IUpdateType SetKey = new UpdateTypeWrapper
        { Value = UpdateType.SetKey, JsonName = "setKey" };

        public static IUpdateType SetLanguages = new UpdateTypeWrapper
        { Value = UpdateType.SetLanguages, JsonName = "setLanguages" };

        public static IUpdateType SetLastName = new UpdateTypeWrapper
        { Value = UpdateType.SetLastName, JsonName = "setLastName" };

        public static IUpdateType SetLineItemCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemCustomField, JsonName = "setLineItemCustomField" };

        public static IUpdateType SetLineItemCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemCustomType, JsonName = "setLineItemCustomType" };

        public static IUpdateType SetLineItemDeactivatedAt = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemDeactivatedAt, JsonName = "setLineItemDeactivatedAt" };

        public static IUpdateType SetLineItemDiscountedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemDiscountedPrice, JsonName = "setLineItemDiscountedPrice" };

        public static IUpdateType SetLineItemDiscountedPricePerQuantity = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemDiscountedPricePerQuantity, JsonName = "setLineItemDiscountedPricePerQuantity" };

        public static IUpdateType SetLineItemDistributionChannel = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemDistributionChannel, JsonName = "setLineItemDistributionChannel" };

        public static IUpdateType SetLineItemPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemPrice, JsonName = "setLineItemPrice" };

        public static IUpdateType SetLineItemProductKey = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemProductKey, JsonName = "setLineItemProductKey" };

        public static IUpdateType SetLineItemProductSlug = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemProductSlug, JsonName = "setLineItemProductSlug" };

        public static IUpdateType SetLineItemShippingDetails = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemShippingDetails, JsonName = "setLineItemShippingDetails" };

        public static IUpdateType SetLineItemTaxAmount = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemTaxAmount, JsonName = "setLineItemTaxAmount" };

        public static IUpdateType SetLineItemTaxRate = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemTaxRate, JsonName = "setLineItemTaxRate" };

        public static IUpdateType SetLineItemTaxedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemTaxedPrice, JsonName = "setLineItemTaxedPrice" };

        public static IUpdateType SetLineItemTotalPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetLineItemTotalPrice, JsonName = "setLineItemTotalPrice" };

        public static IUpdateType SetLocale = new UpdateTypeWrapper
        { Value = UpdateType.SetLocale, JsonName = "setLocale" };

        public static IUpdateType SetMaxApplications = new UpdateTypeWrapper
        { Value = UpdateType.SetMaxApplications, JsonName = "setMaxApplications" };

        public static IUpdateType SetMaxApplicationsPerCustomer = new UpdateTypeWrapper
        { Value = UpdateType.SetMaxApplicationsPerCustomer, JsonName = "setMaxApplicationsPerCustomer" };

        public static IUpdateType SetMetaDescription = new UpdateTypeWrapper
        { Value = UpdateType.SetMetaDescription, JsonName = "setMetaDescription" };

        public static IUpdateType SetMetaKeywords = new UpdateTypeWrapper
        { Value = UpdateType.SetMetaKeywords, JsonName = "setMetaKeywords" };

        public static IUpdateType SetMetaTitle = new UpdateTypeWrapper
        { Value = UpdateType.SetMetaTitle, JsonName = "setMetaTitle" };

        public static IUpdateType SetMethodInfoInterface = new UpdateTypeWrapper
        { Value = UpdateType.SetMethodInfoInterface, JsonName = "setMethodInfoInterface" };

        public static IUpdateType SetMethodInfoMethod = new UpdateTypeWrapper
        { Value = UpdateType.SetMethodInfoMethod, JsonName = "setMethodInfoMethod" };

        public static IUpdateType SetMethodInfoName = new UpdateTypeWrapper
        { Value = UpdateType.SetMethodInfoName, JsonName = "setMethodInfoName" };

        public static IUpdateType SetMiddleName = new UpdateTypeWrapper
        { Value = UpdateType.SetMiddleName, JsonName = "setMiddleName" };

        public static IUpdateType SetName = new UpdateTypeWrapper
        { Value = UpdateType.SetName, JsonName = "setName" };

        public static IUpdateType SetOrderNumber = new UpdateTypeWrapper
        { Value = UpdateType.SetOrderNumber, JsonName = "setOrderNumber" };

        public static IUpdateType SetOrderTaxedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetOrderTaxedPrice, JsonName = "setOrderTaxedPrice" };

        public static IUpdateType SetOrderTotalPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetOrderTotalPrice, JsonName = "setOrderTotalPrice" };

        public static IUpdateType SetOrderTotalTax = new UpdateTypeWrapper
        { Value = UpdateType.SetOrderTotalTax, JsonName = "setOrderTotalTax" };

        public static IUpdateType SetParcelItems = new UpdateTypeWrapper
        { Value = UpdateType.SetParcelItems, JsonName = "setParcelItems" };

        public static IUpdateType SetParcelMeasurements = new UpdateTypeWrapper
        { Value = UpdateType.SetParcelMeasurements, JsonName = "setParcelMeasurements" };

        public static IUpdateType SetParcelTrackingData = new UpdateTypeWrapper
        { Value = UpdateType.SetParcelTrackingData, JsonName = "setParcelTrackingData" };

        public static IUpdateType SetPassword = new UpdateTypeWrapper
        { Value = UpdateType.SetPassword, JsonName = "setPassword" };

        public static IUpdateType SetPrices = new UpdateTypeWrapper
        { Value = UpdateType.SetPrices, JsonName = "setPrices" };

        public static IUpdateType SetProductCount = new UpdateTypeWrapper
        { Value = UpdateType.SetProductCount, JsonName = "setProductCount" };

        public static IUpdateType SetProductPriceCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetProductPriceCustomField, JsonName = "setProductPriceCustomField" };

        public static IUpdateType SetProductPriceCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetProductPriceCustomType, JsonName = "setProductPriceCustomType" };

        public static IUpdateType SetProductSelections = new UpdateTypeWrapper
        { Value = UpdateType.SetProductSelections, JsonName = "setProductSelections" };

        public static IUpdateType SetProductVariantKey = new UpdateTypeWrapper
        { Value = UpdateType.SetProductVariantKey, JsonName = "setProductVariantKey" };

        public static IUpdateType SetProperty = new UpdateTypeWrapper
        { Value = UpdateType.SetProperty, JsonName = "setProperty" };

        public static IUpdateType SetPurchaseOrderNumber = new UpdateTypeWrapper
        { Value = UpdateType.SetPurchaseOrderNumber, JsonName = "setPurchaseOrderNumber" };

        public static IUpdateType SetRating = new UpdateTypeWrapper
        { Value = UpdateType.SetRating, JsonName = "setRating" };

        public static IUpdateType SetReservations = new UpdateTypeWrapper
        { Value = UpdateType.SetReservations, JsonName = "setReservations" };

        public static IUpdateType SetRestockableInDays = new UpdateTypeWrapper
        { Value = UpdateType.SetRestockableInDays, JsonName = "setRestockableInDays" };

        public static IUpdateType SetReturnPaymentState = new UpdateTypeWrapper
        { Value = UpdateType.SetReturnPaymentState, JsonName = "setReturnPaymentState" };

        public static IUpdateType SetReturnShipmentState = new UpdateTypeWrapper
        { Value = UpdateType.SetReturnShipmentState, JsonName = "setReturnShipmentState" };

        public static IUpdateType SetRoles = new UpdateTypeWrapper
        { Value = UpdateType.SetRoles, JsonName = "setRoles" };

        public static IUpdateType SetSalutation = new UpdateTypeWrapper
        { Value = UpdateType.SetSalutation, JsonName = "setSalutation" };

        public static IUpdateType SetSearchKeywords = new UpdateTypeWrapper
        { Value = UpdateType.SetSearchKeywords, JsonName = "setSearchKeywords" };

        public static IUpdateType SetSellerComment = new UpdateTypeWrapper
        { Value = UpdateType.SetSellerComment, JsonName = "setSellerComment" };

        public static IUpdateType SetShippingAddress = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingAddress, JsonName = "setShippingAddress" };

        public static IUpdateType SetShippingInfoPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingInfoPrice, JsonName = "setShippingInfoPrice" };

        public static IUpdateType SetShippingInfoTaxedPrice = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingInfoTaxedPrice, JsonName = "setShippingInfoTaxedPrice" };

        public static IUpdateType SetShippingMethod = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingMethod, JsonName = "setShippingMethod" };

        public static IUpdateType SetShippingMethodTaxAmount = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingMethodTaxAmount, JsonName = "setShippingMethodTaxAmount" };

        public static IUpdateType SetShippingMethodTaxRate = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingMethodTaxRate, JsonName = "setShippingMethodTaxRate" };

        public static IUpdateType SetShippingRate = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingRate, JsonName = "setShippingRate" };

        public static IUpdateType SetShippingRateInput = new UpdateTypeWrapper
        { Value = UpdateType.SetShippingRateInput, JsonName = "setShippingRateInput" };

        public static IUpdateType SetSku = new UpdateTypeWrapper
        { Value = UpdateType.SetSku, JsonName = "setSku" };

        public static IUpdateType SetSlug = new UpdateTypeWrapper
        { Value = UpdateType.SetSlug, JsonName = "setSlug" };

        public static IUpdateType SetStatusInterfaceCode = new UpdateTypeWrapper
        { Value = UpdateType.SetStatusInterfaceCode, JsonName = "setStatusInterfaceCode" };

        public static IUpdateType SetStatusInterfaceText = new UpdateTypeWrapper
        { Value = UpdateType.SetStatusInterfaceText, JsonName = "setStatusInterfaceText" };

        public static IUpdateType SetStore = new UpdateTypeWrapper
        { Value = UpdateType.SetStore, JsonName = "setStore" };

        public static IUpdateType SetStoreMode = new UpdateTypeWrapper
        { Value = UpdateType.SetStoreMode, JsonName = "setStoreMode" };

        public static IUpdateType SetStores = new UpdateTypeWrapper
        { Value = UpdateType.SetStores, JsonName = "setStores" };

        public static IUpdateType SetSupplyChannel = new UpdateTypeWrapper
        { Value = UpdateType.SetSupplyChannel, JsonName = "setSupplyChannel" };

        public static IUpdateType SetSupplyChannels = new UpdateTypeWrapper
        { Value = UpdateType.SetSupplyChannels, JsonName = "setSupplyChannels" };

        public static IUpdateType SetTarget = new UpdateTypeWrapper
        { Value = UpdateType.SetTarget, JsonName = "setTarget" };

        public static IUpdateType SetTaxCategory = new UpdateTypeWrapper
        { Value = UpdateType.SetTaxCategory, JsonName = "setTaxCategory" };

        public static IUpdateType SetText = new UpdateTypeWrapper
        { Value = UpdateType.SetText, JsonName = "setText" };

        public static IUpdateType SetTextLineItemCustomField = new UpdateTypeWrapper
        { Value = UpdateType.SetTextLineItemCustomField, JsonName = "setTextLineItemCustomField" };

        public static IUpdateType SetTextLineItemCustomType = new UpdateTypeWrapper
        { Value = UpdateType.SetTextLineItemCustomType, JsonName = "setTextLineItemCustomType" };

        public static IUpdateType SetTextLineItemDescription = new UpdateTypeWrapper
        { Value = UpdateType.SetTextLineItemDescription, JsonName = "setTextLineItemDescription" };

        public static IUpdateType SetTitle = new UpdateTypeWrapper
        { Value = UpdateType.SetTitle, JsonName = "setTitle" };

        public static IUpdateType SetTransitions = new UpdateTypeWrapper
        { Value = UpdateType.SetTransitions, JsonName = "setTransitions" };

        public static IUpdateType SetValidFrom = new UpdateTypeWrapper
        { Value = UpdateType.SetValidFrom, JsonName = "setValidFrom" };

        public static IUpdateType SetValidFromAndUntil = new UpdateTypeWrapper
        { Value = UpdateType.SetValidFromAndUntil, JsonName = "setValidFromAndUntil" };

        public static IUpdateType SetValidTo = new UpdateTypeWrapper
        { Value = UpdateType.SetValidTo, JsonName = "setValidTo" };

        public static IUpdateType SetValidUntil = new UpdateTypeWrapper
        { Value = UpdateType.SetValidUntil, JsonName = "setValidUntil" };

        public static IUpdateType SetValue = new UpdateTypeWrapper
        { Value = UpdateType.SetValue, JsonName = "setValue" };

        public static IUpdateType SetVariantAvailability = new UpdateTypeWrapper
        { Value = UpdateType.SetVariantAvailability, JsonName = "setVariantAvailability" };

        public static IUpdateType SetVariantSelection = new UpdateTypeWrapper
        { Value = UpdateType.SetVariantSelection, JsonName = "setVariantSelection" };

        public static IUpdateType SetVatId = new UpdateTypeWrapper
        { Value = UpdateType.SetVatId, JsonName = "setVatId" };

        public static IUpdateType TransitionCustomLineItemState = new UpdateTypeWrapper
        { Value = UpdateType.TransitionCustomLineItemState, JsonName = "transitionCustomLineItemState" };

        public static IUpdateType TransitionLineItemState = new UpdateTypeWrapper
        { Value = UpdateType.TransitionLineItemState, JsonName = "transitionLineItemState" };

        public static IUpdateType TransitionState = new UpdateTypeWrapper
        { Value = UpdateType.TransitionState, JsonName = "transitionState" };

        public static IUpdateType Unpublish = new UpdateTypeWrapper
        { Value = UpdateType.Unpublish, JsonName = "unpublish" };

        public static IUpdateType UpdateItemShippingAddress = new UpdateTypeWrapper
        { Value = UpdateType.UpdateItemShippingAddress, JsonName = "updateItemShippingAddress" };

        public static IUpdateType UpdateSyncInfo = new UpdateTypeWrapper
        { Value = UpdateType.UpdateSyncInfo, JsonName = "updateSyncInfo" };

        public static IUpdateType VerifyEmail = new UpdateTypeWrapper
        { Value = UpdateType.VerifyEmail, JsonName = "verifyEmail" };

        UpdateType? Value { get; }

        static IUpdateType[] Values()
        {
            return new[]
            {
                 AddAddress ,
                 AddAsset ,
                 AddAssociate ,
                 AddAttributeDefinition ,
                 AddBillingAddressId ,
                 AddCustomLineItem ,
                 AddDelivery ,
                 AddDiscountCode ,
                 AddEnumValue ,
                 AddExternalImage ,
                 AddFieldDefinition ,
                 AddInterfaceInteraction ,
                 AddItemShippingAddress ,
                 AddLineItem ,
                 AddLocalizedEnumValue ,
                 AddLocation ,
                 AddParcelToDelivery ,
                 AddPayment ,
                 AddPlainEnumValue ,
                 AddPrice ,
                 AddProduct ,
                 AddProductSelection ,
                 AddProperty ,
                 AddReturnInfo ,
                 AddRoles ,
                 AddShippingAddressId ,
                 AddTaxRate ,
                 AddTextLineItem ,
                 AddToCategory ,
                 AddTransaction ,
                 AddVariant ,
                 ChangeAddress ,
                 ChangeAmountAuthorized ,
                 ChangeAmountPlanned ,
                 ChangeAssetName ,
                 ChangeAssetOrder ,
                 ChangeAssociate ,
                 ChangeAssociateMode ,
                 ChangeAttributeConstraint ,
                 ChangeAttributeName ,
                 ChangeAttributeOrderByName ,
                 ChangeCartDiscounts ,
                 ChangeCartPredicate ,
                 ChangeCustomLineItemQuantity ,
                 ChangeDescription ,
                 ChangeEmail ,
                 ChangeEnumKey ,
                 ChangeEnumValueLabel ,
                 ChangeEnumValueOrder ,
                 ChangeFieldDefinitionOrder ,
                 ChangeGroups ,
                 ChangeInitial ,
                 ChangeInputHint ,
                 ChangeIsActive ,
                 ChangeIsSearchable ,
                 ChangeKey ,
                 ChangeLabel ,
                 ChangeLineItemName ,
                 ChangeLineItemQuantity ,
                 ChangeLineItemsOrder ,
                 ChangeLocalizedEnumValueLabel ,
                 ChangeLocalizedEnumValueOrder ,
                 ChangeMasterVariant ,
                 ChangeName ,
                 ChangeOrderHint ,
                 ChangeOrderState ,
                 ChangeParent ,
                 ChangeParentUnit ,
                 ChangePaymentState ,
                 ChangePlainEnumValueLabel ,
                 ChangePredicate ,
                 ChangePrice ,
                 ChangeProductSelectionActive ,
                 ChangeQuantity ,
                 ChangeQuoteRequestState ,
                 ChangeQuoteState ,
                 ChangeRequiresDiscountCode ,
                 ChangeReviewRatingStatistics ,
                 ChangeShipmentState ,
                 ChangeSlug ,
                 ChangeSortOrder ,
                 ChangeStackingMode ,
                 ChangeStagedQuoteState ,
                 ChangeStatus ,
                 ChangeTarget ,
                 ChangeTaxCalculationMode ,
                 ChangeTaxMode ,
                 ChangeTaxRoundingMode ,
                 ChangeTextLineItemName ,
                 ChangeTextLineItemQuantity ,
                 ChangeTextLineItemsOrder ,
                 ChangeTransactionInteractionId ,
                 ChangeTransactionState ,
                 ChangeTransactionTimestamp ,
                 ChangeType ,
                 ChangeValue ,
                 MoveImageToPosition ,
                 Publish ,
                 RemoveAddress ,
                 RemoveAsset ,
                 RemoveAssociate ,
                 RemoveAttributeDefinition ,
                 RemoveBillingAddressId ,
                 RemoveCustomLineItem ,
                 RemoveDelivery ,
                 RemoveDiscountCode ,
                 RemoveEnumValues ,
                 RemoveFieldDefinition ,
                 RemoveFromCategory ,
                 RemoveImage ,
                 RemoveItemShippingAddress ,
                 RemoveLineItem ,
                 RemoveLocation ,
                 RemoveParcelFromDelivery ,
                 RemovePayment ,
                 RemovePrice ,
                 RemoveProduct ,
                 RemoveProductSelection ,
                 RemoveProperty ,
                 RemoveRoles ,
                 RemoveShippingAddressId ,
                 RemoveTaxRate ,
                 RemoveTextLineItem ,
                 RemoveVariant ,
                 RequestQuoteRenegotiation ,
                 SetAddress ,
                 SetAddressCustomField ,
                 SetAddressCustomType ,
                 SetAnonymousId ,
                 SetApplicationVersion ,
                 SetAssetCustomField ,
                 SetAssetCustomType ,
                 SetAssetDescription ,
                 SetAssetSources ,
                 SetAssetTags ,
                 SetAssetKey ,
                 SetAttribute ,
                 SetAuthenticationMode ,
                 SetAuthorName ,
                 SetBillingAddress ,
                 SetCartPredicate ,
                 SetCategoryOrderHint ,
                 SetCompanyName ,
                 SetContactEmail ,
                 SetCountries ,
                 SetCountry ,
                 SetCustomField ,
                 SetCustomLineItemCustomField ,
                 SetCustomLineItemCustomType ,
                 SetCustomLineItemMoney ,
                 SetCustomLineItemShippingDetails ,
                 SetCustomLineItemTaxAmount ,
                 SetCustomLineItemTaxCategory ,
                 SetCustomLineItemTaxRate ,
                 SetCustomLineItemTaxedPrice ,
                 SetCustomLineItemTotalPrice ,
                 SetCustomShippingMethod ,
                 SetCustomType ,
                 SetCustomer ,
                 SetCustomerEmail ,
                 SetCustomerGroup ,
                 SetCustomerId ,
                 SetCustomerNumber ,
                 SetDateOfBirth ,
                 SetDefaultBillingAddress ,
                 SetDefaultShippingAddress ,
                 SetDeleteDaysAfterLastModification ,
                 SetDeliveryAddress ,
                 SetDeliveryItems ,
                 SetDescription ,
                 SetDiscountedPrice ,
                 SetDistributionChannels ,
                 SetExpectedDelivery ,
                 SetExternalId ,
                 SetFirstName ,
                 SetGeoLocation ,
                 SetImageLabel ,
                 SetInputTip ,
                 SetInterfaceId ,
                 SetIsValid ,
                 SetKey ,
                 SetLanguages ,
                 SetLastName ,
                 SetLineItemCustomField ,
                 SetLineItemCustomType ,
                 SetLineItemDeactivatedAt ,
                 SetLineItemDiscountedPrice ,
                 SetLineItemDiscountedPricePerQuantity ,
                 SetLineItemDistributionChannel ,
                 SetLineItemPrice ,
                 SetLineItemProductKey ,
                 SetLineItemProductSlug ,
                 SetLineItemShippingDetails ,
                 SetLineItemTaxAmount ,
                 SetLineItemTaxRate ,
                 SetLineItemTaxedPrice ,
                 SetLineItemTotalPrice ,
                 SetLocale ,
                 SetMaxApplications ,
                 SetMaxApplicationsPerCustomer ,
                 SetMetaDescription ,
                 SetMetaKeywords ,
                 SetMetaTitle ,
                 SetMethodInfoInterface ,
                 SetMethodInfoMethod ,
                 SetMethodInfoName ,
                 SetMiddleName ,
                 SetName ,
                 SetOrderNumber ,
                 SetOrderTaxedPrice ,
                 SetOrderTotalPrice ,
                 SetOrderTotalTax ,
                 SetParcelItems ,
                 SetParcelMeasurements ,
                 SetParcelTrackingData ,
                 SetPassword ,
                 SetPrices ,
                 SetProductCount ,
                 SetProductPriceCustomField ,
                 SetProductPriceCustomType ,
                 SetProductSelections ,
                 SetProductVariantKey ,
                 SetProperty ,
                 SetPurchaseOrderNumber ,
                 SetRating ,
                 SetReservations ,
                 SetRestockableInDays ,
                 SetReturnPaymentState ,
                 SetReturnShipmentState ,
                 SetRoles ,
                 SetSalutation ,
                 SetSearchKeywords ,
                 SetSellerComment ,
                 SetShippingAddress ,
                 SetShippingInfoPrice ,
                 SetShippingInfoTaxedPrice ,
                 SetShippingMethod ,
                 SetShippingMethodTaxAmount ,
                 SetShippingMethodTaxRate ,
                 SetShippingRate ,
                 SetShippingRateInput ,
                 SetSku ,
                 SetSlug ,
                 SetStatusInterfaceCode ,
                 SetStatusInterfaceText ,
                 SetStore ,
                 SetStoreMode ,
                 SetStores ,
                 SetSupplyChannel ,
                 SetSupplyChannels ,
                 SetTarget ,
                 SetTaxCategory ,
                 SetText ,
                 SetTextLineItemCustomField ,
                 SetTextLineItemCustomType ,
                 SetTextLineItemDescription ,
                 SetTitle ,
                 SetTransitions ,
                 SetValidFrom ,
                 SetValidFromAndUntil ,
                 SetValidTo ,
                 SetValidUntil ,
                 SetValue ,
                 SetVariantAvailability ,
                 SetVariantSelection ,
                 SetVatId ,
                 TransitionCustomLineItemState ,
                 TransitionLineItemState ,
                 TransitionState ,
                 Unpublish ,
                 UpdateItemShippingAddress ,
                 UpdateSyncInfo ,
                 VerifyEmail
             };
        }
        static IUpdateType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new UpdateTypeWrapper() { JsonName = value };
        }
    }
}
