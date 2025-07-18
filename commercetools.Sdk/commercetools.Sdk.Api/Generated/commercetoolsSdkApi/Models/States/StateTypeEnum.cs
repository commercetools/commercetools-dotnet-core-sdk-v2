using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.States
{
    public enum StateTypeEnum
    {
        [Description("OrderState")]
        OrderState,

        [Description("RecurringOrderState")]
        RecurringOrderState,

        [Description("LineItemState")]
        LineItemState,

        [Description("ProductState")]
        ProductState,

        [Description("ReviewState")]
        ReviewState,

        [Description("PaymentState")]
        PaymentState,

        [Description("QuoteRequestState")]
        QuoteRequestState,

        [Description("StagedQuoteState")]
        StagedQuoteState,

        [Description("QuoteState")]
        QuoteState
    }

    public class StateTypeEnumWrapper : IStateTypeEnum
    {
        public string JsonName { get; internal set; }
        public StateTypeEnum? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IStateTypeEnum), "FindEnum")]
    public interface IStateTypeEnum : IJsonName, IEnumerable<char>
    {
        public static IStateTypeEnum OrderState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.OrderState, JsonName = "OrderState" };

        public static IStateTypeEnum RecurringOrderState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.RecurringOrderState, JsonName = "RecurringOrderState" };

        public static IStateTypeEnum LineItemState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.LineItemState, JsonName = "LineItemState" };

        public static IStateTypeEnum ProductState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.ProductState, JsonName = "ProductState" };

        public static IStateTypeEnum ReviewState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.ReviewState, JsonName = "ReviewState" };

        public static IStateTypeEnum PaymentState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.PaymentState, JsonName = "PaymentState" };

        public static IStateTypeEnum QuoteRequestState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.QuoteRequestState, JsonName = "QuoteRequestState" };

        public static IStateTypeEnum StagedQuoteState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.StagedQuoteState, JsonName = "StagedQuoteState" };

        public static IStateTypeEnum QuoteState = new StateTypeEnumWrapper
        { Value = StateTypeEnum.QuoteState, JsonName = "QuoteState" };

        StateTypeEnum? Value { get; }

        static IStateTypeEnum[] Values()
        {
            return new[]
            {
                 OrderState ,
                 RecurringOrderState ,
                 LineItemState ,
                 ProductState ,
                 ReviewState ,
                 PaymentState ,
                 QuoteRequestState ,
                 StagedQuoteState ,
                 QuoteState
             };
        }
        static IStateTypeEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StateTypeEnumWrapper() { JsonName = value };
        }
    }
}
