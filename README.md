## ReList.cs

### Description
`ReList.cs` defines a generic list implementation `ReList<T>` that mimics some functionalities of `List<T>` in C#. It includes basic operations like adding, removing, indexing, cloning, and equality comparison.

### Features
- **Generic Type**: Supports storing elements of any type `T`.
- **Basic Operations**: Includes `Add`, `Remove`, `Clear`, `Contains`, `CopyTo`, `IndexOf`, `Insert`, and `RemoveAt`.
- **Equality**: Implements `IEquatable` for comparing lists.
- **Cloning**: Implements `ICloneable` to create a deep copy of the list.
- **Iteration**: Implements `IEnumerable<T>` for iteration using `foreach`.

### Methods

- **`Add(T item)`**: Adds an item to the end of the list.
- **`Clear()`**: Clears all items from the list.
- **`Contains(T item)`**: Checks if the list contains a specific item.
- **`CopyTo(T[] array, int arrayIndex)`**: Copies the elements of the list to an array starting at a specific index.
- **`IndexOf(T item)`**: Returns the index of the first occurrence of a specific item.
- **`Insert(int index, T item)`**: Inserts an item at the specified index.
- **`Remove(T item)`**: Removes the first occurrence of a specific item from the list.
- **`RemoveAt(int index)`**: Removes the item at the specified index.
- **`Equals(ReList<T> other)`**: Compares two lists for equality based on their elements.
- **`Clone()`**: Creates a deep copy of the list.
- **`GetEnumerator()`**: Returns an enumerator that iterates through the list.

### Additional Method
- **`PrintReList()`**: Prints all elements of the list to the console.

## Program.cs

### Description
`Program.cs` demonstrates the usage of `ReList<T>` with integer elements. It showcases basic operations, cloning, equality comparison, and iteration using `foreach`.

### Example
```csharp
ReList<int> list1 = new ReList<int>();
list1.Add(1);
list1.Add(2);
list1.Add(3);

Console.WriteLine("List1:");
list1.PrintReList();

ReList<int> list2 = new ReList<int>();
list2.Add(1);
list2.Add(2);
list2.Add(3);

Console.WriteLine("List2:");
list2.PrintReList();

bool areEqual = list1.Equals(list2);
Console.WriteLine($"Are List1 and List2 equal? {areEqual}");

ReList<int> list3 = (ReList<int>)list1.Clone();

Console.WriteLine("List3 (cloned from List1):");
list3.PrintReList();

list3.Add(4);
Console.WriteLine("List3 after adding an element:");
list3.PrintReList();

areEqual = list1.Equals(list3);
Console.WriteLine($"Are List1 and List3 still equal? {areEqual}");

Console.WriteLine("---------");
foreach (var item in list3)
{
    Console.WriteLine(item);
}
```

### Output
```
List1:
1 2 3 
List2:
1 2 3 
Are List1 and List2 equal? True
List3 (cloned from List1):
1 2 3 
List3 after adding an element:
1 2 3 4 
Are List1 and List3 still equal? False
---------
1
2
3
4
```

## Conclusion
This project provides a custom generic list implementation (`ReList<T>`) with fundamental list operations and demonstrates its usage through a sample program. It can be utilized as a learning resource or integrated into projects requiring custom list functionalities.

---
