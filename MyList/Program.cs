using MyList;

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

areEqual = list1.Equals(list3);
Console.WriteLine($"Are List1 and List3 equal? {areEqual}");

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