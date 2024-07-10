using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeCustomerSearchStatusActionQueryBuilderDsl
    {
        public ProjectChangeCustomerSearchStatusActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeCustomerSearchStatusActionQueryBuilderDsl Of()
        {
            return new ProjectChangeCustomerSearchStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl>(p, ProjectChangeCustomerSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ProjectChangeCustomerSearchStatusActionQueryBuilderDsl>(p, ProjectChangeCustomerSearchStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
