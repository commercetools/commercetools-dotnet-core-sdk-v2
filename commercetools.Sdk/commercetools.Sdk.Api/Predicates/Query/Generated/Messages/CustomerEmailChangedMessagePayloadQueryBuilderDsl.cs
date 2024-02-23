// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerEmailChangedMessagePayloadQueryBuilderDsl
    {
        public CustomerEmailChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerEmailChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerEmailChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerEmailChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerEmailChangedMessagePayloadQueryBuilderDsl>(p, CustomerEmailChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailChangedMessagePayloadQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<CustomerEmailChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<CustomerEmailChangedMessagePayloadQueryBuilderDsl>(p, CustomerEmailChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
