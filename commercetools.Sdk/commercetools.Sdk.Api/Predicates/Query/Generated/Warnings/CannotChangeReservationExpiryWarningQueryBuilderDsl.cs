// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class CannotChangeReservationExpiryWarningQueryBuilderDsl
    {
        public CannotChangeReservationExpiryWarningQueryBuilderDsl()
        {
        }

        public static CannotChangeReservationExpiryWarningQueryBuilderDsl Of()
        {
            return new CannotChangeReservationExpiryWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CannotChangeReservationExpiryWarningQueryBuilderDsl>(p, CannotChangeReservationExpiryWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CannotChangeReservationExpiryWarningQueryBuilderDsl>(p, CannotChangeReservationExpiryWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CannotChangeReservationExpiryWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CannotChangeReservationExpiryWarningQueryBuilderDsl>(p, CannotChangeReservationExpiryWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
