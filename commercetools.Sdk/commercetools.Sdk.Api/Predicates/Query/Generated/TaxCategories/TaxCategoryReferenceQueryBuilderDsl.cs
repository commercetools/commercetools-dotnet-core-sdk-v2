using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryReferenceQueryBuilderDsl
    {
        public TaxCategoryReferenceQueryBuilderDsl()
        {
        }

        public static TaxCategoryReferenceQueryBuilderDsl Of()
        {
            return new TaxCategoryReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<TaxCategoryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<TaxCategoryReferenceQueryBuilderDsl>(p, TaxCategoryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TaxCategoryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TaxCategoryReferenceQueryBuilderDsl>(p, TaxCategoryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl.Of())),
                TaxCategoryReferenceQueryBuilderDsl.Of);
        }


    }
}
