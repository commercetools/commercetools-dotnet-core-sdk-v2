using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeDraftQueryBuilderDsl
    {
        public TypeDraftQueryBuilderDsl()
        {
        }

        public static TypeDraftQueryBuilderDsl Of()
        {
            return new TypeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TypeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(p, TypeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TypeDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TypeDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TypeDraftQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<TypeDraftQueryBuilderDsl, string> ResourceTypeIds()
        {
            return new ComparableCollectionPredicateBuilder<TypeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeIds")),
            p => new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(p, TypeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeDraftQueryBuilderDsl> FieldDefinitions(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fieldDefinitions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldDefinitionQueryBuilderDsl.Of())),
                TypeDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TypeDraftQueryBuilderDsl> FieldDefinitions()
        {
            return new CollectionPredicateBuilder<TypeDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldDefinitions")),
                    p => new CombinationQueryPredicate<TypeDraftQueryBuilderDsl>(p, TypeDraftQueryBuilderDsl.Of));
        }

    }
}
