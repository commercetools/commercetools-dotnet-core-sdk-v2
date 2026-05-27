// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Warnings
{

    public partial class CannotUpdateReservationWarningQueryBuilderDsl
    {
        public CannotUpdateReservationWarningQueryBuilderDsl()
        {
        }

        public static CannotUpdateReservationWarningQueryBuilderDsl Of()
        {
            return new CannotUpdateReservationWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, decimal> RequestedQuantity()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requestedQuantity")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, decimal> ReservedQuantity()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reservedQuantity")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string> SupplyChannel()
        {
            return new ComparisonPredicateBuilder<CannotUpdateReservationWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannel")),
            p => new CombinationQueryPredicate<CannotUpdateReservationWarningQueryBuilderDsl>(p, CannotUpdateReservationWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
