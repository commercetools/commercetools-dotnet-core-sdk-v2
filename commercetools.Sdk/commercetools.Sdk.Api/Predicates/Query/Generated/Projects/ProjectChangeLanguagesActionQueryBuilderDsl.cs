using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeLanguagesActionQueryBuilderDsl
    {
        public ProjectChangeLanguagesActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeLanguagesActionQueryBuilderDsl Of()
        {
            return new ProjectChangeLanguagesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeLanguagesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeLanguagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeLanguagesActionQueryBuilderDsl>(p, ProjectChangeLanguagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectChangeLanguagesActionQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<ProjectChangeLanguagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<ProjectChangeLanguagesActionQueryBuilderDsl>(p, ProjectChangeLanguagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
