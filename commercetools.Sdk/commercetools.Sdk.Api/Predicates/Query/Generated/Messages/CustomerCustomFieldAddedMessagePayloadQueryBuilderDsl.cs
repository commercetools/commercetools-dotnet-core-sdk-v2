// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl
    {
        public CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
