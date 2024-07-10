using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeQueryBuilderDsl
    {
        public TypeQueryBuilderDsl()
        {
        }

        public static TypeQueryBuilderDsl Of()
        {
            return new TypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<TypeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<TypeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<TypeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                TypeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TypeQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                TypeQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TypeQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TypeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TypeQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TypeQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<TypeQueryBuilderDsl, string> ResourceTypeIds()
        {
            return new ComparableCollectionPredicateBuilder<TypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeIds")),
            p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeQueryBuilderDsl> FieldDefinitions(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fieldDefinitions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl.Of())),
                TypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TypeQueryBuilderDsl> FieldDefinitions()
        {
            return new CollectionPredicateBuilder<TypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldDefinitions")),
                    p => new CombinationQueryPredicate<TypeQueryBuilderDsl>(p, TypeQueryBuilderDsl.Of));
        }

    }
}
