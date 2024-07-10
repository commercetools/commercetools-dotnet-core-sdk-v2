using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl
    {
        public CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string> PreviousValue()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValue")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
