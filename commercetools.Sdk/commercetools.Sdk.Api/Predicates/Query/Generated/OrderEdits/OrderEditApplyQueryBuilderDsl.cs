// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditApplyQueryBuilderDsl
    {
        public OrderEditApplyQueryBuilderDsl()
        {
        }

        public static OrderEditApplyQueryBuilderDsl Of()
        {
            return new OrderEditApplyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditApplyQueryBuilderDsl, long> EditVersion()
        {
            return new ComparisonPredicateBuilder<OrderEditApplyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("editVersion")),
            p => new CombinationQueryPredicate<OrderEditApplyQueryBuilderDsl>(p, OrderEditApplyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditApplyQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderEditApplyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderEditApplyQueryBuilderDsl>(p, OrderEditApplyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
