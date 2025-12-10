// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerDeletedMessagePayloadQueryBuilderDsl
    {
        public CustomerDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerDeletedMessagePayloadQueryBuilderDsl>(p, CustomerDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerDeletedMessagePayloadQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerDeletedMessagePayloadQueryBuilderDsl>(p, CustomerDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
