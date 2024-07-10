using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class UserProvidedIdentifiersQueryBuilderDsl
    {
        public UserProvidedIdentifiersQueryBuilderDsl()
        {
        }

        public static UserProvidedIdentifiersQueryBuilderDsl Of()
        {
            return new UserProvidedIdentifiersQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(p, UserProvidedIdentifiersQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(p, UserProvidedIdentifiersQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(p, UserProvidedIdentifiersQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string> CustomerNumber()
        {
            return new ComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerNumber")),
            p => new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(p, UserProvidedIdentifiersQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<UserProvidedIdentifiersQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(p, UserProvidedIdentifiersQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                UserProvidedIdentifiersQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl> ContainerAndKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ContainerAndKeyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ContainerAndKeyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<UserProvidedIdentifiersQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("containerAndKey"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ContainerAndKeyQueryBuilderDsl.Of())),
                UserProvidedIdentifiersQueryBuilderDsl.Of);
        }


    }
}
