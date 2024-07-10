using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeCurrenciesActionQueryBuilderDsl
    {
        public ProjectChangeCurrenciesActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeCurrenciesActionQueryBuilderDsl Of()
        {
            return new ProjectChangeCurrenciesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeCurrenciesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCurrenciesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeCurrenciesActionQueryBuilderDsl>(p, ProjectChangeCurrenciesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectChangeCurrenciesActionQueryBuilderDsl, string> Currencies()
        {
            return new ComparableCollectionPredicateBuilder<ProjectChangeCurrenciesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencies")),
            p => new CombinationQueryPredicate<ProjectChangeCurrenciesActionQueryBuilderDsl>(p, ProjectChangeCurrenciesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
