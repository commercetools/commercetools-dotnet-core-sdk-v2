using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum Permission
    {
        [Description("AddChildUnits")]
        AddChildUnits,

        [Description("UpdateAssociates")]
        UpdateAssociates,

        [Description("UpdateBusinessUnitDetails")]
        UpdateBusinessUnitDetails,

        [Description("UpdateParentUnit")]
        UpdateParentUnit,

        [Description("ViewMyCarts")]
        ViewMyCarts,

        [Description("ViewOthersCarts")]
        ViewOthersCarts,

        [Description("UpdateMyCarts")]
        UpdateMyCarts,

        [Description("UpdateOthersCarts")]
        UpdateOthersCarts,

        [Description("CreateMyCarts")]
        CreateMyCarts,

        [Description("CreateOthersCarts")]
        CreateOthersCarts,

        [Description("DeleteMyCarts")]
        DeleteMyCarts,

        [Description("DeleteOthersCarts")]
        DeleteOthersCarts,

        [Description("ViewMyOrders")]
        ViewMyOrders,

        [Description("ViewOthersOrders")]
        ViewOthersOrders,

        [Description("UpdateMyOrders")]
        UpdateMyOrders,

        [Description("UpdateOthersOrders")]
        UpdateOthersOrders,

        [Description("CreateMyOrdersFromMyCarts")]
        CreateMyOrdersFromMyCarts,

        [Description("CreateMyOrdersFromMyQuotes")]
        CreateMyOrdersFromMyQuotes,

        [Description("CreateOrdersFromOthersCarts")]
        CreateOrdersFromOthersCarts,

        [Description("CreateOrdersFromOthersQuotes")]
        CreateOrdersFromOthersQuotes,

        [Description("ViewMyQuotes")]
        ViewMyQuotes,

        [Description("ViewOthersQuotes")]
        ViewOthersQuotes,

        [Description("AcceptMyQuotes")]
        AcceptMyQuotes,

        [Description("AcceptOthersQuotes")]
        AcceptOthersQuotes,

        [Description("DeclineMyQuotes")]
        DeclineMyQuotes,

        [Description("DeclineOthersQuotes")]
        DeclineOthersQuotes,

        [Description("RenegotiateMyQuotes")]
        RenegotiateMyQuotes,

        [Description("RenegotiateOthersQuotes")]
        RenegotiateOthersQuotes,

        [Description("ReassignMyQuotes")]
        ReassignMyQuotes,

        [Description("ReassignOthersQuotes")]
        ReassignOthersQuotes,

        [Description("ViewMyQuoteRequests")]
        ViewMyQuoteRequests,

        [Description("ViewOthersQuoteRequests")]
        ViewOthersQuoteRequests,

        [Description("UpdateMyQuoteRequests")]
        UpdateMyQuoteRequests,

        [Description("UpdateOthersQuoteRequests")]
        UpdateOthersQuoteRequests,

        [Description("CreateMyQuoteRequestsFromMyCarts")]
        CreateMyQuoteRequestsFromMyCarts,

        [Description("CreateQuoteRequestsFromOthersCarts")]
        CreateQuoteRequestsFromOthersCarts,

        [Description("CreateApprovalRules")]
        CreateApprovalRules,

        [Description("UpdateApprovalRules")]
        UpdateApprovalRules,

        [Description("UpdateApprovalFlows")]
        UpdateApprovalFlows,

        [Description("ViewMyShoppingLists")]
        ViewMyShoppingLists,

        [Description("ViewOthersShoppingLists")]
        ViewOthersShoppingLists,

        [Description("UpdateMyShoppingLists")]
        UpdateMyShoppingLists,

        [Description("UpdateOthersShoppingLists")]
        UpdateOthersShoppingLists,

        [Description("CreateMyShoppingLists")]
        CreateMyShoppingLists,

        [Description("CreateOthersShoppingLists")]
        CreateOthersShoppingLists,

        [Description("DeleteMyShoppingLists")]
        DeleteMyShoppingLists,

        [Description("DeleteOthersShoppingLists")]
        DeleteOthersShoppingLists
    }

    public class PermissionWrapper : IPermission
    {
        public string JsonName { get; internal set; }
        public Permission? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IPermission), "FindEnum")]
    public interface IPermission : IJsonName, IEnumerable<char>
    {
        public static IPermission AddChildUnits = new PermissionWrapper
        { Value = Permission.AddChildUnits, JsonName = "AddChildUnits" };

        public static IPermission UpdateAssociates = new PermissionWrapper
        { Value = Permission.UpdateAssociates, JsonName = "UpdateAssociates" };

        public static IPermission UpdateBusinessUnitDetails = new PermissionWrapper
        { Value = Permission.UpdateBusinessUnitDetails, JsonName = "UpdateBusinessUnitDetails" };

        public static IPermission UpdateParentUnit = new PermissionWrapper
        { Value = Permission.UpdateParentUnit, JsonName = "UpdateParentUnit" };

        public static IPermission ViewMyCarts = new PermissionWrapper
        { Value = Permission.ViewMyCarts, JsonName = "ViewMyCarts" };

        public static IPermission ViewOthersCarts = new PermissionWrapper
        { Value = Permission.ViewOthersCarts, JsonName = "ViewOthersCarts" };

        public static IPermission UpdateMyCarts = new PermissionWrapper
        { Value = Permission.UpdateMyCarts, JsonName = "UpdateMyCarts" };

        public static IPermission UpdateOthersCarts = new PermissionWrapper
        { Value = Permission.UpdateOthersCarts, JsonName = "UpdateOthersCarts" };

        public static IPermission CreateMyCarts = new PermissionWrapper
        { Value = Permission.CreateMyCarts, JsonName = "CreateMyCarts" };

        public static IPermission CreateOthersCarts = new PermissionWrapper
        { Value = Permission.CreateOthersCarts, JsonName = "CreateOthersCarts" };

        public static IPermission DeleteMyCarts = new PermissionWrapper
        { Value = Permission.DeleteMyCarts, JsonName = "DeleteMyCarts" };

        public static IPermission DeleteOthersCarts = new PermissionWrapper
        { Value = Permission.DeleteOthersCarts, JsonName = "DeleteOthersCarts" };

        public static IPermission ViewMyOrders = new PermissionWrapper
        { Value = Permission.ViewMyOrders, JsonName = "ViewMyOrders" };

        public static IPermission ViewOthersOrders = new PermissionWrapper
        { Value = Permission.ViewOthersOrders, JsonName = "ViewOthersOrders" };

        public static IPermission UpdateMyOrders = new PermissionWrapper
        { Value = Permission.UpdateMyOrders, JsonName = "UpdateMyOrders" };

        public static IPermission UpdateOthersOrders = new PermissionWrapper
        { Value = Permission.UpdateOthersOrders, JsonName = "UpdateOthersOrders" };

        public static IPermission CreateMyOrdersFromMyCarts = new PermissionWrapper
        { Value = Permission.CreateMyOrdersFromMyCarts, JsonName = "CreateMyOrdersFromMyCarts" };

        public static IPermission CreateMyOrdersFromMyQuotes = new PermissionWrapper
        { Value = Permission.CreateMyOrdersFromMyQuotes, JsonName = "CreateMyOrdersFromMyQuotes" };

        public static IPermission CreateOrdersFromOthersCarts = new PermissionWrapper
        { Value = Permission.CreateOrdersFromOthersCarts, JsonName = "CreateOrdersFromOthersCarts" };

        public static IPermission CreateOrdersFromOthersQuotes = new PermissionWrapper
        { Value = Permission.CreateOrdersFromOthersQuotes, JsonName = "CreateOrdersFromOthersQuotes" };

        public static IPermission ViewMyQuotes = new PermissionWrapper
        { Value = Permission.ViewMyQuotes, JsonName = "ViewMyQuotes" };

        public static IPermission ViewOthersQuotes = new PermissionWrapper
        { Value = Permission.ViewOthersQuotes, JsonName = "ViewOthersQuotes" };

        public static IPermission AcceptMyQuotes = new PermissionWrapper
        { Value = Permission.AcceptMyQuotes, JsonName = "AcceptMyQuotes" };

        public static IPermission AcceptOthersQuotes = new PermissionWrapper
        { Value = Permission.AcceptOthersQuotes, JsonName = "AcceptOthersQuotes" };

        public static IPermission DeclineMyQuotes = new PermissionWrapper
        { Value = Permission.DeclineMyQuotes, JsonName = "DeclineMyQuotes" };

        public static IPermission DeclineOthersQuotes = new PermissionWrapper
        { Value = Permission.DeclineOthersQuotes, JsonName = "DeclineOthersQuotes" };

        public static IPermission RenegotiateMyQuotes = new PermissionWrapper
        { Value = Permission.RenegotiateMyQuotes, JsonName = "RenegotiateMyQuotes" };

        public static IPermission RenegotiateOthersQuotes = new PermissionWrapper
        { Value = Permission.RenegotiateOthersQuotes, JsonName = "RenegotiateOthersQuotes" };

        public static IPermission ReassignMyQuotes = new PermissionWrapper
        { Value = Permission.ReassignMyQuotes, JsonName = "ReassignMyQuotes" };

        public static IPermission ReassignOthersQuotes = new PermissionWrapper
        { Value = Permission.ReassignOthersQuotes, JsonName = "ReassignOthersQuotes" };

        public static IPermission ViewMyQuoteRequests = new PermissionWrapper
        { Value = Permission.ViewMyQuoteRequests, JsonName = "ViewMyQuoteRequests" };

        public static IPermission ViewOthersQuoteRequests = new PermissionWrapper
        { Value = Permission.ViewOthersQuoteRequests, JsonName = "ViewOthersQuoteRequests" };

        public static IPermission UpdateMyQuoteRequests = new PermissionWrapper
        { Value = Permission.UpdateMyQuoteRequests, JsonName = "UpdateMyQuoteRequests" };

        public static IPermission UpdateOthersQuoteRequests = new PermissionWrapper
        { Value = Permission.UpdateOthersQuoteRequests, JsonName = "UpdateOthersQuoteRequests" };

        public static IPermission CreateMyQuoteRequestsFromMyCarts = new PermissionWrapper
        { Value = Permission.CreateMyQuoteRequestsFromMyCarts, JsonName = "CreateMyQuoteRequestsFromMyCarts" };

        public static IPermission CreateQuoteRequestsFromOthersCarts = new PermissionWrapper
        { Value = Permission.CreateQuoteRequestsFromOthersCarts, JsonName = "CreateQuoteRequestsFromOthersCarts" };

        public static IPermission CreateApprovalRules = new PermissionWrapper
        { Value = Permission.CreateApprovalRules, JsonName = "CreateApprovalRules" };

        public static IPermission UpdateApprovalRules = new PermissionWrapper
        { Value = Permission.UpdateApprovalRules, JsonName = "UpdateApprovalRules" };

        public static IPermission UpdateApprovalFlows = new PermissionWrapper
        { Value = Permission.UpdateApprovalFlows, JsonName = "UpdateApprovalFlows" };

        public static IPermission ViewMyShoppingLists = new PermissionWrapper
        { Value = Permission.ViewMyShoppingLists, JsonName = "ViewMyShoppingLists" };

        public static IPermission ViewOthersShoppingLists = new PermissionWrapper
        { Value = Permission.ViewOthersShoppingLists, JsonName = "ViewOthersShoppingLists" };

        public static IPermission UpdateMyShoppingLists = new PermissionWrapper
        { Value = Permission.UpdateMyShoppingLists, JsonName = "UpdateMyShoppingLists" };

        public static IPermission UpdateOthersShoppingLists = new PermissionWrapper
        { Value = Permission.UpdateOthersShoppingLists, JsonName = "UpdateOthersShoppingLists" };

        public static IPermission CreateMyShoppingLists = new PermissionWrapper
        { Value = Permission.CreateMyShoppingLists, JsonName = "CreateMyShoppingLists" };

        public static IPermission CreateOthersShoppingLists = new PermissionWrapper
        { Value = Permission.CreateOthersShoppingLists, JsonName = "CreateOthersShoppingLists" };

        public static IPermission DeleteMyShoppingLists = new PermissionWrapper
        { Value = Permission.DeleteMyShoppingLists, JsonName = "DeleteMyShoppingLists" };

        public static IPermission DeleteOthersShoppingLists = new PermissionWrapper
        { Value = Permission.DeleteOthersShoppingLists, JsonName = "DeleteOthersShoppingLists" };

        Permission? Value { get; }

        static IPermission[] Values()
        {
            return new[]
            {
                 AddChildUnits ,
                 UpdateAssociates ,
                 UpdateBusinessUnitDetails ,
                 UpdateParentUnit ,
                 ViewMyCarts ,
                 ViewOthersCarts ,
                 UpdateMyCarts ,
                 UpdateOthersCarts ,
                 CreateMyCarts ,
                 CreateOthersCarts ,
                 DeleteMyCarts ,
                 DeleteOthersCarts ,
                 ViewMyOrders ,
                 ViewOthersOrders ,
                 UpdateMyOrders ,
                 UpdateOthersOrders ,
                 CreateMyOrdersFromMyCarts ,
                 CreateMyOrdersFromMyQuotes ,
                 CreateOrdersFromOthersCarts ,
                 CreateOrdersFromOthersQuotes ,
                 ViewMyQuotes ,
                 ViewOthersQuotes ,
                 AcceptMyQuotes ,
                 AcceptOthersQuotes ,
                 DeclineMyQuotes ,
                 DeclineOthersQuotes ,
                 RenegotiateMyQuotes ,
                 RenegotiateOthersQuotes ,
                 ReassignMyQuotes ,
                 ReassignOthersQuotes ,
                 ViewMyQuoteRequests ,
                 ViewOthersQuoteRequests ,
                 UpdateMyQuoteRequests ,
                 UpdateOthersQuoteRequests ,
                 CreateMyQuoteRequestsFromMyCarts ,
                 CreateQuoteRequestsFromOthersCarts ,
                 CreateApprovalRules ,
                 UpdateApprovalRules ,
                 UpdateApprovalFlows ,
                 ViewMyShoppingLists ,
                 ViewOthersShoppingLists ,
                 UpdateMyShoppingLists ,
                 UpdateOthersShoppingLists ,
                 CreateMyShoppingLists ,
                 CreateOthersShoppingLists ,
                 DeleteMyShoppingLists ,
                 DeleteOthersShoppingLists
             };
        }
        static IPermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PermissionWrapper() { JsonName = value };
        }
    }
}
