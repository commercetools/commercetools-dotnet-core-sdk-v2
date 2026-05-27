// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class CannotCreateReservationWarningQueryBuilderDsl
    {
        public CannotCreateReservationWarningQueryBuilderDsl()
        {
        }

        public static CannotCreateReservationWarningQueryBuilderDsl Of()
        {
            return new CannotCreateReservationWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string> SupplyChannel()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannel")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, decimal> Quantity()
        {
            return new ComparisonPredicateBuilder<CannotCreateReservationWarningQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CannotCreateReservationWarningQueryBuilderDsl>(p, CannotCreateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
