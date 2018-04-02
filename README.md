# Higher Performance Computing in C# (HPCsharper)

High performance C#/.NET generic algorithms. Builds on top of the HPCsharp NuGet package, and takes it to the next level of performance.
Parallel implementation of algorithms:
- Parallel Merge Sort (Stable): Array, List
- Parallel Merge (Stable): Array, List
- Parallel Copy: Array to Array, List to Array
- Binary Search: Array, List

*Method*|*Collection*|*vs Array.Sort*|*vs List.Sort*|*vs Linq*|*CPU Cores*|*Break Even*
--- | --- | --- | --- | --- | --- | ---
Parallel Merge Sort|Array|2X-3X faster|||4|64K
Parallel Merge Sort|List||2X-3X faster||4|
Parallel Merge Sort|Array|3.5X-5X faster|||6|
Parallel Merge Sort|List||2.5X-4.5X faster||6|
Parallel Merge|Array||2.5X-4.5X faster||4|
Parallel Merge|List||1.5X-2.4X faster||4|

*Method*|*Collection*|*Parallel*|*Performance*|*Break Even*
--- | --- | --- | --- | ---
Parallel Copy|Array to Array|1.7X-2.7X faster|1.3 GigaInts/sec|
Parallel CopyTo|List to Array|1.7X-2.5X faster|1.3 GigaInts/sec|
Parallel ToArray|List to Array|??X faster||

- More to come...

See HPCsharperExample folder in this repo for usage examples - a complete VisualStudio 2017 solution provided.

Available at:
https://foostate.com/

For details on the motivation see blog:
https://duvanenko.tech.blog/2018/03/03/high-performance-c/

# Examples

	int[] arrayOne = { 21, 43, 16, 5, 54, 3 };
	int[] arrayTwo = { 21, 43, 16, 5, 54, 3 };

	arrayOne.SortMergePar();
	Array.Sort(arrayTwo);

	if (arrayOne.SequenceEqual(arrayTwo))
		Console.WriteLine("Sorted results are equal");
	else
		Console.WriteLine("Sorted results are not equal!");





[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=LDD8L7UPAC7QL)
