# Higher Performance Computing in C# (HPCsharper)

High performance C#/.NET generic algorithms. Takes HPCsharp free library to the next level of performance.
Parallel implemention of variety of algorithms:
- Parallel Merge Sort (Stable): Array, List
- Parallel Merge (Stable): Array, List
- Parallel Copy: Array to Array, List to Array, List to List

*Method*|*Collection*|*Parallel vs Array.Sort*|*Parallel vs List.Sort*|*Parallel vs Linq*|*Number of Cores*
--- | --- | --- | --- | --- | ---
Sort|Array|2X-3X faster|||4 cores
Sort|List||2X-3X faster||4 cores
Sort|Array|3.5X-5X faster|||6 cores
Sort|List||2.5X-4.5X faster||6 cores

*Method*|*Collection*|*Parallel*
--- | --- | ---
CopyTo|List to Array|2-2.5X faster

- More to come...

See HPCsharperExample folder in this repo for usage examples - a complete VisualStudio 2017 solution provided.

Available at:
https://foostate.com/

For details on the motivation see blog:
https://duvanenko.tech.blog/2018/03/03/high-performance-c/





[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=LDD8L7UPAC7QL)
