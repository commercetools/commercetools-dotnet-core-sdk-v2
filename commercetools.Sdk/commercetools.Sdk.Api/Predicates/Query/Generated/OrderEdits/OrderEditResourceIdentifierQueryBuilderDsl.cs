// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditResourceIdentifierQueryBuilderDsl
    {
        public OrderEditResourceIdentifierQueryBuilderDsl()
        {
        }

        public static OrderEditResourceIdentifierQueryBuilderDsl Of()
        {
            return new OrderEditResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<OrderEditResourceIdentifierQueryBuilderDsl>(p, OrderEditResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderEditResourceIdentifierQueryBuilderDsl>(p, OrderEditResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<OrderEditResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<OrderEditResourceIdentifierQueryBuilderDsl>(p, OrderEditResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
