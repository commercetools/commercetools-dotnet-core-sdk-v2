# Query Predicate Builders

The commercetools API provided [predicates](https://docs.commercetools.com/api/predicates/query) to query resources. Using
the builders type safe predicates can be built.

For each resource that provides a query endpoint the request builders provide a `WithQuery` method. The argument is
a lambda function which provides the predicate builder. For each property of a resource the necessary methods are provided
as well as the predicate operators.

## Usage

```csharp
// name = "Peter" // For exact match to "Peter". This does not perform substring match.
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().Is("Peter"));

// firstName != "Peter" 
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().IsNot("Peter"));

// version < 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsLessThan(42));
// version > 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsGreaterThan(42));
// version <= 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsLessThanOrEqual(42));
// version >= 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsGreaterThanOrEqual(42));
// version <> 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsNot(42));

// Combine any two conditional expressions in a logical conjunction / disjunction
// firstName = "Peter" and version < 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().Is("Peter").And(q.Version().IsLessThan(42)));
// firstName = "Peter" or version < 42
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().Is("Peter").Or(q.Version().IsLessThan(42)));

// Negate any other conditional expression
// not (firstName = "Peter" and version < 42)
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().Is("Peter").And(q.Version().IsLessThan(42)).Not());

// Check whether a field's value is or is not contained in
// a specified set of values.
// version in (42, 43, 44)
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsIn(new[] { 42, 43, 44 }));
// age not in (42, 43, 44)
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.Version().IsIn(new[] { 42, 43, 44 }).Not());
```

More examples can be found in the [query test class](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/master/commercetools.Sdk/Tests/commercetools.Sdk.Api.Tests/QueryTests.cs)