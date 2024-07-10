using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AttributeNameDoesNotExistErrorQueryBuilderDsl
    {
        public AttributeNameDoesNotExistErrorQueryBuilderDsl()
        {
        }

        public static AttributeNameDoesNotExistErrorQueryBuilderDsl Of()
        {
            return new AttributeNameDoesNotExistErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AttributeNameDoesNotExistErrorQueryBuilderDsl>(p, AttributeNameDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AttributeNameDoesNotExistErrorQueryBuilderDsl>(p, AttributeNameDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string> InvalidAttributeName()
        {
            return new ComparisonPredicateBuilder<AttributeNameDoesNotExistErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("invalidAttributeName")),
            p => new CombinationQueryPredicate<AttributeNameDoesNotExistErrorQueryBuilderDsl>(p, AttributeNameDoesNotExistErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
