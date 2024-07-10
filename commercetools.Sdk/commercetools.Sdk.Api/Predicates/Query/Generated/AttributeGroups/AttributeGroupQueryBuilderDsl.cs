using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupQueryBuilderDsl
    {
        public AttributeGroupQueryBuilderDsl()
        {
        }

        public static AttributeGroupQueryBuilderDsl Of()
        {
            return new AttributeGroupQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AttributeGroupQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AttributeGroupQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AttributeGroupQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeReferenceQueryBuilderDsl.Of())),
                AttributeGroupQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeGroupQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<AttributeGroupQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeGroupQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeGroupQueryBuilderDsl>(p, AttributeGroupQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
