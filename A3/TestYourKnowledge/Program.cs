/*

1. What are the six combinations of access modifier keywords and what do they do? 
public: Accessible from anywhere.
private: Accessible only within the containing class.
protected: Accessible within the containing class and derived classes.
internal: Accessible within the same assembly.
protected internal: Accessible within the same assembly or derived classes.
private protected: Accessible within the containing class or derived classes in the same assembly.

2. What is the difference between the static, const, and readonly keywords when applied to
a type member?
- static: Belongs to the class, not an instance. Shared across all instances.
- const: Compile-time constant. Value cannot change and must be assigned at declaration.
- readonly: Runtime constant. Value can only be assigned during declaration or in the constructor

3. What does a constructor do?
- Initializes an object when it is created.

4. Why is the partial keyword useful?
- Allowing a class / struct to be split across multiple files.

5. What is a tuple?
- Data structure that hold muiltiple values of different type.

6. What does the C# record keyword do?
- Defines a reference type

7. What does overloading and overriding mean?
- Overloading: defining multiple methods with the same name but different parameters.
- Overriding: providing a new implementation for a virtual / abstract method in a derived class. 

8. What is the difference between a field and a property?
- Field: Variable that holds data directly
- Property: A member that provides controlled access to a field.

9. How do you make a method parameter optional?
- Using a default value

10. What is an interface and how is it different from abstract class?
- Interface must implement all members.
- Abstract class can have both abstract and concrete members.

11. What accessibility level are members of an interface?
- Public

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
- True

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
- True

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
- True 

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
- False

16. True/False. Normal (non-abstract) methods can be used in an abstract class.
- True

17. True/False. Derived classes can override methods that were virtual in the base class. 
- True

18. True/False. Derived classes can override methods that were abstract in the base class. 
- True

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.
- False

20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
- False

21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
- True

22. True/False. A class can have more than one base class.
- False

23. True/False. A class can implement more than one interface.
- True