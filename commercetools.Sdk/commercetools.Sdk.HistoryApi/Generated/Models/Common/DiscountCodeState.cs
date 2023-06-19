using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum DiscountCodeState
    {
        [Description("NotActive")]
        NotActive,

        [Description("DoesNotMatchCart")]
        DoesNotMatchCart,

        [Description("MatchesCart")]
        MatchesCart,

        [Description("MaxApplicationReached")]
        MaxApplicationReached,

        [Description("ApplicationStoppedByPreviousDiscount")]
        ApplicationStoppedByPreviousDiscount,

        [Description("NotValid")]
        NotValid
    }

    public class DiscountCodeStateWrapper : IDiscountCodeState
    {
        public string JsonName { get; internal set; }
        public DiscountCodeState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IDiscountCodeState), "FindEnum")]
    public interface IDiscountCodeState : IJsonName, IEnumerable<char>
    {
        public static IDiscountCodeState NotActive = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.NotActive, JsonName = "NotActive" };

        public static IDiscountCodeState DoesNotMatchCart = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.DoesNotMatchCart, JsonName = "DoesNotMatchCart" };

        public static IDiscountCodeState MatchesCart = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.MatchesCart, JsonName = "MatchesCart" };

        public static IDiscountCodeState MaxApplicationReached = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.MaxApplicationReached, JsonName = "MaxApplicationReached" };

        public static IDiscountCodeState ApplicationStoppedByPreviousDiscount = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.ApplicationStoppedByPreviousDiscount, JsonName = "ApplicationStoppedByPreviousDiscount" };

        public static IDiscountCodeState NotValid = new DiscountCodeStateWrapper
        { Value = DiscountCodeState.NotValid, JsonName = "NotValid" };

        DiscountCodeState? Value { get; }

        static IDiscountCodeState[] Values()
        {
            return new[]
            {
                 NotActive ,
                 DoesNotMatchCart ,
                 MatchesCart ,
                 MaxApplicationReached ,
                 ApplicationStoppedByPreviousDiscount ,
                 NotValid
             };
        }
        static IDiscountCodeState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new DiscountCodeStateWrapper() { JsonName = value };
        }
    }
}
