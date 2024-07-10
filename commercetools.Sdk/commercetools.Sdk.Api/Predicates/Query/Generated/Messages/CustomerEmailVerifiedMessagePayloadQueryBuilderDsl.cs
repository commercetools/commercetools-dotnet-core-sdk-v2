using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerEmailVerifiedMessagePayloadQueryBuilderDsl
    {
        public CustomerEmailVerifiedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerEmailVerifiedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerEmailVerifiedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailVerifiedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerEmailVerifiedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerEmailVerifiedMessagePayloadQueryBuilderDsl>(p, CustomerEmailVerifiedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
