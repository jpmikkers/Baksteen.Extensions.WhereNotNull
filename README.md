# Baksteen.Extensions.WhereNotNull

This package contains a pair of IEnumerable extension methods named `WhereNotNull()`. The method skips all null elements from a sequence.
This is useful for projects that have nullable reference types enabled because it converts `IEnumerable<T?>` into `IEnumerable<T>` .
  
## How to use:
  
  For nullable reference types:
  
    using Baksteen.Extensions.WhereNotNull;
    ...
    var seq = new string?[] { "one", null, "two", null, null, "three", null, null, null }
    var result = seq.WhereNotNull();
    // the result is IEnumerable<string> { "one", "two", "three" }
  
  For nullable value types:
  
    using Baksteen.Extensions.WhereNotNull;
    ...
    var seq = new int?[] { 1, null, 2, null, null, 3, null, null, null }
    var result = seq.WhereNotNull();
    // the result is IEnumerable<int> { 1, 2, 3 }

## See also

For more insight on the rationale of this extension, see:

* https://github.com/dotnet/runtime/issues/30381
* https://stackoverflow.com/questions/59431558/using-linqs-where-select-to-filter-out-null-and-convert-the-type-to-non-nullabl
