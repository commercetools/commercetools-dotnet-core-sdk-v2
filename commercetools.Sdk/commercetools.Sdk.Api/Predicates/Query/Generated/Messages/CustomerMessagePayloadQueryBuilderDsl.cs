// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerMessagePayloadQueryBuilderDsl
    {
        public CustomerMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerMessagePayloadQueryBuilderDsl>(p, CustomerMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
