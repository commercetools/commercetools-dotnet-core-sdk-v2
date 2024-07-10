using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerLastNameSetMessagePayloadQueryBuilderDsl
    {
        public CustomerLastNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerLastNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerLastNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerLastNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerLastNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerLastNameSetMessagePayloadQueryBuilderDsl>(p, CustomerLastNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerLastNameSetMessagePayloadQueryBuilderDsl, string> LastName()
        {
            return new ComparisonPredicateBuilder<CustomerLastNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastName")),
            p => new CombinationQueryPredicate<CustomerLastNameSetMessagePayloadQueryBuilderDsl>(p, CustomerLastNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
