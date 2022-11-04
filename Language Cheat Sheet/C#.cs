using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics {
    class Program {

        static void myFunction(int i) {
            Console.Write(i);
        }

        static void myThreadFunctionOne() {
            for (int i = 0; i < 10; i++) {
                Console.Write("Thread One: ");
                myFunction(i);
            }
        }

        static void myThreadFunctionTwo() {
            for (int i = 0; i < 10; i++) {
                Console.Write("Thread Two: ");
                myFunction(i);
            }
        }        

        static void myThreadFunctionThree(int number) {
            for (int i = 0; i < number; i++) {
                Console.Write("Thread Three: ");
                myFunction(i);
            }
        }         

        static void Main(string[] args) {
            // Generic Hello World
                Console.WriteLine("Hello World!");
                
                // Wait for user input
                    Console.ReadKey();

            // Variables
                // Variables are declared with a type and a name
                // Variables are assigned with the = operator
                // Variables are used with the name
                int variables_myInt = 5;
                string variables_myString = "Debbie";
                bool variables_myBool = true;
                double variables_myDouble = 5.5;

                Console.WriteLine("variables_myInt = " + variables_myInt 
                + ", variables_myString = " + variables_myString 
                + ", variables_myBool = " + variables_myBool 
                + ", variables_myDouble = " + variables_myDouble);

            // Strings manipulation
                // Strings are declared with a type and a name
                // Strings are assigned with the = operator
                // Strings are used with the name
                
                // \n is used to insert a new line into a string (called string escape)
                    // The string escape characters are:
                        // \' - single quote (')
                        // \" - double quote (")
                        // \\ - backslash (\)
                        // \0 - null
                        // \a - alert (bell)
                        // \b - backspace - moves the cursor back one space
                        // \f - form feed - new page
                        // \n - new line
                        // \r - carriage return - moves the cursor to the beginning of the line without advancing to the next line.
                        // \t - horizontal tab - moves the cursor to the next tab stop.
                        // \v - vertical tab - moves the cursor down one line.
                        // \xhh - hex value - inserts the character specified by the hexadecimal value hh.
                        // \uhhhh - unicode value - inserts the character specified by the hexadecimal value hhhh.               

                Console.WriteLine("variables_myString.Length = " + variables_myString.Length);
                Console.WriteLine("variables_myString.ToUpper() = " + variables_myString.ToUpper());
                Console.WriteLine("variables_myString.ToLower() = " + variables_myString.ToLower());
                Console.WriteLine("variables_myString.Contains(\"Deb\") = " + variables_myString.Contains("Deb"));
                
                // String concatenation
                    // String concatenation is the process of appending one string to the end of another string
                    // String concatenation is done with the + operator
                    // String concatenation is done with the += operator
                    string strings_myString = "Hello";
                    strings_myString += " World";
                    Console.WriteLine("strings_myString = " + strings_myString);

                // String formatting
                    // String formatting is the process of inserting variables into a string
                    // String formatting is done with the String.Format() method
                    // String formatting is done with the $"" syntax
                    // {} are used to insert variables into a string (called string interpolation)
                    string strings_myString2 = String.Format("{0} {1}", "Hello", "World");
                    Console.WriteLine("strings_myString2 = " + strings_myString2);

                    string strings_myString3 = $"{variables_myString} says hello!";
                    Console.WriteLine("strings_myString3 = " + strings_myString3);                     

                // The string functions are:
                    // Length - returns the length of the string (int) - variables_myString.Length
                    // ToUpper - returns the string in all upper case (string) - variables_myString.ToUpper()
                    // ToLower - returns the string in all lower case (string) - variables_myString.ToLower()
                    // Contains - returns true if the string contains the specified string (bool) - variables_myString.Contains("Deb")
                    // IndexOf - returns the index of the first occurrence of the specified string (int) - variables_myString.IndexOf("Deb")
                    // LastIndexOf - returns the index of the last occurrence of the specified string (int) - variables_myString.LastIndexOf("Deb")
                    // Substring - returns a substring of the specified string (string) - variables_myString.Substring(0, 3)
                    // Trim - returns a string with the leading and trailing whitespace removed (string) - variables_myString.Trim()
                    // Replace - returns a string with the specified string replaced with another string (string) - variables_myString.Replace("Deb", "Debbie")
                    // Split - returns a string array with the specified string split into substrings (string array) - variables_myString.Split(' ')

            // Loops
            // The loop types are:
                // for - repeats a block of code a specified number of times
                // foreach - repeats a block of code for each element in a collection
                // while - repeats a block of code while a condition is true
                // do while - repeats a block of code while a condition is true

            // For loop
                // for loops are used when you know how many times you want to repeat a block of code
                // for loops are declared with the for keyword
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine("i = " + i);
                }

                // alternative syntax
                int p = 0;
                for (; p < 10; p++) {
                    Console.WriteLine("p = " + p);
                }  

            // Foreach
                // foreach loops are used when you want to repeat a block of code for each element in a collection
                // foreach loops are declared with the foreach keyword
                // foreach loops are followed by a collection
                // foreach loops are followed by a variable
                // the variable is assigned the value of the current element in the collection
                List<int> myIntList0 = new List<int>();
                myIntList0.Add(1);
                myIntList0.Add(2);
                myIntList0.Add(3);

                foreach (int number in myIntList0) {
                    Console.WriteLine("number = " + number);
                }

            // While Loop
                // while loops are used when you don't know how many times you want to repeat a block of code
                // while loops are declared with the while keyword
                int j = 0;
                while (j < 10) {
                    Console.WriteLine("j = " + j);
                    j++;
                }

             // Do While Loop
                // do while loops are used when you don't know how many times you want to repeat a block of code
                // do while loops are declared with the do keyword
                // do while loops are similar to while loops except that the condition is checked after the block of code is executed
                // do while loops are used when you want to execute the block of code at least once
                int k = 0;
                do {
                    Console.WriteLine("k = " + k);
                    k++;
                } while (k < 10);           

            // Switch
                // switch statements are used when you want to execute a block of code based on the value of a variable
                // switch statements are declared with the switch keyword
                // switch statements are followed by a variable
                switch (variables_myInt) {
                    case 5:
                        Console.WriteLine("myInt is 5");
                        // break statements are used to exit the switch statement
                        // break statements are optional
                        // break statements are used to prevent the execution of the next case
                        // without a break statement, the execution will continue to the next case
                        break;
                    case 6:
                        Console.WriteLine("myInt is 6");
                        break;
                    // the default case is executed if none of the other cases are true
                    default:
                        Console.WriteLine("myInt is not 5 or 6");
                        break;
                }

            // Conditionals
            // The conditional types are:
                // if - executes a block of code if a condition is true
                // if else - executes a block of code if a condition is true, otherwise executes another block of code
                // else if - executes a block of code if a condition is true, otherwise executes another block of code if a different condition is true
                // else - executes a block of code if none of the other conditions are true
                if (variables_myInt == 5) {
                    Console.WriteLine("myInt is 5");
                } else if (variables_myInt == 6) {
                    Console.WriteLine("myInt is 6");
                } else {
                    Console.WriteLine("myInt is not 5 or 6");
                }

            // Ternary Operator
                // the ternary operator is used to assign a value to a variable based on a condition
                // the ternary operator is declared with the ? operator
                // the ternary operator is followed by a condition
                // the ternary operator is followed by a value if the condition is true
                // the ternary operator is followed by a : operator
                // the ternary operator is followed by a value if the condition is false
                string ternaryOperator_myString = variables_myInt == 5 ? "myInt is 5" : "myInt is not 5";

            // Functions
                // functions are optionally declared with the static keyword (static functions can be called without creating an instance of the class)
                // functions are declared with a return type (void if the function does not return a value)
                // functions are declared with a name 
                // functions are declared with a set of parameters (optional)
                    // functions can be overloaded (multiple functions with the same name but different parameters)
                    // You can overload functions by changing the number of parameters
                    // You can overload functions by changing the type of parameters
                    // You can overload functions by changing the order of parameters if the parameters have different types
                int Add (int a, int b) {
                    return a + b;
                }

                /*int Add (int a, int b, int c) {
                    return a + b + c;
                }*/ // ??????????????????????????????????

                Console.WriteLine("Add(1, 2) = " + Add(1, 2));
                /*Console.WriteLine("Add(1, 2, 3) = " + Add(1, 2, 3));*/ //Ref above

            // Lists
                // Lists are declared with a type and a name
                // Lists are assigned with the = operator
                // Lists are used with the name
                // Lists are indexed with the [] operator
                // Lists are zero based (first element is at index 0)
                // Lists are dynamic size (can be resized)
                // Lists are strongly typed (all elements must be the same type)

                List<int> myIntList = new List<int>();
                myIntList.Add(1);
                myIntList.Add(2);
                myIntList.Add(3);

                Console.WriteLine(
                    "myIntList[0] = " + myIntList[0] 
                + ", myIntList[1] = " + myIntList[1] 
                + ", myIntList[2] = " + myIntList[2]
                );

                List<string> myList = new List<string>();
                myList.Add("myValue");
                myList.Add("myValue2");
                myList.Add("myValue3");

                Console.WriteLine(
                    "myList[0] = " + myList[0] 
                + ", myList[1] = " + myList[1] 
                + ", myList[2] = " + myList[2]
                );

                // The list functions are:
                    // Add - adds an element to the end of the list - myIntList.Add(4) - returns void
                    // Insert - inserts an element at the specified index - myIntList.Insert(0, 0) - returns void
                    // Remove - removes the first occurrence of the specified element - myIntList.Remove(0) - returns void
                    // RemoveAt - removes the element at the specified index - myIntList.RemoveAt(0) - returns void
                    // Clear - removes all elements from the list - myIntList.Clear() - returns void
                    // Contains - returns true if the list contains the specified element - myIntList.Contains(0) - returns bool
                    // IndexOf - returns the index of the first occurrence of the specified element - myIntList.IndexOf(0) - returns int
                    // LastIndexOf - returns the index of the last occurrence of the specified element - myIntList.LastIndexOf(0) - returns int
                    // Sort - sorts the list - myIntList.Sort() - returns void
                    // Reverse - reverses the order of the list - myIntList.Reverse() - returns void
                    // Count - returns the number of elements in the list - myIntList.Count - returns int

            // Arrays
            // - arrays work the same as lists except that they are fixed size
            // - arrays store values in a contiguous block of memory (all elements are stored in a single block of memory) 
            //      which means that arrays are faster than lists
            // - arrays can be multi-dimensional (2D, 3D, etc.)
                // Arrays are declared with a type and a name
                // Arrays are assigned with the = operator
                // Arrays are used with the name
                // Arrays are indexed with the [] operator
                // Arrays are zero based (first element is at index 0)
                // Arrays are fixed size (cannot be resized)
                // Arrays are strongly typed (all elements must be the same type)
                int[] myIntArray = new int[5];
                myIntArray[0] = 1;
                myIntArray[1] = 2;
                myIntArray[2] = 3;

                Console.WriteLine(
                    "myIntArray[0] = " + myIntArray[0] 
                + ", myIntArray[1] = " + myIntArray[1] 
                + ", myIntArray[2] = " + myIntArray[2]
                );

                // Multi-dimensional arrays are declared with a type and a name
                // Multi-dimensional arrays are assigned with the = operator
                // Multi-dimensional arrays are used with the name
                // Multi-dimensional arrays are indexed with the [,] operator
                // Multi-dimensional arrays are zero based (first element is at index 0)
                // Multi-dimensional arrays are fixed size (cannot be resized)
                // Multi-dimensional arrays are strongly typed (all elements must be the same type)
                // The first index is the row index and the second index is the column index (myIntArray[0, 0] is the first element in the first row)
                // You must specify the number of rows in the array beacause the number of columns can be different for each row
                int [][] myMultiDimensionalArray = new int[2][]; 
                // Here we are creating the first row of the array and assigning it to the first element of the array (myMultiDimensionalArray[0]) 
                // and then we are creating the second row of the array and assigning it to the second element of the array (myMultiDimensionalArray[1])
                myMultiDimensionalArray[0] = new int[2];
                myMultiDimensionalArray[1] = new int[3];

                myMultiDimensionalArray[0][0] = 1;
                myMultiDimensionalArray[0][1] = 2;
                myMultiDimensionalArray[1][0] = 3;
                myMultiDimensionalArray[1][1] = 4;
                myMultiDimensionalArray[1][2] = 5;

                Console.WriteLine(
                    "myMultiDimensionalArray[0][0] = " + myMultiDimensionalArray[0][0]
                + ", myMultiDimensionalArray[0][1] = " + myMultiDimensionalArray[0][1]
                + ", myMultiDimensionalArray[1][0] = " + myMultiDimensionalArray[1][0]
                + ", myMultiDimensionalArray[1][1] = " + myMultiDimensionalArray[1][1]
                + ", myMultiDimensionalArray[1][2] = " + myMultiDimensionalArray[1][2]
                );

                // The array functions are:
                    // Length - returns the number of elements in the array - myIntArray.Length - returns int
                    // Sort - sorts the array - myIntArray.Sort() - returns void
                    // Reverse - reverses the order of the array - myIntArray.Reverse() - returns void
                    // Clear - removes all elements from the array - myIntArray.Clear() - returns void
                    // Contains - returns true if the array contains the specified element - myIntArray.Contains(0) - returns bool
                    // IndexOf - returns the index of the first occurrence of the specified element - myIntArray.IndexOf(0) - returns int
                    // LastIndexOf - returns the index of the last occurrence of the specified element - myIntArray.LastIndexOf(0) - returns int

            // Dictionaries
            // - dictionaries do not have a fixed size and can be resized thus they are dynamic
            // - dictionaries are strongly typed (all keys must be the same type and all values must be the same type)
                // dictionaries are used to store key value pairs
                // dictionaries are declared with the Dictionary keyword
                // dictionaries are followed by the type of the key
                // dictionaries are followed by the type of the value
                // dictionaries are followed by the name of the dictionary
                Dictionary<string, string> myDictionary = new Dictionary<string, string>();
                myDictionary.Add("myKey", "myValue");
                myDictionary.Add("myKey2", "myValue2");
                myDictionary.Add("myKey3", "myValue3");

                // dictionaries can be accessed using the key
                Console.WriteLine(
                    "myDictionary[myKey] = " + myDictionary["myKey"] 
                + ", myDictionary[myKey2] = " + myDictionary["myKey2"] 
                + ", myDictionary[myKey3] = " + myDictionary["myKey3"]
                );

                // dictionary functions are:
                    // Add - adds a key value pair to the dictionary - myDictionary.Add("myKey", "myValue") - returns void
                    // Remove - removes the key value pair with the specified key - myDictionary.Remove("myKey") - returns void
                    // Clear - removes all key value pairs from the dictionary - myDictionary.Clear() - returns void
                    // ContainsKey - returns true if the dictionary contains the specified key - myDictionary.ContainsKey("myKey") - returns bool
                    // ContainsValue - returns true if the dictionary contains the specified value - myDictionary.ContainsValue("myValue") - returns bool
                    // Count - returns the number of key value pairs in the dictionary - myDictionary.Count - returns int

            // HashSets
            // - hashsets work like dictionaries but only store the key and not the value 
            // - hashsets store unique values (no duplicates) and are unordered (no index)
                // hashsets are used to store unique values
                // hashsets are declared with the HashSet keyword
                // hashsets are followed by the type of the value
                // hashsets are followed by the name of the hashset
                HashSet<string> myHashSet = new HashSet<string>();
                myHashSet.Add("myValue");
                myHashSet.Add("myValue2");
                myHashSet.Add("myValue3");

                foreach (string value in myHashSet) {
                    Console.WriteLine("value = " + value);
                }

                // hashset functions are:
                    // Add - adds a value to the hashset - myHashSet.Add("myValue") - returns void
                    // Remove - removes the value from the hashset - myHashSet.Remove("myValue") - returns void
                    // Clear - removes all values from the hashset - myHashSet.Clear() - returns void
                    // Contains - returns true if the hashset contains the specified value - myHashSet.Contains("myValue") - returns bool
                    // Count - returns the number of values in the hashset - myHashSet.Count - returns int

            // Stack
            // - a stack is a last in first out data structure which means 
            //      that the last element added to the stack is the first element removed from the stack 
            //      and the first element added to the stack is the last element removed from the stack
            // - a stack stores elements of the same type
                // Stack is used for local variables
                // The stack is not the default memory location for variables
                    // Stack is a LIFO structure
                    // Stack is a fixed size
                    // Stack is fast
                    // Stack is thread safe
                    // Stack is not garbage collected
                    // Stack is used for value types
                    // Stack is used for small objects
                    // Stack is used for short lived objects
                    // Stack is used for objects that are not   
                        // large
                        // complex
                        // long lived
                        // shared
                        // passed by reference
                        // used in a multithreaded environment

                Stack<int> myStack = new Stack<int>();
                myStack.Push(1);
                myStack.Push(2);
                myStack.Push(3);
                myStack.Push(4);

                foreach (var i in myStack) {
                    Console.WriteLine("myStack.Pop() = " + myStack.Pop());
                }

                // stack functions are:
                    // Push - adds an element to the top of the stack - myStack.Push(1) - returns void
                    // Pop - removes and returns the element at the top of the stack - myStack.Pop() - returns int
                    // Peek - returns the element at the top of the stack - myStack.Peek() - returns int
                    // Clear - removes all elements from the stack - myStack.Clear() - returns void
                    // Contains - returns true if the stack contains the specified element - myStack.Contains(1) - returns bool
                    // Count - returns the number of elements in the stack - myStack.Count - returns int
                
                // Heap is used for objects
                // The heap is the default location for objects
                    // Heap is a FIFO structure
                    // Heap is a dynamic size
                    // Heap is slow
                    // Heap is not thread safe
                    // Heap is garbage collected
                    // Heap is used for reference types
                    // Heap is used for large objects
                    // Heap is used for long lived objects
                    // Heap is used for objects that are
                        // large
                        // complex
                        // long lived
                        // shared
                        // passed by reference
                        // used in a multithreaded environment

            // Queues
            // - stores a list of items that are of the same type
            // - a queue does not allow duplicate items
            // - a queue orders items in a first in first out (FIFO) manner which 
            //      means that the first item added to the queue will be the first item removed from the queue 
            //      and the last item added to the queue will be the last item removed from the queue
                // queues are declared with the Queue keyword
                // queues are followed by the type of the value
                // queues are followed by the name of the queue                
                Queue<string> myQueue = new Queue<string>();
                myQueue.Enqueue("myValue");
                myQueue.Enqueue("myValue2");
                myQueue.Enqueue("myValue3");

                foreach (string value in myQueue) {
                    Console.WriteLine("value = " + value);
                }

                // queue functions are:
                    // Enqueue - adds an element to the end of the queue - myQueue.Enqueue("myValue") - returns void
                    // Dequeue - removes and returns the element at the front of the queue - myQueue.Dequeue() - returns string
                    // Peek - returns the element at the front of the queue - myQueue.Peek() - returns string
                    // Clear - removes all elements from the queue - myQueue.Clear() - returns void
                    // Contains - returns true if the queue contains the specified element - myQueue.Contains("myValue") - returns bool
                    // Count - returns the number of elements in the queue - myQueue.Count - returns int      

            // LinkedLists 
            // - links nodes together in a list structure 
            // - each node contains a value and a reference to the next node in the list 
            // - the last node in the list has a reference to null 
            // - the first node in the list is called the head 
            // - the last node in the list is called the tail 
            // - the head and tail are used to traverse the list 
            // - the head is used to traverse the list from the beginning to the end 
            // - the tail is used to traverse the list from the end to the beginning
                // LinkedLists are used to store a list of elements
                // LinkedLists are declared with the LinkedList keyword
                // LinkedLists are followed by the type of the value
                // LinkedLists are followed by the name of the LinkedList
                LinkedList<string> myLinkedList = new LinkedList<string>();
                myLinkedList.AddFirst("myValue");
                myLinkedList.AddFirst("myValue2");
                myLinkedList.AddFirst("myValue3");

                foreach (string value in myLinkedList) {
                    Console.WriteLine("value = " + value);
                }

                // linkedlist functions are:
                    // AddFirst - adds an element to the beginning of the linkedlist - myLinkedList.AddFirst("myValue") - returns void
                    // AddLast - adds an element to the end of the linkedlist - myLinkedList.AddLast("myValue") - returns void
                    // RemoveFirst - removes and returns the element at the beginning of the linkedlist - myLinkedList.RemoveFirst() - returns string
                    // RemoveLast - removes and returns the element at the end of the linkedlist - myLinkedList.RemoveLast() - returns string
                    // Clear - removes all elements from the linkedlist - myLinkedList.Clear() - returns void
                    // Contains - returns true if the linkedlist contains the specified element - myLinkedList.Contains("myValue") - returns bool
                    // Count - returns the number of elements in the linkedlist - myLinkedList.Count - returns int          

            // Classes
                // classes are used to create objects
                // classes are declared with the class keyword
                // classes are followed by the name of the class
                // classes are followed by the class body
                MyClass myExampleClass = new MyClass();
                myExampleClass.myInt = 5;
                myExampleClass.myString = "Hello";
                myExampleClass.myBool = true;
                myExampleClass.myDouble = 5.5;

                Console.WriteLine(
                    "myExampleClass.myInt = " + myExampleClass.myInt 
                + ", myExampleClass.myString = " + myExampleClass.myString 
                + ", myExampleClass.myBool = " + myExampleClass.myBool 
                + ", myExampleClass.myDouble = " + myExampleClass.myDouble
                );

            // Inheritance
                // inheritance allows a class to inherit the properties and methods of another class
                // inheritance is declared with the colon (:) keyword
                // inheritance is followed by the name of the class to inherit from
                // inheritance is followed by the class body
                MyDerivedClass myDerivedClass = new MyDerivedClass();
                myDerivedClass.myInt = 6;
                myDerivedClass.myString = "Derived Hello";
                myDerivedClass.myBool = false;
                myDerivedClass.myDouble = 4.2;
                myDerivedClass.myDerivedInt = 100;
                
                Console.WriteLine(
                    "myDerivedClass.myInt = " + myDerivedClass.myInt 
                + ", myDerivedClass.myString = " + myDerivedClass.myString 
                + ", myDerivedClass.myBool = " + myDerivedClass.myBool 
                + ", myDerivedClass.myDouble = " + myDerivedClass.myDouble 
                + ", myDerivedClass.myDerivedInt = " + myDerivedClass.myDerivedInt
                );

            // Polymorphism
                // polymorphism refers to the ability of an object to take on many forms
                MyDerivedClass myDerivedClass2 = new MyDerivedClass();
                // Overrides the base class method with the derived class method
                myDerivedClass2.myMethod();

            // Object slicing
                // object slicing occurs when a derived class object is assigned to a base class object
                // object slicing occurs when a derived class object is passed as a parameter to a base class method
                MyClass myClass2 = new MyDerivedClass();
                myClass2.myInt = 5;
                myClass2.myString = "Hello";
                myClass2.myBool = true;
                myClass2.myDouble = 5.5;

                Console.WriteLine(
                    "myClass2.myInt = " + myClass2.myInt 
                + ", myClass2.myString = " + myClass2.myString 
                + ", myClass2.myBool = " + myClass2.myBool 
                + ", myClass2.myDouble = " + myClass2.myDouble
                );

            // Interfaces
                // interfaces are used to define a set of methods that a class must implement
                // interfaces are declared with the interface keyword
                // interfaces are followed by the name of the interface
                // interfaces are followed by the interface body
                // interfaces allow for multiple inheritance - a class can inherit from multiple interfaces
                // interfaces do not allow for implementation of methods - only the method signature
                IMyInterface myInterface = new MyDerivedClass();
                myInterface.myInt = 5;
                myInterface.myString = "Hello";
                myInterface.myBool = true;
                myInterface.myDouble = 5.5;

                Console.WriteLine(
                    "myInterface.myInt = " + myInterface.myInt 
                + ", myInterface.myString = " + myInterface.myString 
                + ", myInterface.myBool = " + myInterface.myBool 
                + ", myInterface.myDouble = " + myInterface.myDouble
                );

                myInterface.myMethod();

            // Abstract classes

            // Delegates
                // delegates are used to define a method signature
                // delegates are declared with the delegate keyword
                // delegates are followed by the return type of the method
                // delegates are followed by the name of the delegate
                // delegates are followed by the method signature
                // delegates are used to pass methods as parameters
                MyDerivedClass myDerivedClass12 = new MyDerivedClass();
                myDerivedClass2.myDelegateFunction(myFunction);

                // Func is a delegate that returns a value
                    Func<int, int, int> myLambda22 = delegate (int x, int y) {
                        return x + y;
                    };
                // Action is a delegate that does not return a value
                    Action myLambda23 = delegate () {
                        Console.WriteLine("Hello");
                    };
                // Predicate is a delegate that returns a boolean value
                    Predicate<int> myLambda24 = delegate (int x) {
                        return x > 5;
                    };

            // Exceptions
                // exceptions are used to handle errors
                // exceptions are declared with the try/catch/finally keywords
                try {
                    throw new Exception("This is an exception");
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                } finally {
                    Console.WriteLine("This will always run");
                }

            // Reflection
                // reflection is used to get information about a class at runtime
                Type myType = typeof(MyClass); // or var.GetType();
                Console.WriteLine("myType.Name = " + myType.Name);

                // reflection functions are 
                    // GetProperties - returns an array of properties for the class - myType.GetProperties() - returns PropertyInfo[]
                    // GetMethods - returns an array of methods for the class - myType.GetMethods() - returns MethodInfo[]
                    // GetFields - returns an array of fields for the class - myType.GetFields() - returns FieldInfo[]
                    // GetCustomAttributes - returns an array of custom attributes for the class - myType.GetCustomAttributes() - returns object[]
                    // GetInterfaces - returns an array of interfaces for the class - myType.GetInterfaces() - returns Type[]
                    // GetNestedTypes - returns an array of nested types for the class - myType.GetNestedTypes() - returns Type[]
                    // GetConstructor - returns a constructor for the class - myType.GetConstructor() - returns ConstructorInfo
                    // GetEvent - returns an event for the class - myType.GetEvent() - returns EventInfo
                    // GetMember - returns a member for the class - myType.GetMember() - returns MemberInfo[]
                    // GetNestedType - returns a nested type for the class - myType.GetNestedType() - returns Type

            // Generics
                // generics are used to create classes that can work with any type
                // generics are declared with the angle brackets (<>) keyword
                // generics are followed by the type of the class
                // generics are followed by the class body
                // generics allow for type safety - the compiler will check the type of the object at compile time
                // generics allow for type inference - the compiler will infer the type of the object at compile time
                // generics are not limited to classes - they can be used with methods, interfaces, delegates, and events
                MyGenericClass<int> myGenericClass = new MyGenericClass<int>();
                myGenericClass.Add(1);

                MyGenericClass<string> myGenericClass2 = new MyGenericClass<string>();
                myGenericClass2.Add("Hello");

                // generics constraints 
                    // where - used to restrict the type of the generic - where T : IComparable 
                    // new() - used to restrict the type of the generic to a class that has a default constructor - where T : new()
                    // class - used to restrict the type of the generic to a class - where T : class
                    // struct - used to restrict the type of the generic to a struct - where T : struct
                    // interface - used to restrict the type of the generic to an interface - where T : interface
                    // delegate - used to restrict the type of the generic to a delegate - where T : delegate
                    // base - used to restrict the type of the generic to a base class - where T : base
                    // unmanaged - used to restrict the type of the generic to an unmanaged type - where T : unmanaged
                    // default - used to restrict the type of the generic to a default type - where T : default
                    // nameof - used to restrict the type of the generic to a type name - where T : nameof
                    // typeof - used to restrict the type of the generic to a type - where T : typeof
                    // in - used to restrict the type of the generic to an input type - where T : in
                    // out - used to restrict the type of the generic to an output type - where T : out
                    // ref - used to restrict the type of the generic to a reference type - where T : ref

            // Attributes
                // attributes are used to add metadata to a class
                // attributes are declared with the square brackets ([]) keyword
                // metadata is data about data - it is data that describes other data 
                // - it is not used by the program itself but by other programs or tools that use the program 
                // - it is used to add information to a class that is not part of the class itself
                IMyInterface myInterface2 = new MyDerivedClass();
                var attributes = from t in myInterface2.GetType().GetCustomAttributes(true)
                                where t.GetType() == typeof(MyAtrributeClass)
                                select t;
                
                foreach (var attribute in attributes) {
                    Console.WriteLine("Attribute Name = " + attribute);
                    foreach (var property in attribute.GetType().GetProperties()) {
                        Console.WriteLine("Attribute Property Name = " + property.Name + ", Value = " + property.GetValue(attribute));
                    }
                }

                // functions that can be used with attributes
                    // GetType() - returns the type of the attribute - myAttribute.GetType()
                    // GetProperties() - returns an array of properties for the attribute - attribute.GetType().GetProperties() - returns PropertyInfo[]
                    // GetMethods() - returns an array of methods for the attribute - attribute.GetType().GetMethods() - returns MethodInfo[]
                    // GetFields() - returns an array of fields for the attribute - attribute.GetType().GetFields() - returns FieldInfo[]
                    // GetCustomAttributes() - returns an array of custom attributes for the attribute - attribute.GetType().GetCustomAttributes() - returns object[]
                    // GetInterfaces() - returns an array of interfaces for the attribute - attribute.GetType().GetInterfaces() - returns Type[]
                    // GetNestedTypes() - returns an array of nested types for the attribute - attribute.GetType().GetNestedTypes() - returns Type[]
                    // GetConstructor() - returns a constructor for the attribute - attribute.GetType().GetConstructor() - returns ConstructorInfo
                    // GetEvent() - returns an event for the attribute - attribute.GetType().GetEvent() - returns EventInfo
                    // GetMember() - returns a member for the attribute - attribute.GetType().GetMember() - returns MemberInfo[]
                    // GetNestedType() - returns a nested type for the attribute - attribute.GetType().GetNestedType() - returns Type
                    // GetCustomAttributesData() - returns an array of custom attributes data for the attribute - attribute.GetType().GetCustomAttributesData() - returns CustomAttributeData[]
                    // GetCustomAttributes() - returns an array of custom attributes for the attribute - attribute.GetType().GetCustomAttributes() - returns object[]

                // attribute targets
                    // assembly - used to add metadata to an assembly
                    // module - used to add metadata to a module
                    // type - used to add metadata to a type
                    // method - used to add metadata to a method
                    // property - used to add metadata to a property
                    // field - used to add metadata to a field
                    // event - used to add metadata to an event
                    // parameter - used to add metadata to a parameter
                    // return - used to add metadata to a return value
                    // type parameter - used to add metadata to a type parameter

                // attribute usage
                    // allow multiple - used to allow multiple attributes of the same type
                    // inherited - used to allow the attribute to be inherited by derived classes
                    // valid on - used to specify the targets that the attribute can be used on

                // attribute inheritance
                    // attributes are inherited by derived classes
                    // attributes can be overridden by derived classes

                // attribute reflection
                    // attributes can be retrieved at runtime using reflection

                // attribute parameters
                    // attributes can have parameters 
                    // parameters can be of any type
                    // parameters can be optional - [MyAttributeClass("Hello", Optional = true)]
                    // parameters can be named - [MyAttribute(Name = "Hello")]
                    // parameters can be positional - the order of the parameters is important

            // Lambda Expressions
                // lambda expressions are used to create anonymous methods
                // lambda expressions are declared with the lambda operator (=>) keyword
                // lambda expressions are followed by the parameters
                // lambda expressions are followed by the body
                // lambda expressions are used with delegates
                // The first is the return type, the second and third is the parameter type
                Func<int, int, int> myLambda = (x, y) => x + y;
                Console.WriteLine("myLambda(1, 2) = " + myLambda(1, 2));

                // Anonmyous lambda function
                Func<int, int, int> myLambda2 = delegate (int x, int y) {
                    return x + y;
                };

                // or 
                Func<int, int, int> myLambda3 = (x, y) => {
                    return x + y;
                };

                // lambda expression without parameters
                Func<int> myLambda4 = () => 1;

            // LINQ
                // LINQ is used to query data
                // LINQ is used to query data from a variety of sources including collections, databases, XML, and web services
                // LINQ stands for Language Integrated Query 
                // LINQ standardised the query syntax for querying data from a variety of sources 
                //  to allow for a single syntax to be used and prevent the need to learn a new syntax for each data source

                // LINQ supports three different query syntaxes
                    // method syntax - used to query data using methods - myCollection.Where(x => x > 5).Select(x => x * 2)
                    // query syntax - used to query data using keywords - from x in myCollection where x > 5 select x * 2
                    // extension syntax - used to query data using extension methods - myCollection.Where(x => x > 5).Select(x => x * 2)

                // LINQ supports two different query operators 
                    // standard query operators - used to query data using standard operators
                        // where - used to filter data - myCollection.Where(x => x > 5)
                        // select - used to select data - myCollection.Select(x => x * 2)
                        // group - used to group data - myCollection.GroupBy(x => x > 5)
                        // join - used to join data - myCollection.Join(myCollection2, x => x, y => y, (x, y) => x + y)
                        // orderby - used to order data - myCollection.OrderBy(x => x)
                        // skip - used to skip data - myCollection.Skip(5)
                        // take - used to take data - myCollection.Take(5)
                        // distinct - used to remove duplicates - myCollection.Distinct()
                        // union - used to combine data - myCollection.Union(myCollection2)
                        // intersect - used to intersect data - myCollection.Intersect(myCollection2)
                        // except - used to exclude data - myCollection.Except(myCollection2)
                        // all - used to check if all data matches a condition - myCollection.All(x => x > 5)
                        // any - used to check if any data matches a condition - myCollection.Any(x => x > 5)
                        // contains - used to check if data contains a value - myCollection.Contains(5)
                        // count - used to count data - myCollection.Count()
                        // first - used to get the first item - myCollection.First()
                        // last - used to get the last item - myCollection.Last()
                        // max - used to get the maximum value - myCollection.Max()
                        // min - used to get the minimum value - myCollection.Min()
                        // sum - used to get the sum of values - myCollection.Sum()
                        // average - used to get the average of values - myCollection.Average()
                        // aggregate - used to aggregate data - myCollection.Aggregate((x, y) => x + y)
                        // element at - used to get an item at a specific index - myCollection.ElementAt(5)
                        // element at or default - used to get an item at a specific index or a default value - myCollection.ElementAtOrDefault(5)
                        // sequence equal - used to check if two sequences are equal - myCollection.SequenceEqual(myCollection2)
                        // default if empty - used to return a default value if the sequence is empty - myCollection.DefaultIfEmpty()
                        // reverse - used to reverse the sequence - myCollection.Reverse()
                        // cast - used to cast the sequence - myCollection.Cast<int>()
                        // of type - used to filter the sequence - myCollection.OfType<int>()
                        // as enumerable - used to convert the sequence to an enumerable - myCollection.AsEnumerable()
                        // as queryable - used to convert the sequence to a queryable - myCollection.AsQueryable()
                        // to array - used to convert the sequence to an array - myCollection.ToArray()
                        // to list - used to convert the sequence to a list - myCollection.ToList()
                        // to dictionary - used to convert the sequence to a dictionary - myCollection.ToDictionary(x => x, x => x * 2)
                        // to lookup - used to convert the sequence to a lookup - myCollection.ToLookup(x => x, x => x * 2)
                        // as parallel - used to convert the sequence to a parallel query - myCollection.AsParallel()
                        // as ordered - used to convert the sequence to an ordered query - myCollection.AsOrdered()
                        // as sequential - used to convert the sequence to a sequential query - myCollection.AsSequential()
                        // concat - used to concatenate two sequences - myCollection.Concat(myCollection2)
                        // empty - used to create an empty sequence - Enumerable.Empty<int>()
                        // range - used to create a sequence of numbers - Enumerable.Range(1, 5)
                        // repeat - used to create a sequence of repeated values - Enumerable.Repeat(5, 5)
                        // zip - used to zip two sequences - myCollection.Zip(myCollection2, (x, y) => x + y)

                    // query comprehension operators - used to query data using comprehension operators
                        // from - used to specify the data source - from x in myCollection
                        // let - used to assign a variable - let x = 5
                        // where - used to filter data - where x > 5
                        // join - used to join data - join x in myCollection on y in myCollection2 equals x + y
                        // group - used to group data - group x by x > 5
                        // orderby - used to order data - orderby x
                        // select - used to select data - select x * 2
                        // into - used to create a group - into x
                        // on - used to specify the join condition - on x equals y
                        // equals - used to specify the join condition - equals x + y
                        // by - used to specify the group condition - by x > 5
                        // ascending - used to specify the order - ascending
                        // descending - used to specify the order - descending

                // LINQ supports two different query expressions
                    // from - used to query data using the from keyword - from x in myCollection
                    // let - used to query data using the let keyword - let x = 5

                // LINQ supports two different query clauses
                    // where - used to query data using the where keyword - where x > 5
                    // select - used to query data using the select keyword - select x * 2

                List<int> myIntList2 = new List<int>();
                myIntList2.Add(1);
                myIntList2.Add(2);
                myIntList2.Add(3);

                var myIntList3 = from i in myIntList2
                                where i > 1
                                select i;

                foreach (var i in myIntList3) {
                    Console.WriteLine("LinQ List = " + i);
                }

            // Enums
                // Enums are used to define a set of named constants
                // Enums are useful for constants that are used in multiple places
                MyEnum myEnum = MyEnum.MyEnumValue1;
                Console.WriteLine("myEnum = " + myEnum);
                // By default, the value is the index of the enum
                Console.WriteLine("myEnum Value = " + (int)myEnum); 


            // Extension Methods
                // Console.WriteLine("5 is even = " + 5.IsEven());

            // Nullable Types
                // Nullable types are used to represent a value that can be null
                // Nullable types are defined using the ? operator or the Nullable<T> type

                // ?? is the null coalescing operator
                Nullable<int> myNullableIntOne = null;

                // or

                int? myNullableIntTwo = null;

                // or

                // IF the var being assigned is nullable and is null then assign it this value
                int myNullableIntThree = myNullableIntTwo ?? 0;

                // You can also use it to throw an exception if the value is null
                int myNullableIntFour = myNullableIntTwo ?? throw new ArgumentNullException("{0} is null", nameof(myNullableIntTwo));

                // If you try to print a null it will just be skipped
                Console.WriteLine(
                    "Will be skipped" + myNullableIntFour + " " 
                + myNullableIntThree + " " 
                + myNullableIntTwo + " " 
                + myNullableIntOne
                );

                // ??= is the null coalescing assignment operator
                // int myNullableIntFive ??= 0;

                // You can do the following to check if a nullable
                // Cant use it on int? because it is already nullable
                string myString = "Gerald";
                Console.WriteLine(myString?.ToString());

            // Anonymous Types
                // Anonymous types are used to create an object without having to define a type
                // Anonymous types are useful for returning multiple values from a method
                var myAnonymousType = new { myInt = 5, myString = "Hello" };
                Console.WriteLine(
                    "myAnonymousType.myInt = " + myAnonymousType.myInt 
                + ", myAnonymousType.myString = " + myAnonymousType.myString
                ); 

                // Or combine with LINQ

                var myList3 = new List<MyClass>() {
                    new MyClass() { myInt = 1, myString = "Hello", myBool = true, myDouble = 6.9 },
                    new MyClass() { myInt = 2, myString = "It's", myBool = false, myDouble = 4.2 },
                    new MyClass() { myInt = 3, myString = "Me", myBool = true, myDouble = 6.6 }
                };

                    // The properties within the anonymous type are read only
                    var myAnonymousType2 = from i in myList3
                                        where i.myInt > 1
                                        select new { theInt = i.myInt, theString = i.myString };

                    foreach (var i in myAnonymousType2) {
                        Console.WriteLine(
                            "myAnonymousType2.theInt = " + i.theInt 
                        + ", myAnonymousType2.theString = " + i.theString
                        );
                    }

            // Dynamic Types
                // Dynamic types are used when you don't know the type of the variable
                // Dynamic types are not type safe (you can assign any type to it)
                dynamic myDynamicType = 5;
                // The compiler will not know the type of the variable and thus 
                // will not know what methods or properties are available
                // and will not throw an error or provide intellisense
                myDynamicType = "Hello";
                Console.WriteLine("myDynamicType = " + myDynamicType);

            // Parallel Programming
                // Parallel Programming is used to run multiple tasks at the same time on different threads

                // Parallel.For - used to run a for loop in parallel
                // The first parameter is the starting index, the second is the ending index, and the third is the action to perform
                Parallel.For(0, 10, i => {
                    Console.WriteLine("Parallel i = " + i);
                });

                // or 

                // Parallel.ForEach - used to run a foreach loop in parallel
                // The first parameter is the collection, and the second is the action to perform
                Parallel.ForEach(myIntList2, i => {
                    Console.WriteLine("Parallel2 i = " + i);
                });

                // or 

                // Parallel.Invoke - used to run multiple actions in parallel
                // The parameters are the actions to perform, and the actions can be anonymous methods, lambda expressions, or named methods
                Parallel.Invoke(
                    () => {
                        Console.WriteLine("Parallel3");
                    },
                    () => {
                        Console.WriteLine("Parallel4");
                    }
                );

                // or 

                // Parallel LINQ
                var myIntList4 = from i in myIntList2.AsParallel()
                                where i > 1
                                select i;

                foreach (var i in myIntList4) {
                    Console.WriteLine("Parallel LinQ List = " + i);
                }

            // Asynchronous Programming
                // Synchonous code will run from top to bottom and wait for each task to finish before moving on
                // Asynchronous code will run in the background and will not block the main thread
                
                // Async and Await are used to run a task asynchronously
                // Async - used to define a method as asynchronous
                // Await - used to wait for an asynchronous task to finish
                Task.Run(() => {
                    Console.WriteLine("Async Task");
                });

                // or

                // Async and Await can be used with a lambda expression
                Task.Run(async () => {
                    await Task.Delay(1000);
                    Console.WriteLine("Async Task2");
                });

                // Task - used to run a task asynchronously and return a value when the task is finished
                // The first parameter is the action to perform, and the second is the cancellation token
                Task<int> myTask = Task.Run(() => {
                    return 5;
                }, CancellationToken.None);

                //  cancellationTokens
                // CancellationToken.None - used to not cancel the task
                // CancellationToken.Cancel - used to cancel the task
                // CancellationTokenSource - used to create a cancellation token 
                // - the token can be cancelled by calling the Cancel method on the CancellationTokenSource

            // Concurrency
                // Concurrency is when multiple threads are accessing the same resource at the same time
                // Concurrency is not thread safe
                // Threads are not guaranteed to run in the order they are started
                // Threads are not guaranteed to run on the same thread
                // Threads are not guaranteed to run at the same time

                // Thread Safety
                // Thread safety is when multiple threads can access the same resource at the same time
                // Thread safety is achieved by using locks
                // Locks are used to prevent multiple threads from accessing the same resource at the same time

                // Deadlocks
                // Deadlocks are when two or more threads are waiting for each other to finish
                // Deadlocks are caused by locks

                Thread myThread = new Thread(() => {
                    Console.WriteLine("Hello");
                });

                myThread.Start();

                // or 

                Thread myThread2 = Thread.CurrentThread;
                myThread2.Name = "My Thread";
                Console.WriteLine("myThread2.Name = " + myThread2.Name);   

                Thread myThreadRunningFunction = new Thread(myThreadFunctionOne);
                Thread myThreadRunningFunction2 = new Thread(myThreadFunctionTwo);  

                // You have to start the thread to run the function
                myThreadRunningFunction.Start();
                myThreadRunningFunction2.Start();

                // To pass parameters to a thread function you use a lambda expression
                int myThreadInt = 5;
                Thread myThreadRunningFunction3 = new Thread(() => {
                    myThreadInt = 10;
                    myThreadFunctionThree(myThreadInt);
                });

                myThreadRunningFunction3.Start();

                // Thread methods and properties 
                    // Thread.CurrentThread - used to get the current thread  - Thread.CurrentThread.Name = "My Thread"; - returns a Thread object
                    // Thread.IsAlive - used to check if the thread is still running - Thread.IsAlive(); - returns a boolean
                    // Thread.Join - used to wait for a thread to finish - Thread.Join(); - returns void
                    // Thread.Sleep - used to pause the thread for a specified amount of time - Thread.Sleep(1000); - returns void
                    // Thread.Start - used to start the thread - Thread.Start(); - returns void
                    // Thread.Suspend - used to suspend the thread - Thread.Suspend(); - returns void
                    // Thread.Resume - used to resume the thread - Thread.Resume(); - returns void
                    // Thread.Abort - used to abort the thread - Thread.Abort(); - returns void
                    // Thread.Interrupt - used to interrupt the thread - Thread.Interrupt(); - returns void
                    // Thread.Priority - used to get or set the priority of the thread - Thread.Priority = ThreadPriority.Highest; - returns a ThreadPriority enum
                    // Thread.Name - used to get or set the name of the thread - Thread.Name = "My Thread"; - returns a string
                    // Thread.ManagedThreadId - used to get the id of the thread
                    // Thread.ThreadState - used to get the state of the thread - Thread.ThreadState; - returns a ThreadState enum
                    // Thread.GetDomain - used to get the domain of the thread - Thread.GetDomain(); - returns a AppDomain object
                    // Thread.GetDomainID - used to get the domain id of the thread - Thread.GetDomainID(); - returns an int
                    // Thread.GetProcess - used to get the process of the thread - Thread.GetProcess(); - returns a Process object
                    // Thread.GetProcessID - used to get the process id of the thread - Thread.GetProcessID(); - returns an int
                    // Thread.GetApartmentState - used to get the apartment state of the thread - Thread.GetApartmentState(); - returns an ApartmentState enum
                    // Thread.GetCompressedStack - used to get the compressed stack of the thread - Thread.GetCompressedStack(); - returns a CompressedStack object
                    // Thread.GetExecutionContext - used to get the execution context of the thread - Thread.GetExecutionContext(); - returns an ExecutionContext object
                    // Thread.GetExecutionContextReader - used to get the execution context reader of the thread - Thread.GetExecutionContextReader(); - returns an ExecutionContextReader object
                    // Thread.GetException - used to get the exception of the thread - Thread.GetException(); - returns an Exception object
                    // Thread.GetMaxStackSize - used to get the max stack size of the thread - Thread.GetMaxStackSize(); - returns an int
                    // Thread.GetNativeHandle - used to get the native handle of the thread - Thread.GetNativeHandle(); - returns an IntPtr
                    // Thread.GetNewManagedId - used to get the new managed id of the thread - Thread.GetNewManagedId(); - returns an int
                    // Thread.GetThreadContext - used to get the thread context of the thread - Thread.GetThreadContext(); - returns a ThreadContext object

            // Environment
                // Environment is a static class that contains information about the current environment
                Console.WriteLine("Environment.OSVersion = " + Environment.OSVersion);
                Console.WriteLine("Environment.MachineName = " + Environment.MachineName);
                Console.WriteLine("Environment.ProcessorCount = " + Environment.ProcessorCount);
                Console.WriteLine("Environment.Version = " + Environment.Version);
                Console.WriteLine("Environment.UserName = " + Environment.UserName);
                Console.WriteLine("Environment.UserDomainName = " + Environment.UserDomainName);
                Console.WriteLine("Environment.WorkingSet = " + Environment.WorkingSet);

            // Garbage Collections & Memory Management
                // Garbage collection is the process of freeing up memory that is no longer being used
                // Garbage collection is done by the CLR
                    // The CLR is the Common Language Runtime and is the runtime environment for .NET
                // Garbage collection is done automatically
                GC.Collect();

            // Unmanaged Code & Unsafe Code
                // Pointers are used to access the memory address of a variable
                // Pointers are not type safe
                // Pointers are not garbage collected
                // Pointers are not used in C# but are used in C++ and C
                    // You can use pointers in C# but you have to use the unsafe keyword in the class definition
                    /* unsafe {
                        int myInt = 5;
                        int* myIntPtr = &myInt;
                        Console.WriteLine("myIntPtr = " + myIntPtr);
                    } */

                    // Calling a class function that uses pointers
                    // MyUnsafeClass myUnsafeClass = new MyUnsafeClass();
                    // myUnsafeClass.myUnsafeFunction();            

                    // MyClass myClass6 = new MyClass();
                    // myClass6.myInt = 5;
                    // myClass6.myString = "Hello";
                    // myClass6.myBool = true;
                    // myClass6.myDouble = 5.5;

                    // unsafe {
                    //     MyClass* myClass7 = &myClass6;
                        //     Console.WriteLine(
                        //    "myClass7->myInt = " + myClass7->myInt 
                        // + ", myClass7->myString = " + myClass7->myString 
                        // + ", myClass7->myBool = " + myClass7->myBool 
                        // + ", myClass7->myDouble = " + myClass7->myDouble
                        // );
                    // } 

            // Native interoperability (c++ example)


        }

        // // Extension Methods
        // public static class MyExtensions {
        //     public static bool IsEven(this int myInt) => myInt % 2 == 0;
        // }

        // Unsafe class for unmanaged code, pointers and native interoperability
        /*unsafe class MyUnsafeClass {
            public void MyUnsafeMethod() {
                int myInt = 5;
                int* myIntPtr = &myInt;
                Console.WriteLine("myIntPtr = " + myIntPtr);
            }
        }*/

        // Enums
        // Enums are used to define a set of named constants
        enum MyEnum {
            MyEnumValue1,
            MyEnumValue2,
            MyEnumValue3
        }

        // Classes
        // Classes are used to define a new data type that can contain data and methods (functions)
        // Classes are reference types and are stored on the heap (managed memory)
        // Classes are garbage collected and are automatically cleaned up when they are no longer being used
        // Classes are used to create objects (instances of the class)
        // Classes are defined using the class keyword and the class name is PascalCase (MyClass) and the class name should be singular (MyClass, not MyClasses) 
        //  and the class name should be a noun (MyClass, not MyAction)
        public class MyClass : IMyInterface{
            public MyClass() {
                Console.WriteLine("MyClass Constructor");
            }

            ~MyClass() {
                Console.WriteLine("MyClass Destructor");
            }

            public void myMethod() {
                Console.WriteLine("MyClass.myMethod()");
            }

            public int myInt;
            public string myString;
            public bool myBool;
            public double myDouble;

            int IMyInterface.myInt { 
                /*
                * You can do either of the following:
                * 1. get => myInt;
                * 2. get { return myInt; }
                * 3. get { return this.myInt; }
                * 4. get { return ((IMyInterface)this).myInt; }
                * 5. get { return ((MyClass)this).myInt; }
                *
                * However if you implement {} instead of => 
                * then you must do {} for both get and set.
                */
                get => myInt; 
                set => myInt = value; 
            }
            string IMyInterface.myString { 
                // => implements standard getters and setters
                get => myString; 
                set => myString = value; 
            }
            bool IMyInterface.myBool { 
                get => myBool; 
                set => myBool = value; 
            }
            double IMyInterface.myDouble { 
                get => myDouble; 
                set => myDouble = value; 
            }
        }

        // Derived Classes
        // Derived classes are classes that inherit from a base class
        // Derived classes are used to define a new data type that can contain data and methods (functions) and can also inherit data and methods from a base class
        // Derived classes are reference types and are stored on the heap (managed memory) and are garbage collected and are automatically cleaned up when they are no longer being used
        // Derived classes are used to create objects (instances of the class) and can also be used to create objects (instances of the class) of the base class
        // Derived classes are defined using the class keyword and the class name is PascalCase (MyDerivedClass) and the class name should be singular (MyDerivedClass, not MyDerivedClasses)
        public class MyDerivedClass : MyClass {
            public MyDerivedClass() {
                Console.WriteLine("MyDerivedClass Constructor");
            }
            public int myDerivedInt;
            public void myMethod() {
                Console.WriteLine("MyDerivedClass.myMethod()");
            }
            public delegate void myDelegate(int i);
            public void myDelegateFunction(myDelegate objDelegate) {
                Console.WriteLine("myDelegateFunction : ");
                objDelegate(5);
            }
        }

        //Generic Classes
        // Generic classes are classes that can be used with any data type
        // Generic classes are used to define a new data type that can contain data and methods (functions) and can also be used with any data type
        // Generic classes are reference types and are stored on the heap (managed memory) and are garbage collected
        // Generic classes work by using a placeholder for the data type (T) and then when the class is used the data type is specified
        // Generic classes should be carefully used because they can cause performance issues and can make the code harder to read and understand

        // Generic classes may also cause boxing and unboxing issues 
        // - boxing is when a value type is converted to an object reference type 
        //  and unboxing is when an object reference type is converted to a value type

        // - A value type is a type that is stored on the stack (unmanaged memory)
        // - and an object reference type is a type that is stored on the heap (managed memory)

        // - An object reference type is a class, interface, delegate, array, string, dynamic type, nullable type, tuple type, pointer type, function pointer type
        // -and a value type is a struct or enum or primitive type (int, double, bool, etc.) 
        public class MyGenericClass<T> {
            public void Add(T input){
                Console.WriteLine("MyGenericClass.Add() : " + input);
            }
        }

        //Attributes (Attributes are used to add metadata to a class, method, property, etc.)
        [AttributeUsage(AttributeTargets.Interface)] // Restricting the use of this attribute to interfaces
        public class MyAtrributeClass : Attribute {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        // Interfaces
        // Interfaces are used to define a new data type that can contain only methods (functions) and properties
        // Interfaces are reference types and are stored on the heap (managed memory) and are garbage collected
        // Interface advantage is that you can use the interface to define a set of methods and properties that a class must implement (inherit) 
        //  and then you can use the interface to create objects (instances of the class) and the objects (instances of the class) will be of the class type
        [MyAtrributeClass(Name = "MyInterface", Description = "MyInterface Description")]
        interface IMyInterface {
            public void myMethod();

            public int myInt { get; set; }
            public string myString { get; set; }
            public bool myBool { get; set; }
            public double myDouble { get; set; }
        }
    }
}