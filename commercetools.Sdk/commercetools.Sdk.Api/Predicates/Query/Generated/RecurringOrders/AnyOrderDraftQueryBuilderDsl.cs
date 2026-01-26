// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class AnyOrderDraftQueryBuilderDsl
    {
        public AnyOrderDraftQueryBuilderDsl()
        {
        }

        public static AnyOrderDraftQueryBuilderDsl Of()
        {
            return new AnyOrderDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AnyOrderDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AnyOrderDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AnyOrderDraftQueryBuilderDsl>(p, AnyOrderDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
