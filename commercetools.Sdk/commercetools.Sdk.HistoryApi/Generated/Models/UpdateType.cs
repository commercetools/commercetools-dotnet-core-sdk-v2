using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models
{
   public enum UpdateType
   {
       [Description("addAddress")]
       AddAddress,
       
       [Description("addAsset")]
       AddAsset,
       
       [Description("addAttributeDefinition")]
       AddAttributeDefinition,
       
       [Description("addBillingAddressId")]
       AddBillingAddressId,
       
       [Description("addDelivery")]
       AddDelivery,
       
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
       
       [Description("changeAmountPlanned")]
       ChangeAmountPlanned,
       
       [Description("changeAssetName")]
       ChangeAssetName,
       
       [Description("changeAssetOrder")]
       ChangeAssetOrder,
       
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
       
       [Description("changePaymentState")]
       ChangePaymentState,
       
       [Description("changePlainEnumValueLabel")]
       ChangePlainEnumValueLabel,
       
       [Description("changePredicate")]
       ChangePredicate,
       
       [Description("changePrice")]
       ChangePrice,
       
       [Description("changeQuantity")]
       ChangeQuantity,
       
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
       
       [Description("changeTarget")]
       ChangeTarget,
       
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
       
       [Description("publish")]
       Publish,
       
       [Description("removeAddress")]
       RemoveAddress,
       
       [Description("removeAsset")]
       RemoveAsset,
       
       [Description("removeAttributeDefinition")]
       RemoveAttributeDefinition,
       
       [Description("removeBillingAddressId")]
       RemoveBillingAddressId,
       
       [Description("removeDelivery")]
       RemoveDelivery,
       
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
       
       [Description("setAddress")]
       SetAddress,
       
       [Description("setAnonymousId")]
       SetAnonymousId,
       
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
       
       [Description("setAsssetKey")]
       SetAsssetKey,
       
       [Description("setAttribute")]
       SetAttribute,
       
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
       
       [Description("setCustomField")]
       SetCustomField,
       
       [Description("setCustomLineItemCustomField")]
       SetCustomLineItemCustomField,
       
       [Description("setCustomLineItemCustomType")]
       SetCustomLineItemCustomType,
       
       [Description("setCustomLineItemShippingDetails")]
       SetCustomLineItemShippingDetails,
       
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
       
       [Description("setLineItemShippingDetails")]
       SetLineItemShippingDetails,
       
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
       
       [Description("setParcelItems")]
       SetParcelItems,
       
       [Description("setParcelMeasurements")]
       SetParcelMeasurements,
       
       [Description("setParcelTrackingData")]
       SetParcelTrackingData,
       
       [Description("setPassword")]
       SetPassword,
       
       [Description("setProductPriceCustomField")]
       SetProductPriceCustomField,
       
       [Description("setProductPriceCustomType")]
       SetProductPriceCustomType,
       
       [Description("setProductVariantKey")]
       SetProductVariantKey,
       
       [Description("setRating")]
       SetRating,
       
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
       
       [Description("setShippingAddress")]
       SetShippingAddress,
       
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
       
       [Description("setStores")]
       SetStores,
       
       [Description("setSupplyChannel")]
       SetSupplyChannel,
       
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
       
       [Description("setValidUntil")]
       SetValidUntil,
       
       [Description("setVariantAvailability")]
       SetVariantAvailability,
       
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
   }
   [EnumInterfaceCreator(typeof(IUpdateType), "FindEnum")]
   public interface IUpdateType : IJsonName
   {
        public static IUpdateType AddAddress = new UpdateTypeWrapper
         {Value = UpdateType.AddAddress, JsonName = "addAddress"}; 
       
        public static IUpdateType AddAsset = new UpdateTypeWrapper
         {Value = UpdateType.AddAsset, JsonName = "addAsset"}; 
       
        public static IUpdateType AddAttributeDefinition = new UpdateTypeWrapper
         {Value = UpdateType.AddAttributeDefinition, JsonName = "addAttributeDefinition"}; 
       
        public static IUpdateType AddBillingAddressId = new UpdateTypeWrapper
         {Value = UpdateType.AddBillingAddressId, JsonName = "addBillingAddressId"}; 
       
        public static IUpdateType AddDelivery = new UpdateTypeWrapper
         {Value = UpdateType.AddDelivery, JsonName = "addDelivery"}; 
       
        public static IUpdateType AddEnumValue = new UpdateTypeWrapper
         {Value = UpdateType.AddEnumValue, JsonName = "addEnumValue"}; 
       
        public static IUpdateType AddExternalImage = new UpdateTypeWrapper
         {Value = UpdateType.AddExternalImage, JsonName = "addExternalImage"}; 
       
        public static IUpdateType AddFieldDefinition = new UpdateTypeWrapper
         {Value = UpdateType.AddFieldDefinition, JsonName = "addFieldDefinition"}; 
       
        public static IUpdateType AddInterfaceInteraction = new UpdateTypeWrapper
         {Value = UpdateType.AddInterfaceInteraction, JsonName = "addInterfaceInteraction"}; 
       
        public static IUpdateType AddItemShippingAddress = new UpdateTypeWrapper
         {Value = UpdateType.AddItemShippingAddress, JsonName = "addItemShippingAddress"}; 
       
        public static IUpdateType AddLineItem = new UpdateTypeWrapper
         {Value = UpdateType.AddLineItem, JsonName = "addLineItem"}; 
       
        public static IUpdateType AddLocalizedEnumValue = new UpdateTypeWrapper
         {Value = UpdateType.AddLocalizedEnumValue, JsonName = "addLocalizedEnumValue"}; 
       
        public static IUpdateType AddLocation = new UpdateTypeWrapper
         {Value = UpdateType.AddLocation, JsonName = "addLocation"}; 
       
        public static IUpdateType AddParcelToDelivery = new UpdateTypeWrapper
         {Value = UpdateType.AddParcelToDelivery, JsonName = "addParcelToDelivery"}; 
       
        public static IUpdateType AddPayment = new UpdateTypeWrapper
         {Value = UpdateType.AddPayment, JsonName = "addPayment"}; 
       
        public static IUpdateType AddPlainEnumValue = new UpdateTypeWrapper
         {Value = UpdateType.AddPlainEnumValue, JsonName = "addPlainEnumValue"}; 
       
        public static IUpdateType AddPrice = new UpdateTypeWrapper
         {Value = UpdateType.AddPrice, JsonName = "addPrice"}; 
       
        public static IUpdateType AddReturnInfo = new UpdateTypeWrapper
         {Value = UpdateType.AddReturnInfo, JsonName = "addReturnInfo"}; 
       
        public static IUpdateType AddRoles = new UpdateTypeWrapper
         {Value = UpdateType.AddRoles, JsonName = "addRoles"}; 
       
        public static IUpdateType AddShippingAddressId = new UpdateTypeWrapper
         {Value = UpdateType.AddShippingAddressId, JsonName = "addShippingAddressId"}; 
       
        public static IUpdateType AddTaxRate = new UpdateTypeWrapper
         {Value = UpdateType.AddTaxRate, JsonName = "addTaxRate"}; 
       
        public static IUpdateType AddTextLineItem = new UpdateTypeWrapper
         {Value = UpdateType.AddTextLineItem, JsonName = "addTextLineItem"}; 
       
        public static IUpdateType AddToCategory = new UpdateTypeWrapper
         {Value = UpdateType.AddToCategory, JsonName = "addToCategory"}; 
       
        public static IUpdateType AddTransaction = new UpdateTypeWrapper
         {Value = UpdateType.AddTransaction, JsonName = "addTransaction"}; 
       
        public static IUpdateType AddVariant = new UpdateTypeWrapper
         {Value = UpdateType.AddVariant, JsonName = "addVariant"}; 
       
        public static IUpdateType ChangeAddress = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAddress, JsonName = "changeAddress"}; 
       
        public static IUpdateType ChangeAmountPlanned = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAmountPlanned, JsonName = "changeAmountPlanned"}; 
       
        public static IUpdateType ChangeAssetName = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAssetName, JsonName = "changeAssetName"}; 
       
        public static IUpdateType ChangeAssetOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAssetOrder, JsonName = "changeAssetOrder"}; 
       
        public static IUpdateType ChangeAttributeConstraint = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAttributeConstraint, JsonName = "changeAttributeConstraint"}; 
       
        public static IUpdateType ChangeAttributeName = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAttributeName, JsonName = "changeAttributeName"}; 
       
        public static IUpdateType ChangeAttributeOrderByName = new UpdateTypeWrapper
         {Value = UpdateType.ChangeAttributeOrderByName, JsonName = "changeAttributeOrderByName"}; 
       
        public static IUpdateType ChangeCartDiscounts = new UpdateTypeWrapper
         {Value = UpdateType.ChangeCartDiscounts, JsonName = "changeCartDiscounts"}; 
       
        public static IUpdateType ChangeCartPredicate = new UpdateTypeWrapper
         {Value = UpdateType.ChangeCartPredicate, JsonName = "changeCartPredicate"}; 
       
        public static IUpdateType ChangeDescription = new UpdateTypeWrapper
         {Value = UpdateType.ChangeDescription, JsonName = "changeDescription"}; 
       
        public static IUpdateType ChangeEmail = new UpdateTypeWrapper
         {Value = UpdateType.ChangeEmail, JsonName = "changeEmail"}; 
       
        public static IUpdateType ChangeEnumKey = new UpdateTypeWrapper
         {Value = UpdateType.ChangeEnumKey, JsonName = "changeEnumKey"}; 
       
        public static IUpdateType ChangeEnumValueLabel = new UpdateTypeWrapper
         {Value = UpdateType.ChangeEnumValueLabel, JsonName = "changeEnumValueLabel"}; 
       
        public static IUpdateType ChangeEnumValueOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeEnumValueOrder, JsonName = "changeEnumValueOrder"}; 
       
        public static IUpdateType ChangeFieldDefinitionOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeFieldDefinitionOrder, JsonName = "changeFieldDefinitionOrder"}; 
       
        public static IUpdateType ChangeGroups = new UpdateTypeWrapper
         {Value = UpdateType.ChangeGroups, JsonName = "changeGroups"}; 
       
        public static IUpdateType ChangeInitial = new UpdateTypeWrapper
         {Value = UpdateType.ChangeInitial, JsonName = "changeInitial"}; 
       
        public static IUpdateType ChangeInputHint = new UpdateTypeWrapper
         {Value = UpdateType.ChangeInputHint, JsonName = "changeInputHint"}; 
       
        public static IUpdateType ChangeIsActive = new UpdateTypeWrapper
         {Value = UpdateType.ChangeIsActive, JsonName = "changeIsActive"}; 
       
        public static IUpdateType ChangeIsSearchable = new UpdateTypeWrapper
         {Value = UpdateType.ChangeIsSearchable, JsonName = "changeIsSearchable"}; 
       
        public static IUpdateType ChangeKey = new UpdateTypeWrapper
         {Value = UpdateType.ChangeKey, JsonName = "changeKey"}; 
       
        public static IUpdateType ChangeLabel = new UpdateTypeWrapper
         {Value = UpdateType.ChangeLabel, JsonName = "changeLabel"}; 
       
        public static IUpdateType ChangeLineItemQuantity = new UpdateTypeWrapper
         {Value = UpdateType.ChangeLineItemQuantity, JsonName = "changeLineItemQuantity"}; 
       
        public static IUpdateType ChangeLineItemsOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeLineItemsOrder, JsonName = "changeLineItemsOrder"}; 
       
        public static IUpdateType ChangeLocalizedEnumValueLabel = new UpdateTypeWrapper
         {Value = UpdateType.ChangeLocalizedEnumValueLabel, JsonName = "changeLocalizedEnumValueLabel"}; 
       
        public static IUpdateType ChangeLocalizedEnumValueOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeLocalizedEnumValueOrder, JsonName = "changeLocalizedEnumValueOrder"}; 
       
        public static IUpdateType ChangeMasterVariant = new UpdateTypeWrapper
         {Value = UpdateType.ChangeMasterVariant, JsonName = "changeMasterVariant"}; 
       
        public static IUpdateType ChangeName = new UpdateTypeWrapper
         {Value = UpdateType.ChangeName, JsonName = "changeName"}; 
       
        public static IUpdateType ChangeOrderHint = new UpdateTypeWrapper
         {Value = UpdateType.ChangeOrderHint, JsonName = "changeOrderHint"}; 
       
        public static IUpdateType ChangeOrderState = new UpdateTypeWrapper
         {Value = UpdateType.ChangeOrderState, JsonName = "changeOrderState"}; 
       
        public static IUpdateType ChangeParent = new UpdateTypeWrapper
         {Value = UpdateType.ChangeParent, JsonName = "changeParent"}; 
       
        public static IUpdateType ChangePaymentState = new UpdateTypeWrapper
         {Value = UpdateType.ChangePaymentState, JsonName = "changePaymentState"}; 
       
        public static IUpdateType ChangePlainEnumValueLabel = new UpdateTypeWrapper
         {Value = UpdateType.ChangePlainEnumValueLabel, JsonName = "changePlainEnumValueLabel"}; 
       
        public static IUpdateType ChangePredicate = new UpdateTypeWrapper
         {Value = UpdateType.ChangePredicate, JsonName = "changePredicate"}; 
       
        public static IUpdateType ChangePrice = new UpdateTypeWrapper
         {Value = UpdateType.ChangePrice, JsonName = "changePrice"}; 
       
        public static IUpdateType ChangeQuantity = new UpdateTypeWrapper
         {Value = UpdateType.ChangeQuantity, JsonName = "changeQuantity"}; 
       
        public static IUpdateType ChangeRequiresDiscountCode = new UpdateTypeWrapper
         {Value = UpdateType.ChangeRequiresDiscountCode, JsonName = "changeRequiresDiscountCode"}; 
       
        public static IUpdateType ChangeReviewRatingStatistics = new UpdateTypeWrapper
         {Value = UpdateType.ChangeReviewRatingStatistics, JsonName = "changeReviewRatingStatistics"}; 
       
        public static IUpdateType ChangeShipmentState = new UpdateTypeWrapper
         {Value = UpdateType.ChangeShipmentState, JsonName = "changeShipmentState"}; 
       
        public static IUpdateType ChangeSlug = new UpdateTypeWrapper
         {Value = UpdateType.ChangeSlug, JsonName = "changeSlug"}; 
       
        public static IUpdateType ChangeSortOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeSortOrder, JsonName = "changeSortOrder"}; 
       
        public static IUpdateType ChangeStackingMode = new UpdateTypeWrapper
         {Value = UpdateType.ChangeStackingMode, JsonName = "changeStackingMode"}; 
       
        public static IUpdateType ChangeTarget = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTarget, JsonName = "changeTarget"}; 
       
        public static IUpdateType ChangeTextLineItemName = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTextLineItemName, JsonName = "changeTextLineItemName"}; 
       
        public static IUpdateType ChangeTextLineItemQuantity = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTextLineItemQuantity, JsonName = "changeTextLineItemQuantity"}; 
       
        public static IUpdateType ChangeTextLineItemsOrder = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTextLineItemsOrder, JsonName = "changeTextLineItemsOrder"}; 
       
        public static IUpdateType ChangeTransactionInteractionId = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTransactionInteractionId, JsonName = "changeTransactionInteractionId"}; 
       
        public static IUpdateType ChangeTransactionState = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTransactionState, JsonName = "changeTransactionState"}; 
       
        public static IUpdateType ChangeTransactionTimestamp = new UpdateTypeWrapper
         {Value = UpdateType.ChangeTransactionTimestamp, JsonName = "changeTransactionTimestamp"}; 
       
        public static IUpdateType ChangeType = new UpdateTypeWrapper
         {Value = UpdateType.ChangeType, JsonName = "changeType"}; 
       
        public static IUpdateType ChangeValue = new UpdateTypeWrapper
         {Value = UpdateType.ChangeValue, JsonName = "changeValue"}; 
       
        public static IUpdateType Publish = new UpdateTypeWrapper
         {Value = UpdateType.Publish, JsonName = "publish"}; 
       
        public static IUpdateType RemoveAddress = new UpdateTypeWrapper
         {Value = UpdateType.RemoveAddress, JsonName = "removeAddress"}; 
       
        public static IUpdateType RemoveAsset = new UpdateTypeWrapper
         {Value = UpdateType.RemoveAsset, JsonName = "removeAsset"}; 
       
        public static IUpdateType RemoveAttributeDefinition = new UpdateTypeWrapper
         {Value = UpdateType.RemoveAttributeDefinition, JsonName = "removeAttributeDefinition"}; 
       
        public static IUpdateType RemoveBillingAddressId = new UpdateTypeWrapper
         {Value = UpdateType.RemoveBillingAddressId, JsonName = "removeBillingAddressId"}; 
       
        public static IUpdateType RemoveDelivery = new UpdateTypeWrapper
         {Value = UpdateType.RemoveDelivery, JsonName = "removeDelivery"}; 
       
        public static IUpdateType RemoveEnumValues = new UpdateTypeWrapper
         {Value = UpdateType.RemoveEnumValues, JsonName = "removeEnumValues"}; 
       
        public static IUpdateType RemoveFieldDefinition = new UpdateTypeWrapper
         {Value = UpdateType.RemoveFieldDefinition, JsonName = "removeFieldDefinition"}; 
       
        public static IUpdateType RemoveFromCategory = new UpdateTypeWrapper
         {Value = UpdateType.RemoveFromCategory, JsonName = "removeFromCategory"}; 
       
        public static IUpdateType RemoveImage = new UpdateTypeWrapper
         {Value = UpdateType.RemoveImage, JsonName = "removeImage"}; 
       
        public static IUpdateType RemoveItemShippingAddress = new UpdateTypeWrapper
         {Value = UpdateType.RemoveItemShippingAddress, JsonName = "removeItemShippingAddress"}; 
       
        public static IUpdateType RemoveLineItem = new UpdateTypeWrapper
         {Value = UpdateType.RemoveLineItem, JsonName = "removeLineItem"}; 
       
        public static IUpdateType RemoveLocation = new UpdateTypeWrapper
         {Value = UpdateType.RemoveLocation, JsonName = "removeLocation"}; 
       
        public static IUpdateType RemoveParcelFromDelivery = new UpdateTypeWrapper
         {Value = UpdateType.RemoveParcelFromDelivery, JsonName = "removeParcelFromDelivery"}; 
       
        public static IUpdateType RemovePayment = new UpdateTypeWrapper
         {Value = UpdateType.RemovePayment, JsonName = "removePayment"}; 
       
        public static IUpdateType RemovePrice = new UpdateTypeWrapper
         {Value = UpdateType.RemovePrice, JsonName = "removePrice"}; 
       
        public static IUpdateType RemoveRoles = new UpdateTypeWrapper
         {Value = UpdateType.RemoveRoles, JsonName = "removeRoles"}; 
       
        public static IUpdateType RemoveShippingAddressId = new UpdateTypeWrapper
         {Value = UpdateType.RemoveShippingAddressId, JsonName = "removeShippingAddressId"}; 
       
        public static IUpdateType RemoveTaxRate = new UpdateTypeWrapper
         {Value = UpdateType.RemoveTaxRate, JsonName = "removeTaxRate"}; 
       
        public static IUpdateType RemoveTextLineItem = new UpdateTypeWrapper
         {Value = UpdateType.RemoveTextLineItem, JsonName = "removeTextLineItem"}; 
       
        public static IUpdateType RemoveVariant = new UpdateTypeWrapper
         {Value = UpdateType.RemoveVariant, JsonName = "removeVariant"}; 
       
        public static IUpdateType SetAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetAddress, JsonName = "setAddress"}; 
       
        public static IUpdateType SetAnonymousId = new UpdateTypeWrapper
         {Value = UpdateType.SetAnonymousId, JsonName = "setAnonymousId"}; 
       
        public static IUpdateType SetAssetCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetAssetCustomField, JsonName = "setAssetCustomField"}; 
       
        public static IUpdateType SetAssetCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetAssetCustomType, JsonName = "setAssetCustomType"}; 
       
        public static IUpdateType SetAssetDescription = new UpdateTypeWrapper
         {Value = UpdateType.SetAssetDescription, JsonName = "setAssetDescription"}; 
       
        public static IUpdateType SetAssetSources = new UpdateTypeWrapper
         {Value = UpdateType.SetAssetSources, JsonName = "setAssetSources"}; 
       
        public static IUpdateType SetAssetTags = new UpdateTypeWrapper
         {Value = UpdateType.SetAssetTags, JsonName = "setAssetTags"}; 
       
        public static IUpdateType SetAsssetKey = new UpdateTypeWrapper
         {Value = UpdateType.SetAsssetKey, JsonName = "setAsssetKey"}; 
       
        public static IUpdateType SetAttribute = new UpdateTypeWrapper
         {Value = UpdateType.SetAttribute, JsonName = "setAttribute"}; 
       
        public static IUpdateType SetAuthorName = new UpdateTypeWrapper
         {Value = UpdateType.SetAuthorName, JsonName = "setAuthorName"}; 
       
        public static IUpdateType SetBillingAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetBillingAddress, JsonName = "setBillingAddress"}; 
       
        public static IUpdateType SetCartPredicate = new UpdateTypeWrapper
         {Value = UpdateType.SetCartPredicate, JsonName = "setCartPredicate"}; 
       
        public static IUpdateType SetCategoryOrderHint = new UpdateTypeWrapper
         {Value = UpdateType.SetCategoryOrderHint, JsonName = "setCategoryOrderHint"}; 
       
        public static IUpdateType SetCompanyName = new UpdateTypeWrapper
         {Value = UpdateType.SetCompanyName, JsonName = "setCompanyName"}; 
       
        public static IUpdateType SetCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomField, JsonName = "setCustomField"}; 
       
        public static IUpdateType SetCustomLineItemCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomLineItemCustomField, JsonName = "setCustomLineItemCustomField"}; 
       
        public static IUpdateType SetCustomLineItemCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomLineItemCustomType, JsonName = "setCustomLineItemCustomType"}; 
       
        public static IUpdateType SetCustomLineItemShippingDetails = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomLineItemShippingDetails, JsonName = "setCustomLineItemShippingDetails"}; 
       
        public static IUpdateType SetCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomType, JsonName = "setCustomType"}; 
       
        public static IUpdateType SetCustomer = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomer, JsonName = "setCustomer"}; 
       
        public static IUpdateType SetCustomerEmail = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomerEmail, JsonName = "setCustomerEmail"}; 
       
        public static IUpdateType SetCustomerGroup = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomerGroup, JsonName = "setCustomerGroup"}; 
       
        public static IUpdateType SetCustomerId = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomerId, JsonName = "setCustomerId"}; 
       
        public static IUpdateType SetCustomerNumber = new UpdateTypeWrapper
         {Value = UpdateType.SetCustomerNumber, JsonName = "setCustomerNumber"}; 
       
        public static IUpdateType SetDateOfBirth = new UpdateTypeWrapper
         {Value = UpdateType.SetDateOfBirth, JsonName = "setDateOfBirth"}; 
       
        public static IUpdateType SetDefaultBillingAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetDefaultBillingAddress, JsonName = "setDefaultBillingAddress"}; 
       
        public static IUpdateType SetDefaultShippingAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetDefaultShippingAddress, JsonName = "setDefaultShippingAddress"}; 
       
        public static IUpdateType SetDeleteDaysAfterLastModification = new UpdateTypeWrapper
         {Value = UpdateType.SetDeleteDaysAfterLastModification, JsonName = "setDeleteDaysAfterLastModification"}; 
       
        public static IUpdateType SetDeliveryAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetDeliveryAddress, JsonName = "setDeliveryAddress"}; 
       
        public static IUpdateType SetDeliveryItems = new UpdateTypeWrapper
         {Value = UpdateType.SetDeliveryItems, JsonName = "setDeliveryItems"}; 
       
        public static IUpdateType SetDescription = new UpdateTypeWrapper
         {Value = UpdateType.SetDescription, JsonName = "setDescription"}; 
       
        public static IUpdateType SetDiscountedPrice = new UpdateTypeWrapper
         {Value = UpdateType.SetDiscountedPrice, JsonName = "setDiscountedPrice"}; 
       
        public static IUpdateType SetDistributionChannels = new UpdateTypeWrapper
         {Value = UpdateType.SetDistributionChannels, JsonName = "setDistributionChannels"}; 
       
        public static IUpdateType SetExpectedDelivery = new UpdateTypeWrapper
         {Value = UpdateType.SetExpectedDelivery, JsonName = "setExpectedDelivery"}; 
       
        public static IUpdateType SetExternalId = new UpdateTypeWrapper
         {Value = UpdateType.SetExternalId, JsonName = "setExternalId"}; 
       
        public static IUpdateType SetFirstName = new UpdateTypeWrapper
         {Value = UpdateType.SetFirstName, JsonName = "setFirstName"}; 
       
        public static IUpdateType SetGeoLocation = new UpdateTypeWrapper
         {Value = UpdateType.SetGeoLocation, JsonName = "setGeoLocation"}; 
       
        public static IUpdateType SetImageLabel = new UpdateTypeWrapper
         {Value = UpdateType.SetImageLabel, JsonName = "setImageLabel"}; 
       
        public static IUpdateType SetInputTip = new UpdateTypeWrapper
         {Value = UpdateType.SetInputTip, JsonName = "setInputTip"}; 
       
        public static IUpdateType SetInterfaceId = new UpdateTypeWrapper
         {Value = UpdateType.SetInterfaceId, JsonName = "setInterfaceId"}; 
       
        public static IUpdateType SetKey = new UpdateTypeWrapper
         {Value = UpdateType.SetKey, JsonName = "setKey"}; 
       
        public static IUpdateType SetLanguages = new UpdateTypeWrapper
         {Value = UpdateType.SetLanguages, JsonName = "setLanguages"}; 
       
        public static IUpdateType SetLastName = new UpdateTypeWrapper
         {Value = UpdateType.SetLastName, JsonName = "setLastName"}; 
       
        public static IUpdateType SetLineItemCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetLineItemCustomField, JsonName = "setLineItemCustomField"}; 
       
        public static IUpdateType SetLineItemCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetLineItemCustomType, JsonName = "setLineItemCustomType"}; 
       
        public static IUpdateType SetLineItemShippingDetails = new UpdateTypeWrapper
         {Value = UpdateType.SetLineItemShippingDetails, JsonName = "setLineItemShippingDetails"}; 
       
        public static IUpdateType SetLocale = new UpdateTypeWrapper
         {Value = UpdateType.SetLocale, JsonName = "setLocale"}; 
       
        public static IUpdateType SetMaxApplications = new UpdateTypeWrapper
         {Value = UpdateType.SetMaxApplications, JsonName = "setMaxApplications"}; 
       
        public static IUpdateType SetMaxApplicationsPerCustomer = new UpdateTypeWrapper
         {Value = UpdateType.SetMaxApplicationsPerCustomer, JsonName = "setMaxApplicationsPerCustomer"}; 
       
        public static IUpdateType SetMetaDescription = new UpdateTypeWrapper
         {Value = UpdateType.SetMetaDescription, JsonName = "setMetaDescription"}; 
       
        public static IUpdateType SetMetaKeywords = new UpdateTypeWrapper
         {Value = UpdateType.SetMetaKeywords, JsonName = "setMetaKeywords"}; 
       
        public static IUpdateType SetMetaTitle = new UpdateTypeWrapper
         {Value = UpdateType.SetMetaTitle, JsonName = "setMetaTitle"}; 
       
        public static IUpdateType SetMethodInfoInterface = new UpdateTypeWrapper
         {Value = UpdateType.SetMethodInfoInterface, JsonName = "setMethodInfoInterface"}; 
       
        public static IUpdateType SetMethodInfoMethod = new UpdateTypeWrapper
         {Value = UpdateType.SetMethodInfoMethod, JsonName = "setMethodInfoMethod"}; 
       
        public static IUpdateType SetMethodInfoName = new UpdateTypeWrapper
         {Value = UpdateType.SetMethodInfoName, JsonName = "setMethodInfoName"}; 
       
        public static IUpdateType SetMiddleName = new UpdateTypeWrapper
         {Value = UpdateType.SetMiddleName, JsonName = "setMiddleName"}; 
       
        public static IUpdateType SetName = new UpdateTypeWrapper
         {Value = UpdateType.SetName, JsonName = "setName"}; 
       
        public static IUpdateType SetOrderNumber = new UpdateTypeWrapper
         {Value = UpdateType.SetOrderNumber, JsonName = "setOrderNumber"}; 
       
        public static IUpdateType SetParcelItems = new UpdateTypeWrapper
         {Value = UpdateType.SetParcelItems, JsonName = "setParcelItems"}; 
       
        public static IUpdateType SetParcelMeasurements = new UpdateTypeWrapper
         {Value = UpdateType.SetParcelMeasurements, JsonName = "setParcelMeasurements"}; 
       
        public static IUpdateType SetParcelTrackingData = new UpdateTypeWrapper
         {Value = UpdateType.SetParcelTrackingData, JsonName = "setParcelTrackingData"}; 
       
        public static IUpdateType SetPassword = new UpdateTypeWrapper
         {Value = UpdateType.SetPassword, JsonName = "setPassword"}; 
       
        public static IUpdateType SetProductPriceCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetProductPriceCustomField, JsonName = "setProductPriceCustomField"}; 
       
        public static IUpdateType SetProductPriceCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetProductPriceCustomType, JsonName = "setProductPriceCustomType"}; 
       
        public static IUpdateType SetProductVariantKey = new UpdateTypeWrapper
         {Value = UpdateType.SetProductVariantKey, JsonName = "setProductVariantKey"}; 
       
        public static IUpdateType SetRating = new UpdateTypeWrapper
         {Value = UpdateType.SetRating, JsonName = "setRating"}; 
       
        public static IUpdateType SetRestockableInDays = new UpdateTypeWrapper
         {Value = UpdateType.SetRestockableInDays, JsonName = "setRestockableInDays"}; 
       
        public static IUpdateType SetReturnPaymentState = new UpdateTypeWrapper
         {Value = UpdateType.SetReturnPaymentState, JsonName = "setReturnPaymentState"}; 
       
        public static IUpdateType SetReturnShipmentState = new UpdateTypeWrapper
         {Value = UpdateType.SetReturnShipmentState, JsonName = "setReturnShipmentState"}; 
       
        public static IUpdateType SetRoles = new UpdateTypeWrapper
         {Value = UpdateType.SetRoles, JsonName = "setRoles"}; 
       
        public static IUpdateType SetSalutation = new UpdateTypeWrapper
         {Value = UpdateType.SetSalutation, JsonName = "setSalutation"}; 
       
        public static IUpdateType SetSearchKeywords = new UpdateTypeWrapper
         {Value = UpdateType.SetSearchKeywords, JsonName = "setSearchKeywords"}; 
       
        public static IUpdateType SetShippingAddress = new UpdateTypeWrapper
         {Value = UpdateType.SetShippingAddress, JsonName = "setShippingAddress"}; 
       
        public static IUpdateType SetSku = new UpdateTypeWrapper
         {Value = UpdateType.SetSku, JsonName = "setSku"}; 
       
        public static IUpdateType SetSlug = new UpdateTypeWrapper
         {Value = UpdateType.SetSlug, JsonName = "setSlug"}; 
       
        public static IUpdateType SetStatusInterfaceCode = new UpdateTypeWrapper
         {Value = UpdateType.SetStatusInterfaceCode, JsonName = "setStatusInterfaceCode"}; 
       
        public static IUpdateType SetStatusInterfaceText = new UpdateTypeWrapper
         {Value = UpdateType.SetStatusInterfaceText, JsonName = "setStatusInterfaceText"}; 
       
        public static IUpdateType SetStore = new UpdateTypeWrapper
         {Value = UpdateType.SetStore, JsonName = "setStore"}; 
       
        public static IUpdateType SetStores = new UpdateTypeWrapper
         {Value = UpdateType.SetStores, JsonName = "setStores"}; 
       
        public static IUpdateType SetSupplyChannel = new UpdateTypeWrapper
         {Value = UpdateType.SetSupplyChannel, JsonName = "setSupplyChannel"}; 
       
        public static IUpdateType SetTarget = new UpdateTypeWrapper
         {Value = UpdateType.SetTarget, JsonName = "setTarget"}; 
       
        public static IUpdateType SetTaxCategory = new UpdateTypeWrapper
         {Value = UpdateType.SetTaxCategory, JsonName = "setTaxCategory"}; 
       
        public static IUpdateType SetText = new UpdateTypeWrapper
         {Value = UpdateType.SetText, JsonName = "setText"}; 
       
        public static IUpdateType SetTextLineItemCustomField = new UpdateTypeWrapper
         {Value = UpdateType.SetTextLineItemCustomField, JsonName = "setTextLineItemCustomField"}; 
       
        public static IUpdateType SetTextLineItemCustomType = new UpdateTypeWrapper
         {Value = UpdateType.SetTextLineItemCustomType, JsonName = "setTextLineItemCustomType"}; 
       
        public static IUpdateType SetTextLineItemDescription = new UpdateTypeWrapper
         {Value = UpdateType.SetTextLineItemDescription, JsonName = "setTextLineItemDescription"}; 
       
        public static IUpdateType SetTitle = new UpdateTypeWrapper
         {Value = UpdateType.SetTitle, JsonName = "setTitle"}; 
       
        public static IUpdateType SetTransitions = new UpdateTypeWrapper
         {Value = UpdateType.SetTransitions, JsonName = "setTransitions"}; 
       
        public static IUpdateType SetValidFrom = new UpdateTypeWrapper
         {Value = UpdateType.SetValidFrom, JsonName = "setValidFrom"}; 
       
        public static IUpdateType SetValidFromAndUntil = new UpdateTypeWrapper
         {Value = UpdateType.SetValidFromAndUntil, JsonName = "setValidFromAndUntil"}; 
       
        public static IUpdateType SetValidUntil = new UpdateTypeWrapper
         {Value = UpdateType.SetValidUntil, JsonName = "setValidUntil"}; 
       
        public static IUpdateType SetVariantAvailability = new UpdateTypeWrapper
         {Value = UpdateType.SetVariantAvailability, JsonName = "setVariantAvailability"}; 
       
        public static IUpdateType SetVatId = new UpdateTypeWrapper
         {Value = UpdateType.SetVatId, JsonName = "setVatId"}; 
       
        public static IUpdateType TransitionCustomLineItemState = new UpdateTypeWrapper
         {Value = UpdateType.TransitionCustomLineItemState, JsonName = "transitionCustomLineItemState"}; 
       
        public static IUpdateType TransitionLineItemState = new UpdateTypeWrapper
         {Value = UpdateType.TransitionLineItemState, JsonName = "transitionLineItemState"}; 
       
        public static IUpdateType TransitionState = new UpdateTypeWrapper
         {Value = UpdateType.TransitionState, JsonName = "transitionState"}; 
       
        public static IUpdateType Unpublish = new UpdateTypeWrapper
         {Value = UpdateType.Unpublish, JsonName = "unpublish"}; 
       
        public static IUpdateType UpdateItemShippingAddress = new UpdateTypeWrapper
         {Value = UpdateType.UpdateItemShippingAddress, JsonName = "updateItemShippingAddress"}; 
       
        public static IUpdateType UpdateSyncInfo = new UpdateTypeWrapper
         {Value = UpdateType.UpdateSyncInfo, JsonName = "updateSyncInfo"}; 
       
        public static IUpdateType VerifyEmail = new UpdateTypeWrapper
         {Value = UpdateType.VerifyEmail, JsonName = "verifyEmail"}; 
       
        UpdateType? Value { get; }
        
        static IUpdateType[] Values()
        {
           return new[]
           {
                AddAddress ,
                AddAsset ,
                AddAttributeDefinition ,
                AddBillingAddressId ,
                AddDelivery ,
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
                AddReturnInfo ,
                AddRoles ,
                AddShippingAddressId ,
                AddTaxRate ,
                AddTextLineItem ,
                AddToCategory ,
                AddTransaction ,
                AddVariant ,
                ChangeAddress ,
                ChangeAmountPlanned ,
                ChangeAssetName ,
                ChangeAssetOrder ,
                ChangeAttributeConstraint ,
                ChangeAttributeName ,
                ChangeAttributeOrderByName ,
                ChangeCartDiscounts ,
                ChangeCartPredicate ,
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
                ChangeLineItemQuantity ,
                ChangeLineItemsOrder ,
                ChangeLocalizedEnumValueLabel ,
                ChangeLocalizedEnumValueOrder ,
                ChangeMasterVariant ,
                ChangeName ,
                ChangeOrderHint ,
                ChangeOrderState ,
                ChangeParent ,
                ChangePaymentState ,
                ChangePlainEnumValueLabel ,
                ChangePredicate ,
                ChangePrice ,
                ChangeQuantity ,
                ChangeRequiresDiscountCode ,
                ChangeReviewRatingStatistics ,
                ChangeShipmentState ,
                ChangeSlug ,
                ChangeSortOrder ,
                ChangeStackingMode ,
                ChangeTarget ,
                ChangeTextLineItemName ,
                ChangeTextLineItemQuantity ,
                ChangeTextLineItemsOrder ,
                ChangeTransactionInteractionId ,
                ChangeTransactionState ,
                ChangeTransactionTimestamp ,
                ChangeType ,
                ChangeValue ,
                Publish ,
                RemoveAddress ,
                RemoveAsset ,
                RemoveAttributeDefinition ,
                RemoveBillingAddressId ,
                RemoveDelivery ,
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
                RemoveRoles ,
                RemoveShippingAddressId ,
                RemoveTaxRate ,
                RemoveTextLineItem ,
                RemoveVariant ,
                SetAddress ,
                SetAnonymousId ,
                SetAssetCustomField ,
                SetAssetCustomType ,
                SetAssetDescription ,
                SetAssetSources ,
                SetAssetTags ,
                SetAsssetKey ,
                SetAttribute ,
                SetAuthorName ,
                SetBillingAddress ,
                SetCartPredicate ,
                SetCategoryOrderHint ,
                SetCompanyName ,
                SetCustomField ,
                SetCustomLineItemCustomField ,
                SetCustomLineItemCustomType ,
                SetCustomLineItemShippingDetails ,
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
                SetKey ,
                SetLanguages ,
                SetLastName ,
                SetLineItemCustomField ,
                SetLineItemCustomType ,
                SetLineItemShippingDetails ,
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
                SetParcelItems ,
                SetParcelMeasurements ,
                SetParcelTrackingData ,
                SetPassword ,
                SetProductPriceCustomField ,
                SetProductPriceCustomType ,
                SetProductVariantKey ,
                SetRating ,
                SetRestockableInDays ,
                SetReturnPaymentState ,
                SetReturnShipmentState ,
                SetRoles ,
                SetSalutation ,
                SetSearchKeywords ,
                SetShippingAddress ,
                SetSku ,
                SetSlug ,
                SetStatusInterfaceCode ,
                SetStatusInterfaceText ,
                SetStore ,
                SetStores ,
                SetSupplyChannel ,
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
                SetValidUntil ,
                SetVariantAvailability ,
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
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new UpdateTypeWrapper() {JsonName = value};
        }
   }
}
