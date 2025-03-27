/*

1. What type would you choose for the following “numbers”?
A person’s telephone number - string
A person’s height           - float / double
A person’s age              - byte / int
A person’s gender (Male, Female, Prefer Not To Answer) - enum
A person’s salary           - decimal
A book’s ISBN               - string
A book’s price              - decimal
A book’s shipping weight    - float/double
A country’s population      - long
The number of stars in the universe - ulong
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business) - ushort

2. What are the difference between value type and reference type variables? What is
boxing and unboxing?

The value type:
- is stored directly in the stack
- copies the actual value when assigned / passed
- initialized to a default value
- Has faster performance than ref

The reference type:
- is stored in the heap with a reference in the stack
- copies the address when assigned
- initialized to null
- has slower performance due to heap allocation and garbage collection.

Boxing is the process of converting a value type to a reference type.
Unboxing is the proces of converting a reference type back to a value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET

Managed resource is a resource that is managed by the .NET runtime's garbage collector.
Ex: Memory allocated for objects on heap

Unmanaged resource is one that is not managed by the .NET runtime and must be released by the developer.
Ex: File handles, database connections,...

4. Whats the purpose of Garbage Collector in .NET?
It is responsible for managing the allocation and releasing memory for managed objects to ensure efficient use and prevent
memory leaks.

5. What happens when you divide an int variable by 0?
It throws an exception of dividebyzero

6. What happens when you divide a double variable by 0?
It won't throw an exception, will give infinity/-infinity/NaN based on numerator.

7. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
Without checked: The value wraps around (e.g., exceeding int.MaxValue wraps to int.MinValue).
With checked: A System.OverflowException is thrown.

8. What is the difference between x = y++; and x = ++y;?
x = y++ is post-increment: y is assigned to x and then incremented.
x = ++y means y is incremented first, then assigned to x.

9. What is the difference between break, continue, and return when used inside a loop
statement?
Break exits the loop immediately
continue skips the current iteration and moves to the next
return exits the loop and the method.

10. What are the three parts of a for statement and which of them are required?
- Initialization
- Condition
- Iteration

none of the parts are required but they all are suggested to have to prevent an infinite loop happening.

11. What is the difference between the = and == operators?
=: assignment operator
==: equality operator to compare

12. Does the following statement compile? for ( ; true; ) ;
Yes

13. What does the underscore _ represent in a switch expression?
It's a default case in a switch expression.

14. What interface must an object implement to be enumerated over by using the foreach
An object must implement the IEnumerable or IEnumerable<T> interface to be used in a foreach loop.

*/