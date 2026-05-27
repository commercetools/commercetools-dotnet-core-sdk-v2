using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reservations
{
    public enum ReservationState
    {
        [Description("Created")]
        Created,

        [Description("Updated")]
        Updated,

        [Description("Released")]
        Released,

        [Description("Expired")]
        Expired,

        [Description("Committed")]
        Committed
    }

    public class ReservationStateWrapper : IReservationState
    {
        public string JsonName { get; internal set; }
        public ReservationState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IReservationState), "FindEnum")]
    public interface IReservationState : IJsonName, IEnumerable<char>
    {
        public static IReservationState Created = new ReservationStateWrapper
        { Value = ReservationState.Created, JsonName = "Created" };

        public static IReservationState Updated = new ReservationStateWrapper
        { Value = ReservationState.Updated, JsonName = "Updated" };

        public static IReservationState Released = new ReservationStateWrapper
        { Value = ReservationState.Released, JsonName = "Released" };

        public static IReservationState Expired = new ReservationStateWrapper
        { Value = ReservationState.Expired, JsonName = "Expired" };

        public static IReservationState Committed = new ReservationStateWrapper
        { Value = ReservationState.Committed, JsonName = "Committed" };

        ReservationState? Value { get; }

        static IReservationState[] Values()
        {
            return new[]
            {
                 Created ,
                 Updated ,
                 Released ,
                 Expired ,
                 Committed
             };
        }
        static IReservationState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReservationStateWrapper() { JsonName = value };
        }
    }
}
