/*
1. When to use String vs. StringBuilder in C# ?
- String for when you're working with immutable strings.
- StringBuilder is when you need to perform multiple modifications to a string (append, insert, remove,...).

2. What is the base class for all arrays in C#?
System.Array

3. How do you sort an array in C#?
We can use Array.Sort() method.

4. What property of an array object can be used to get the total number of elements in
an array?
We can use the Length property.

5. Can you store multiple data types in System.Array?
No.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
- CopyTo(): Copies the elements of the array into another existing array starting at a specified index.
- Clone(): Creates a shallow copy of the array and returns a new array object.
*/