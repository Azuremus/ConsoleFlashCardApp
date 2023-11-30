using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPracticeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Questions = new Dictionary<string, string>()
            {
                // Chapter 3
                {"q3.1", " Which of the following have the capacity to display formatted data from an interpolated string? " },
                {"q3.2"," A declaration may only declare one variable at a time. " },
                {"q3.3"," Namespaces group various C# features into related categories. " },
                {"q3.4"," Variable names correspond to locations in the computer's memory. " },
                {"q3.5"," Statements in C# end with: " },
                {"q3.6"," How are console apps displayed? " },
                {"q3.7"," Which of the following represents multiplication? " },
                {"q3.8"," Arithmetic expressions in C# must be written in straight-line form. " },
                {"q3.9"," Where can't you see errors? " },
                {"q3.10"," Every variable has a  . " },
                {"q3.11"," C# is case insensitive, therefore an identifier named Pencil is the same as one named pencil. " },
                {"q3.12"," An assignment statement is evaluated from left to right. " },
                {"q3.13"," _________ are violations of language rules. " },
                {"q3.14"," When a value is placed in a memory location, the previous value in that location is moved to the " +
                "\nnext available location in memory. " },
                {"q3.15"," How can you produce the following results in one line of code? \nWelcome \nto \nC# \nProgramming! " },
                {"q3.16"," Interpolation expressions are enclosed in square brackets ([]). " },
                {"q3.17","What does the following statement display? \nConsole.WriteLine( \n$\"{\"Welcome to \"}\\n{\"C# Programming!\"}\"); " },
                {"q3.18"," Files called assemblies are packaging units for code in C#. " },
                {"q3.19"," \"\\\" is known as an escape sequence. " },
                {"q3.20"," The process of reading from a memory location is nondestructive. " },
                {"q3.21"," Binary operators require two operands. " },
                {"q3.22"," Using redundant parentheses in mathematical expressions may cause errors. " },
                {"q3.23"," Special characters can be inserted in comments that affect how the program executes. " },
                {"q3.24"," A declaration may declare only one variable at a time. " },
                {"q3.25"," The fractional part in integer division is stored in a variable declared automatically at run-time. " },
                {"q3.26"," The _________ statement allows a program to make a decision based on the truth or falsity of some " +
                "\ncondition. " },
                {"q3.27"," The console window is called the command prompt. " },
                {"q3.28"," Concatenation is the process that enables a string and another string or a value of another data " +
                "\ntype to be combined to form a new string. " },
                {"q3.29"," The Parameter Info window indicates how many versions of the selected method are available. " },
                {"q3.30"," It's good practice to fit as many statements as possible on a single line. " },
                {"q3.31"," A __________ directs a user to take a specific action. " },
                {"q3.32"," What does IntelliSense help you do? " },
                {"q3.33"," The \"\\t\" escape sequence moves the screen cursor to the top of the screen. " },
                {"q3.34"," Syntax errors are not identified before you attempt to compile a C# program using Visual Studio 2012. " },
            
                // Chapter 4
                {"q4.1","Consider the code:\r\nConsole.WriteLine($\"Initial name is: {myAccount.GetName()}\");\r\nWhich method is called first? " },
                {"q4.2"," Which of the following statements is false? " },
                {"q4.3","Consider the code (in class Account):\r\npublic string GetName()\r\n{\r\nreturn name;\r\n}\r\nWhich of the following statements is false? " },
                {"q4.4"," Which of the following statements is false? " },
                {"q4.5","Which of the following properly declares an auto-implemented Name property of type string? " },
                {"q4.6"," Normally, constructors are declared private. " },
                {"q4.7"," Each class you create becomes a new type you can use to create objects, so C# is a(n) ________ " +
                "\nprogramming language. " },
                {"q4.8"," Method ReadLine reads a whole line, including all the characters the user types up to and including " +
                "\nthe newline that the user typed by pressing Enter. " },
                {"q4.9"," By default, instance variables are not initialized. " },
                {"q4.10"," By convention, a property's identifier is the lowercase identifier of the instance variable that it " +
                "\nmanipulates-name is the property that represents instance variable Name. " },
                {"q4.11"," You should think of a C# class's attributes as instance variables. " },
                {"q4.12"," An important difference between constructors and methods is that constructors must specify a " +
                "\nreturn type of void. " },
                {"q4.13"," Keyword get is a ________ keyword, because it's a keyword only in a property's body-elsewhere, " +
                "\nget can be used as an identifier. " },
                {"q4.14"," Which of the following statements about creating, compiling and running a Visual C# project with " +
                "\ntwo classes is false? " },
                {"q4.15","Consider the code:\r\nmyAccount.Name = theName;\r\nwhich assigns the string theName to " +
                "\nmyAccounts's Name property. " +
                "\nWhich of the following is false regarding when property Name is invoked by the expression myAccount." +
                "\nName on the left of an assignment? " },
                {"q4.16"," The Windows culture settings on the user's machine determine the format for displaying currency " +
                "\namounts, such as the commas vs. periods for separating thousands, millions, etc. " },
                {"q4.17","Consider the code:\r\npublic void SetName(string accountName)\r\n{\r\nname = accountName; // store the account name\r\n}\r\nWhich of the following statements is false? " },
                {"q4.18"," Which of the following statements is false? " },
                {"q4.19"," When implementing a method of a class, the method should access the class's instance variables directly. " },
                {"q4.20"," An attempt by a method that's not a member of a particular class to access a private member of " +
                "\nthat class is a runtime error. " },
                {"q4.21"," The fact that we could create and manipulate an Account object without knowing its implementation " +
                "\ndetails is called ________. " +
                "\nThis is one of the most powerful software-engineering benefits of object-oriented programming. " },
                {"q4.22","A method such as Main \"drives\" an object by calling its methods-without having to know how the " +
                "\nclass's internal mechanisms work. " +
                "\nIn this sense, the class containing method Main is referred to as a driver class. " },
                {"q4.23"," Which of the following statements about the C format specifier is false. " },
                {"q4.24"," Which of the following statements is false? " },
                {"q4.25"," Which of the following statements is false? " },
                {"q4.26"," Making a class's instance variables public and its methods private and accessing those instance " +
                "\nvariables only through the class's methods and properties facilitates debugging, " +
                "\nbecause problems with data manipulations are localized to the methods (and properties). " },
                {"q4.27"," A property encapsulates a set accessor for storing a value into a variable and a get accessor " +
                "\nfor getting the value of a variable. " },
                {"q4.28"," We could use a fully implemented Balance property to ensure that the set accessor's argument is " +
                "\nvalid before assigning it to the balance instance variable. " },
                {"q4.29","If the following is a constructor\r\npublic Account(string accountName)\r\n{\r\nName = accountName;\r\n}\r\nThen what is the name of the class? " },
                {"q4.30"," The benefits of data integrity are automatic when instance variables are made private. " },
                {"q4.31"," The default initial value for string instance variables is the empty string. " },
                {"q4.32"," Which of the following statements is false? " },
                {"q4.33"," Instance variables are required to be explicitly initialized before they're used in a program. " },
                {"q4.34"," A method SetName might declare a parameter accountName to receive a new name to store in an " +
                "\nAccount object-a set accessor uses the implicitly declared keyword parameter for the same purpose. " },
                {"q4.35"," It's always better to get the errors out of your programs at execution time, if possible, " +
                "\nrather than at compilation time. " },
                {"q4.36","In the code:\r\nConsole.WriteLine($\"Initial name is: {myAccount.Name}\");\r\nthe expression myAccount.Name " +
                "\nexplicitly invokes the Name property's get accessor to get the value of myAccount's instance variable name. " },
                {"q4.37"," Which of the following properly declares an auto-implemented Name property of type string? " },
                {"q4.38"," Which of the following statements is false? " },
                {"q4.39"," Which of the following statements is false? " },
                {"q4.40"," Consider the code:\r\nmyAccount.SetName(theName);\r\nWhich of the following statements is false? " },
                {"q4.41"," Keywords set and value can be used only in set accessors. " },
            
                //Chapter 5
                {"q5.1"," Cast operators are used to perform implicit conversions between data types. " },
                {"q5.2"," In an activity diagram, the merge symbol has the same shape as what other symbol? " },
                {"q5.3"," C and C++ are _______ typed languages. " },
                {"q5.4"," Which of the following are examples of control statements? " },
                {"q5.5"," The lines in an activity diagram are a graphical representation of an algorithm. " },
                {"q5.6"," Which of the following correctly represents the expression a = a + 3? " },
                {"q5.7"," When instance variables of the simple types are declared in a class, they're automatically " +
                "\nassigned default values unless specified otherwise by the programmer. " +
                "\nVariables of type bool and String are given null by default; everything else is assigned 0. " },
                {"q5.8"," Floating-point numbers contain a fractional part and can be represented by the __________ data type. " },
                {"q5.9"," A while statement allows you to specify that an action should repeat while: " },
                {"q5.10"," When you know how many times a loop will execute in advance, a ________loop should be used. " },
                {"q5.11"," Pseudocode helps you conceptualize a program during the design process. " },
                {"q5.12"," A while statement can cause logic errors where the body never stops executing. This is known as a(n)       . " },
                {"q5.13"," Which of the following is not necessarily an error (either a syntax error or a logic error)? " },
                {"q5.14"," A decision symbol in an activity diagram takes the shape of a ________. " },
                {"q5.15"," It is known as _________ when the number of repetitions is known before a loop begins executing. " },
                {"q5.16"," The first operand of the ternary operator is the condition. " },
                {"q5.17"," The __________ operator increases the value of the variable by 1 after the original value is " +
                "\nused in the expression in which the variable appears. " },
                {"q5.18"," Which statement is false? " },
                {"q5.19"," Which of the following segments will call the method readData four times? " },
                {"q5.20"," Control structures cannot be placed inside other control structures. " },
                {"q5.21"," What kind of language is pseudocode? " },
                {"q5.22"," Repetition in which the number of iterations is unknown before the loop begins executing is " +
                "\ncalled ________. " },
                {"q5.23"," Postincrementing a variable will delay the incrementing of a variable until the next time the " +
                "\nvariable is accessed. " },
                {"q5.24"," Variables that store totals should generally be initialized to zero before being used in a program. " },
                {"q5.25"," Which of the following generates a syntax error? " },
                {"q5.26"," A variable used only within a repetition statement should be declared within the statement. " },
                {"q5.27"," When using top-down, stepwise refinement, only the last refinement is a complete specification " +
                "\nof the algorithm. " },
                {"q5.28"," Pseudocode must be written in an editor capable of understanding it and the language to which it " +
                "\npertains. " },
                {"q5.29"," If an increment or decrement operator is placed before a variable, it is referred to as the prefix " +
                "\nincrement or prefix decrement operator, respectively. " +
                "\nIf an increment or decrement operator is placed after a variable, it is referred to as the postfix increment " +
                "\nor postfix decrement operator, respectively. " },
                {"q5.30"," The sentinel value must be chosen so that it cannot be confused with an acceptable input value. " },
                {"q5.31"," Which of the following decrements the variable a by one? " },
                {"q5.32"," The three types of selection structures are: " },
                {"q5.33"," Pseudocode normally describes only executable statements. " },
                {"q5.34"," What does the expression x %= 10 do? " },
                {"q5.35"," a -= 3 is equivalent to the expression a - a = 3. " },
                {"q5.36"," C# rounds fractional values when they're to be stored in an integer variable. " },
                {"q5.37"," The sequence structure is built into C#. Unless directed otherwise, the computer executes C# " +
                "\nstatements one after the other in the order in which they are written. " },
                {"q5.38"," Which of the following statements about the conditional operator (?:) is false? " },
                {"q5.39"," The while statement is an example of a sequence structure. " },
                {"q5.40"," Which of the following operators associates from left to right? " },
                {"q5.41"," A _________ can be used in a repetition structure to control the number of times a set of statements " +
                "\nwill execute. " },
                {"q5.42"," Which of the following is a type of control structure? " },
                {"q5.43"," Which of the following conditions would cause a while statement to stop executing? " },
                {"q5.44"," Pseudocode is most comparable to which of the following languages? " },
                {"q5.45"," During the 1960s, it became clear that the indiscriminate use of transfers of control was the root of " +
                "\nmuch difficulty experienced by software development groups. " },
                {"q5.46"," Local variables must be ________. " },
                {"q5.47"," A transfer of control occurs when: " },
           
                //Chapter 6
                {"q6.1"," Many classes provide methods to perform common tasks that do not require specific objects-they must " +
                "\nbe called using a class name. Such methods are called ________ methods. " },
                {"q6.2"," Counting loops should be controlled with _________ values. " },
                {"q6.3"," Which case of the following would warrant using the boolean logical inclusive OR (|) rather than " +
                "\nthe conditional OR (||)? " },
                {"q6.4"," The header for (int i = 0; i <= 10; ++i) will cause i to be incremented: " },
                {"q6.5","Consider the code segment below.\r\nif (gender == 1)\r\n{\r\nif (age >= 65)\r\n{\r\n++seniorFemales;\r\n}\r\n}\r\nThis segment is equivalent to which of the following? " },
                {"q6.6","Which of the following is equivalent to this code segment?\r\nSegment:\r\nint total = 0;\r\nfor (int i = 0; i <= 20; i += 2)\r\n{\r\ntotal += i;\r\n} " },
                {"q6.7"," Which of the following is not a control statement in C#? " },
                {"q6.8"," Which of the following for headers is syntactically incorrect? " },
                {"q6.9"," The first line of the for statement is sometimes called the: " },
                {"q6.10"," A common logic error known as a(n) _________ occurs when the programmer incorrectly specifies a " +
                "\nconditional operator, such as < instead of <=. " },
                {"q6.11","Consider the following two C# code segments:\r\n//Segment 1\r\nfor (int i=0; i <= 20; ++i)\r\n{\r\nConsole.WriteLine (i);\r\n}\r\n//Segment 2\r\nint i = 0;\r\nwhile (i < 20)\r\n{\r\n++i;\r\nConsole.WriteLine (i);\r\n}\r\nWhich of the following statements is true? " },
                {"q6.12"," The _________ statement, when executed in a while loop, skips the remaining statements in the body " +
                "\nof the statement and begins the next iteration of the loop. " },
                {"q6.13"," The _________ rule says that any rectangle (action) in an activity diagram can be replaced by two " +
                "\nrectangles with round edges. " },
                {"q6.14"," Control-statement stacking is the process of: " },
                {"q6.15"," Infinite loops are caused when the loop-continuation condition in a while, for or do…while statement " +
                "\nnever becomes true. " },
                {"q6.16"," Compressing statements before and in a for statement into the for header can reduce the readability " +
                "\nof a program " },
                {"q6.17"," The effects of break and continue statements can be achieved by structured programming techniques. " },
                {"q6.18"," The while statement is sufficient to perform any type of repetition. " },
                {"q6.19"," Which statement below is false? " },
                {"q6.20"," If a while condition is never true, the body will never execute. " },
                {"q6.21"," The for repetition statement handles the details of counter-controlled repetition. " },
                {"q6.22"," What is the Windows key sequence for typing the end-of-file indicator in Command Prompt window? " },
                {"q6.23"," The initialization expression, condition and increment expression in a for statement's header must " +
                "\nbe separated with commas. " },
                {"q6.24"," A while statement automatically increments a variable that a programmer specifies. " },
                {"q6.25"," Suppose variable gender is MALE and age equals 60, how is the expression " +
                "\n(gender == FEMALE) && (age >= 65) evaluated? " },
                {"q6.26"," Which of the following statements about the break statement is false? " },
                {"q6.27"," The C# operator ^ can be used for exponentiation. " },
                {"q6.28"," Which of the following statements is false? " },
                {"q6.29"," The loop body of a do…while statement always executes __________. " },
                {"q6.30"," Which of the following will count down from 10 to 1 correctly? " },
                {"q6.31"," Some compilers will automatically remove from loops body statements that do not need to be executed " +
                "\nmultiple times through a process known as . " },
                {"q6.32"," In structured programming, the only two ways to combine control statements are stacking and nesting. " },
                {"q6.33"," The logical exclusive OR operator is true if it at least one of its operands is true. " },
                {"q6.34"," What occurs when an empty case matches the controlling expression? " },
                {"q6.35"," for statements cannot be represented as while statements. " },
           
                //Chapter 7
                {"q7.1"," Value types normally represent single pieces of data. " },
                {"q7.2"," If a change is made to an underlying value in an enumeration, you must change the program in every " +
                "\nplace that the old value was used. " },
                {"q7.3","Consider the following Cube method:\r\nstatic int Cube(int x)\r\n{\r\nreturn x * x * x;\r\n}\r\nWhich of the following statements is false? " },
                {"q7.4"," Which of the following is not part of recursion? " },
                {"q7.5"," Repeating high-quality, high-performance code in a program helps ensure higher quality programs. " },
                {"q7.6"," _________ methods can be called without the need for an object of the class to exist. " },
                {"q7.7"," The Math class provides only methods. " },
                {"q7.8"," Which of the following will violate the rules of overloading methods? " },
                {"q7.9"," Converting a simple type to another simple type may change the value. " },
                {"q7.10"," A recursive method knows directly how to solve only the base case. " },
                {"q7.11"," A static method can ________. " },
                {"q7.12"," Which of these statements best defines scope? " },
                {"q7.13"," Since memory in a computer is finite, a stack error may occur known as stack overflow. " },
                {"q7.14"," Which of the following statements describes block scope? " },
                {"q7.15"," When may an app omit the string[] args parameter from the Main header? " },
                {"q7.16"," A method's changes to a variable that is passed-by-value do not affect the value of the original " +
                "\nvariable in the calling method. " },
                {"q7.17"," Methods that call themselves are known as ________ methods. " },
                {"q7.18"," Which statement is false? " },
                {"q7.19"," It's always better to write your own code than to search and use a class from the FCL. " },
                {"q7.20"," Which of the following describes a static variable? " },
                {"q7.21"," By including using System; at the top of a source program, you can use the unqualified class name, " +
                "\nConsole, instead of the fully qualified class name, System.Console. " },
                {"q7.22"," Which of the following can be arguments to methods? " },
                {"q7.23"," Which of the following correctly calls the Math class method Sqrt with a value of 36? " },
                {"q7.24"," Which of the following is a C# built-in reference type? " },
                {"q7.25"," Values returned by the Random class method Next are pseudo-random numbers. " },
                {"q7.26"," Prepackaged methods and classes are available for use in the .NET Framework Class Library. " },
                {"q7.27"," C# 6 introduces a new concise syntax for ________: " },
                {"q7.28"," If a local variable in a method has the same name as a field of the method's class, what will occur? " },
                {"q7.29"," strings can be concatenated only with the method Concat. " },
                {"q7.30"," A return type of _________ is specified for a method that does not return a value. " },
                {"q7.31"," Methods are called by writing the name of the method followed by a left brace followed by the " +
                "\nargument (or a comma-separated list of arguments) of the method followed by a right brace. " },
                {"q7.32"," Let x be a double. How can you typecast a double into a float? " },
                {"q7.33"," Programmers write _________ to define specific tasks that may be used at many points in a program. " },
                {"q7.34"," Methods can return at most one value. " },
                {"q7.35"," When calling a method, you must specify the arguments in the same order that the corresponding " +
                "\nparameters are declared in the method's parameter list. " },
                {"q7.36"," When an object is concatenated with a string: " },
                {"q7.37"," A variable of a reference type contains: " },
                {"q7.38"," Which directive allows you to use the Framework Class Library? " },
                {"q7.39"," An overloaded method is one that " },
                {"q7.40"," A method is invoked by a     . " },
                {"q7.41"," Information may be _________ methods. " },
                {"q7.42"," Methods of the same name can be declared in the same class, as long as they have different sets of " +
                "\nparameters (determined by the number, types and order of the parameters). " },
                {"q7.43"," Improperly defining a recursive method may result in infinite recursion. " },
                {"q7.44"," Primitive-type variables refer to objects in a C# app. " },
                {"q7.45"," Overloaded methods always have the same _________. " },
                {"q7.46"," A(n) _________ conversion occurs when a type is converted to a type that can hold more data. " },
                {"q7.47"," Which of the following cannot be an enum's underlying type? " },
                {"q7.48"," A program contains a copy of a static variable for each object that's instantiated. " },

            
                //Chapter 8
                {"q8.1"," Invalid possibilities for array indices include ________. " },
                {"q8.2"," The foreach statement is preferred over the for statement when the indices of the elements in an " +
                "\narray will be used in the body of the repetition statement. " },
                {"q8.3"," [C#6] Initializing an auto-implemented property in its declaration is a C# 6 feature known as " +
                "\nauto-property initializers. " +
                "\nWhich of the following is the general syntax for a read-write auto-implemented property with an initializer? " },
                {"q8.4"," Which set of statements totals the items in each row of two-dimensional array items, and displays each total? " },
                {"q8.5"," Changes made to an entire array that has been passed to a method will not affect the original values " +
                "\nof the array. " },
                {"q8.6"," Constant variables also are called ________. " },
                {"q8.7"," Which foreach header represents iterating through an array of int named numbers? " },
                {"q8.8"," What do the following statements do?\r\ndouble[] array;\r\narray = new double[14]; " },
                {"q8.9"," When an app is executed from the Command Prompt, the execution environment passes the command-line " +
                "\narguments to the Main method as a string. " },
                {"q8.10"," Arrays can be declared to hold only non-class data types. " },
                {"q8.11"," The number in square brackets after an array name is the _________ of an item. " },
                {"q8.12"," When accessing an element of an array, operations (calculations) are not allowed inside the " +
                "\nbrackets of an array. " },
                {"q8.13"," The foreach repetition statement requires that you provide an array and a variable for the purpose of: " },
                {"q8.14"," Which of the following statements about arrays are true?\r\nA: An array is a group of variables that all have the same type.\r\nB: Elements are located by index or subscript.\r\nC: The length of an array c is determined by the expression c.Length.\r\nD: The zeroth element of array c is specified by c[0]. " },
                {"q8.15"," Passing a reference with keyword ref gives the called method control over the passed reference itself. " },
                {"q8.16"," Which of the following correctly declares and initializes a two-dimensional rectangular array of integers? " },
                {"q8.17"," Tables are often represented with rectangular arrays. " },
                {"q8.18"," The keyword _________ overrides an existing method with the same signature. " },
                {"q8.19"," In rectangular array items, which expression below retrieve the value at row 3 and column 5? " },
                {"q8.20"," Suppose that class Book has been defined. Which of the following creates an array of Book objects? " },
                {"q8.21"," Which method call does the method header void ModifyArray(double[] b) represent? Assume that the array " +
                "\nbeing passed in is already defined and is called list. " },
                {"q8.22"," Arrays remain the same size once they're created. " },
                {"q8.23"," Arrays are _________ data structures. " },
                {"q8.24"," Constants are declared using keyword ____________. " },
                {"q8.25"," Rectangular arrays are often used to represent tables of values consisting of information arranged in: " },
                {"q8.26"," What can foreach statements iterate through? " },
                {"q8.27"," When a method receives a reference-type object parameter by value, the object is actually passed by value. " },
                {"q8.28"," [C#6] Which of the following statements is false? " },
                {"q8.29"," Attempting to access an array element out of the bounds of an array causes a(n) ________. " },
                {"q8.30"," Multi-dimensional arrays require two or more indices to identify particular elements. " },
                {"q8.31"," Which expression adds 1 to the element of array arrayName at index i, assuming the array is of type int? " },
                {"q8.32"," Which function is called when an object is used where a string should be? " },
                {"q8.33"," Which of the following statements about creating arrays and initializing their elements is false? " },
                {"q8.34"," An array with m rows and n columns is not:\r\nA: An m-by-n array.\r\nB: An n-by-m array.\r\nC: A two-dimensional array.\r\nD: An n times m dimensional array. " },
                {"q8.35"," Values in an array can be totaled by using the ArrayTotal method. " },
                {"q8.36"," Consider the array:\r\ns[0] = 7\r\ns[1] = 0\r\ns[2] = -12\r\ns[3] = 9\r\ns[4] = 10\r\ns[5] = 3\r\ns[6] = 6\r\nThe value of s[s[6] - s[5]] is: " },
                {"q8.37"," Which of the following statements is false? " },
                {"q8.38"," The first element in every array is the 0th element. " },
                {"q8.39"," The number of elements in an array must be specified in brackets after the array name in the declaration. " },
                {"q8.40"," Consider the class below:\r\nclass Test\r\n{\r\nstatic void Main()\r\n{\r\nint[] a = new int[10];\r\nfor (int i = 0; i < a.Length; ++i)\r\n{\r\na[i] = i + 1 * 2;\r\n}\r\nint result = 0;\r\nfor (int i = 0; i < a.Length; ++i)\r\n{\r\nresult += a[i];\r\n}\r\nConsole.WriteLine($\"Result is: {result}\");\r\n}\r\n}\r\nThe output of this C# program will be: " },
                {"q8.41"," When an exception is caught, the program can access the exception object's built-in ________ property " +
                "\nto get the error message and display it. " },
                {"q8.42"," Command-line arguments allow the user to pass information into an app as it begins executing. " },
                {"q8.43"," Consider the class below:\r\nclass Test\r\n{\r\nstatic void Main()\r\n{\r\nint[] a = {99, 22, 11, 3, 11, 55, 44, 88, 2, -3};\r\nint result = 0;\r\nfor (int i = 0; i < a.Length; ++i)\r\n{\r\nif (a[i] > 30)\r\n{\r\nresult += a[i];\r\n}\r\n}\r\nConsole.WriteLine($\"Result is: {result}\");\r\n}\r\n}\r\nThe output of this C# program will be: " },
                {"q8.44"," The foreach statement can be used only with one-dimensional arrays. " },
                {"q8.45"," In an array of reference types, each element may be a reference to a different type. " },
                {"q8.46"," Which of the following correctly declares and allocates an array of double values? " },
                {"q8.47"," What is the proper foreach header format? " },
                {"q8.48"," One could iterate through multi-dimensional arrays by using nested for loops. " },
                {"q8.49"," _________ is (are) typically used to traverse a two-dimensional array. " },
                {"q8.50"," When values are provided upon declaration of an array, the new keyword is not required. " },
           
                //Chapter 9
                {"q9.1"," The results of a LINQ query can have only the same type as the data being queried-for example, " +
                "\na LINQ query on a collection of Employee objects will always have Employee objects in the results. " },
                {"q9.2"," The international standard for querying relational databases is called: " },
                {"q9.3"," You can sort a LINQ query's results only by one property. " },
                {"q9.4"," A generic method does not need an object of the class in order to execute. " },
                {"q9.5"," A List<T> can automatically resize itself to accommodate additional elements. " },
                {"q9.6"," In a LINQ query, the where clause specifies          . " },
                {"q9.7"," Visual C# requires you to write SQL to query data sources. " },
                {"q9.8"," Which of the following statements about LINQ is false? " },
                {"q9.9"," Elements can be added at any location within an array after it's created. " },
                {"q9.10"," A List<T> is similar to an array, but can also _________. " },
                {"q9.11"," LINQ allows you to select from a data source items that meet a set of conditions. " },
                {"q9.12"," The Capacity property indicates the number of elements stored in the List<T>. " },
                {"q9.13"," Unlike arrays, lists do not resize automatically. " },
                {"q9.14"," A LINQ query is executed when it's created. " },
                {"q9.15"," The ________ extension method is typically used to determine whether a LINQ query's results are non-empty. " },
                {"q9.16"," A let clause is used to create _______. " },
                {"q9.17"," The objects returned when using multiple properties in a select clause are objects of an anonymous type. " },
                {"q9.18"," The ________ extension method is returns the number of results in a LINQ query. " },
                {"q9.19"," Collections of type List<T> can hold objects of what type? " },
                {"q9.20"," If multiple properties are listed in the select clause, the results will be of type SelectedList. " },
                {"q9.21"," The ________ extension method indicates that only unique values should be included in a LINQ query's results. " },
                {"q9.22"," The .NET collection classes provide flexible, efficient alternatives to arrays. " },
                {"q9.23"," The range variable is implicitly defined in the _____ clause and used to produce results in the ______ clause " },
                {"q9.24"," What method returns the number of items in LINQ query result q? " },
                {"q9.25"," LINQ is used to query collections in the same way it's used to query arrays. " }

            };

            Dictionary<string, string> options = new Dictionary<string, string>()
            {
                // Chapter 3
                {"q3.1", "\r a. Console.Write\r\n b. Console.Writeline\r\n c. Console.WriteFormat\r\n d. a and b" },
                {"q3.2", "\r a. True\r\n b. False" },
                {"q3.3", "\r a. True\r\n b. False" },
                {"q3.4", "\r a. True\r\n b. False" },
                {"q3.5", "\r a. :\r\n b. ;\r\n c. #\r\n d. ." },
                {"q3.6", "\r a. In a window form.\r\n b. In the Command Prompt.\r\n c. Console apps have no output to display.\r\n d. It depends.\r\n" },
                {"q3.7", "\r a. *\r\n b. /\r\n c. %\r\n d. ^" },
                {"q3.8", "\r a. True\r\n b. False" },
                {"q3.9", "\r a. The line where the error occurred\r\n b. The Error List window\r\n c. The Solution window\r\n d. The Command Prompt window" },
                {"q3.10", "\r a. type\r\n b. size\r\n c. value\r\n d. All of the above." },
                {"q3.11", "\r a. True\r\n b. False" },
                {"q3.12", "\r a. True\r\n b. False" },
                {"q3.13", "\r a. Logic errors\r\n b. Syntax errors\r\n c. Run-time errors\r\n d. None of the above." },
                {"q3.14", "\r a. True\r\n b. False" },
                {"q3.15", "\r a. Console.Write(\"Welcome \\n to \\n C# \\n Programming!\\n\");\r\n b. Console.WriteLine(\"Welcome \\n to \\n C# \\n Programming!\");\r\n c. Console.Write(\"Welcome \\n to \\n C# Programming!\");\r\n d. a and b" },
                {"q3.16", "\r a. True\r\n b. False" },
                {"q3.17", "\r a. Welcome to \nC# Programming!\r\n b. Welcome to C# Programming!\r\n c. {\"Welcome to \"} \n{\"C# Programming!\"}\r\n d. None of the above" },
                {"q3.18", "\r a. True\r\n b. False" },
                {"q3.19", "\r a. True\r\n b. False" },
                {"q3.20", "\r a. True\r\n b. False" },
                {"q3.21","\r a. True\r\n b. False" },
                {"q3.22","\r a. True\r\n b. False" },
                {"q3.23","\r a. True\r\n b. False" },
                {"q3.24","\r a. True\r\n b. False" },
                {"q3.25","\r a. True\r\n b. False" },
                {"q3.26","\r a. if\r\n b. test\r\n c. logic\r\n d. None of the above." },
                {"q3.27","\r a. True\r\n b. False" },
                {"q3.28","\r a. True\r\n b. False" },
                {"q3.29","\r a. True\r\n b. False" },
                {"q3.30","\r a. True\r\n b. False" },
                {"q3.31","\r a. declaration\r\n b. error\r\n c. prompt\r\n d. None of the above." },
                {"q3.32","\r a. Detect errors\r\n b. Simplify writing code\r\n c. Compile your code\r\n d. a and c" },
                {"q3.33","\r a. True\r\n b. False" },
                {"q3.34","\r a. True\r\n b. False" },
                
                // Chapter 4
                {"q4.1","\r a. WriteLine\r\n b. GetName\r\n c. They execute at the same time.\r\n d. None of the above." },
                {"q4.2","\r a. Each object of a class shares one copy of the class's instance variables.\r\n b. Each class declaration is typically stored in a file having the same name as the class and ending with the .cs filename extension\r\n c. Class, property and method names begin with an initial uppercase letter (i.e., Pascal case); variable names begin with an initial lowercase letter (i.e., camel case).\r\n d. A class has attributes, implemented as instance variables. Objects of the class carry these instance variables with them throughout their lifetimes." },
                {"q4.3","\r a. The method returns a particular Account object's name to the caller-a string, as specified by the method's return type.\r\n b. The method has an empty parameter list, so it does not require additional information to perform its task.\r\n c. When a method with a return type other than void is called and completes its task, it must return a result to its caller.\r\n d. All of the above are true.\r\n" },
                {"q4.4","\r a. Each class you declare must provide a constructor with parameters that can be used to initialize an object when it's created.\r\n b. C# requires a constructor call for every object that's created, so this is the ideal point to initialize an object's instance variables.\r\n c. A constructor's identifier must be the class's name.\r\n d. When you declare a class, you can provide your own constructor to specify custom initialization for objects of your class." },
                {"q4.5","\r a. public string Name { get, set }\r\n b. public string Name { get, set, }\r\n c. public string Name { get; set; }\r\n d. public string Name { get: set: }\r\n" },
                {"q4.6","\r a. True\r\n b. False" },
                {"q4.7","\r a.type sensitive\r\n b. flexible\r\n c. elastic\r\n d. extensible\r\n" },
                {"q4.8","\r a. True\r\n b. False" },
                {"q4.9","\r a. True\r\n b. False" },
                {"q4.10","\r a. True\r\n b. False" },
                {"q4.11","\r a. True\r\n b. False" },
                {"q4.12","\r a. True\r\n b. False" },
                {"q4.13","\r a. restricted\r\n b. dependent\r\n c. contextual\r\n d. contingent\r\n" },
                {"q4.14","\r a. The IDE automatically recognizes as the app's entry point the class that contains Main.\r\n b. When you select Build > Build Solution in Visual Studio, the IDE compiles all the files in the project to create the executable app.\r\n c. If you do not build the app before running it, typing Ctrl + F5 will build the app first and run the app only if there are no compilation errors.\r\n d. In a given project, declaring a Main method in more than exactly one class results in a runtime error." },
                {"q4.15","\r a. The app transfers program execution to Name's set accessor.\r\n b. Property Name's set accessor performs its task-that is, it stores in the myAccount object's name instance variable the string value that was assigned to property Name.\r\n c. When Name's set accessor completes execution, program control returns to where the Name property was accessed, then execution continues at the next statement.\r\n d. All of the above are true.\r\n" },
                {"q4.16","\r a. True\r\n b. False" },
                {"q4.17","\r a. The first line of each method declaration is the method header.\r\n b. The method's return type (which appears to the left of the method's name) specifies the type of data the method returns to its caller after performing its task.\r\n c. The return type void indicates that when SetName completes its task, it does not return any information to its calling method.\r\n d. A method requires one or more parameters that represent the data it needs to perform its task." },
                {"q4.18","\r a. Variables declared in a particular method's body (such as Main) are local variables, which can be used only in that method.\r\n b. Each method can access its own local variables and those of other methods.\r\n c. When a method terminates, the values of its local variables are lost.\r\n d. A method's parameters also are local variables of the method.\r\n" },
                {"q4.19","\r a. True\r\n b. False" },
                {"q4.20","\r a. True\r\n b. False" },
                {"q4.21","\r a. inheritance\r\n b. shadowing\r\n c. overriding\r\n d. abstraction" },
                {"q4.22","\r a. True \nb. False" },
                {"q4.23","\r a. It formats the string as currency.\r\n b. It includes an appropriate currency symbol ($ in the U.S.) next to the number.\r\n c. It separates digits with an appropriate separator character (in the U.S. its a comma between every digit.)\r\n d. It sets the number of decimal places to two by default.\r\n" },
                {"q4.24","\r a. Normally, a class also contains methods and properties. These manipulate the instance variables belonging to particular objects of the class.\r\n b. Instance variables are declared inside the bodies of the class's methods and properties.\r\n c. Clients of a class cannot access the class's private instance variables.\r\n d. Clients of a class can access the class's public methods.\r\n" },
                {"q4.25","\r a. If you later decide to include other logic in the get or set accessors, you can simply implement the property and an instance variable.\r\n b. With an auto-implemented property, the C# compiler automatically creates a public instance variable, and the get and set accessors for getting and setting that instance variable.\r\n c. With an auto-implemented property you can implement the property trivially, which is handy when you're first designing a class.\r\n" },
                {"q4.26","\r a. True\r\n b. False" },
                {"q4.27","\r a. True\r\n b. False" },
                {"q4.28","\r a. True\r\n b. False" },
                {"q4.29","\r a. Account\r\n b. accountName\r\n c. Name\r\n d. None of the above.\r\n" },
                {"q4.30","\r a. True\r\n b. False" },
                {"q4.31","\r a. True\r\n b. False"  },
                {"q4.32","\r a. Set and Get methods can validate attempts to modify private data and control how that data is presented to the caller, respectively.\r\n b. If an instance variable were public, any client of the class could see the data and modify it, including setting it to an invalid value.\r\n c. public data allows client-code programmers to write code that depends on the class's data format. If the class's owner changes that format, any client code dependent on it would \"break\" and would need to be adjusted to the new format, making it subject to break again.\r\n d. None is false. All of the above are true.\r\n" },
                {"q4.33","\r a. True\r\n b. False" },
                {"q4.34","\r a. True\r\n b. False" },
                {"q4.35","\r a. True\r\n b. False" },
                {"q4.36","\r a. True\r\n b. False" },
                {"q4.37","\r a. public string Name { get, set }\r\n b. public string Name { get, set, }\r\n c. public string Name { get; set; }\r\n d. public string Name { get: set: }\r\n" },
                {"q4.38","\r a. A decimal instance variable is initialized to zero by default.\r\n b. By default, a property's get and set accessors have the same access as the property.\r\n c. A property's get and set accessors must have the same access modifiers.\r\n d. We can declare a Balance property's set accessor private to indicate that it may be used only within its class, but not by the class's clients.\r\n" },
                {"q4.39","\r a. In any class that does not explicitly declare a constructor, the compiler provides a public default constructor (which always has no parameters).\r\n b. When a class has only the default constructor, the class's instance variables are initialized to their default values: 0 for numeric simple types, false for simple type bool and null for all other types.\r\n c. If you declare one or more constructors for a class, the compiler will not create a default constructor for that class.\r\n d. If the compiler does not create a default constructor for an Account class, you will not be able to create an Account object with the expression new Account()." },
                {"q4.40","\r a. When this method executes, the argument value in the call's parentheses (i.e., the value stored in theName) is copied into the corresponding parameter in the method's header.\r\n b. Each parameter must specify a type followed by a parameter name. When there are multiple parameters, they are placed in a comma-separated list.\r\n c. The number and order of arguments in a method call must match the number and order of parameters in the method declaration's parameter list.\r\n d. All of the above are true.\r\n" },
                {"q4.41","\r a. True\r\n b. False" },
                
                // Chapter 5
                {"q5.1","\r a. True\r\n b. False" },
                {"q5.2","\r a. decision symbol\r\n b. action symbol\r\n c. transition arrows\r\n d. initial state\r\n" },
                {"q5.3","\r a. strongly\r\n b. moderately\r\n c. weakly\r\n d. the languages vary\r\n" },
                {"q5.4","\r a. if\r\n b. if...else\r\n c. while\r\n d. b and c\r\n e. a, b and c\r\n" },
                {"q5.5","\r a. True\r\n b. False" },
                {"q5.6","\r a. 3a\r\n b. a += 3\r\n c. a + 3\r\n d. None of the above.\r\n" },
                {"q5.7","\r a. True\r\n b. False" },
                {"q5.8","\r a. frac\r\n b. real\r\n c. double\r\n d. None of the above.\r\n" },
                {"q5.9","\r a. a specific condition remains false\r\n b. a specific condition remains true\r\n c. a specific condition remains either true or false\r\n d. None of the above.\r\n" },
                {"q5.10","\r a. sentinel\r\n b. infinite\r\n c. counter-controlled\r\n d. None of the above." },
                {"q5.11","\r a. True\r\n b. False" },
                {"q5.12","\r a. syntax error\r\n b. fatal error\r\n c. infinite loop\r\n d. None of the above.\r\n" },
                {"q5.13","\r a. Neglecting to include an action in the body of a while statement that will eventually cause the condition to become false.\r\n b. Spelling a key word (such as while or if) with a capitalized first letter.\r\n c. Using a condition for a while statement that is initially false.\r\n d. An infinite loop.\r\n" },
                {"q5.14","\r a. diamond\r\n b. rectangle\r\n c. circle\r\n d. question mark\r\n" },
                {"q5.15","\r a. definite repetition\r\n b. infinite repetition\r\n c. total repetition\r\n d. None of the above.\r\n" },
                {"q5.16","\r a. True\r\n b. False" },
                {"q5.17","\r a. preincrement\r\n b. postincrement\r\n c. predecrement\r\n d. None of the above" },
                {"q5.18","\r a. Unless directed otherwise, the computer executes C# statements one after the other in the order in which they are written.\r\n b. Activity diagrams normally show the C# code that implements the activity.\r\n c. Like pseudocode, activity diagrams help programmers develop and represent algorithms.\r\n d. The arrows in the activity diagram represent transitions, which indicate the order in which the actions represented by the action states occur." },
                {"q5.19","\r a. int k;\r\nk = 1;\r\nwhile (k < 4)\r\n{\r\nreadData();\r\nk = k + 1;\r\n}\r\n b. int i;\r\ni = 0;\r\nwhile (i <= 4)\r\n{\r\nreadData();\r\ni = i + 1;\r\n}\r\n c. int i;\r\ni = 0;\r\nwhile (i < 4)\r\n{\r\nreadData();\r\n}\r\n d. int i;\r\ni = 0;\r\nwhile (i < 4)\r\n{\r\nreadData();\r\ni = i + 1;\r\n}\r\n" },
                {"q5.20","\r a. True\r\n b. False" },
                {"q5.21","\r a. a hybrid language of all .NET languages\r\n b. an artificial language used to develop algorithms\r\n c. a language used to translate from C++ to C#\r\n d. None of the above.\r\n" },
                {"q5.22","\r a. indefinite repetition\r\n b. controlled repetition\r\n c. top-down repetition\r\n d. None of the above.\r\n" },
                {"q5.23","\r a. True\r\n b. False" },
                {"q5.24","\r a. True\r\n b. False" },
                {"q5.25","\r a. c *= 3;\r\n b. c %= 2;\r\n c. c /= 4;\r\n d. None of the above.\r\n" },
                {"q5.26","\r a. True\r\n b. False" },
                {"q5.27","\r a. True\r\n b. False" },
                {"q5.28","\r a. True\r\n b. False" },
                {"q5.29","\r a. True\r\n b. False" },
                {"q5.30","\r a. True\r\n b. False" },
                {"q5.31","\r a. a--\r\n b. a-\r\n c. --a\r\n d. a and c\r\n e. All of the above.\r\n" },
                {"q5.32","\r a. foreach, for and switch\r\n b. if, for and switch\r\n c. if, if/else and while\r\n d. if, if/else and switch\r\n" },
                {"q5.33","\r a. True\r\n b. False" },
                {"q5.34","\r a. Adds 10 to the value of x, and stores the result in x.\r\n b. Divides x by 10 and stores the remainder in x.\r\n c. Divides x by 10 and stores the integer result in x.\r\n d. None of the above.\r\n" },
                {"q5.35","\r a. True\r\n b. False" },
                {"q5.36","\r a. True\r\n b. False" },
                {"q5.37","\r a. True\r\n b. False" },
                {"q5.38","\r a. The conditional operator is a ternary operator, meaning that it takes three operands.\r\n b. The first operand is a bool expression.\r\n c. The second operand is the result value if the condition evaluates to false.\r\n d. The second operand is the result value if the condition evaluates to true." },
                {"q5.39","\r a. True\r\n b. False" },
                {"q5.40","\r a. ++\r\n b. ?:\r\n c. %=\r\n d. /\r\n" },
                {"q5.41","\r a. declaration\r\n b. counter\r\n c. controller\r\n d. None of the above" },
                {"q5.42","\r a. declaration structure\r\n b. repetition structure\r\n c. flow structure\r\n d. All of the above.\r\n" },
                {"q5.43","\r a. 3 <= 11\r\n b. !(7 != 14)\r\n c. 6 != 9\r\n d. All of the above.\r\n" },
                {"q5.44","\r a. C#\r\n b. C\r\n c. Pascal\r\n d. English\r\n" },
                {"q5.45","\r a. True\r\n b. False" },
                {"q5.46","\r a. initialized when they are declared.\r\n b. initialized before their values are used in an expression.\r\n c. declared and initialized in two steps.\r\n d. declared at the top of the method.\r\n" },
                {"q5.47","\r a. a program changes from input to output, or vice versa\r\n b. a logic error occurs in a program\r\n c. a statement other than the next one in the program executes\r\n d. None of the above.\r\n" },
              
                //Chapter 6
                {"q6.1","\r a. classwide\r\n b. dot (.)\r\n c. console\r\n d. static\r\n" },
                {"q6.2","\r a. double\r\n b. int\r\n c. char\r\n d. None of the above.\r\n" },
                {"q6.3","\r a. Testing if two conditions are both true.\r\n b. Testing if at least one of two conditions is true.\r\n c. Testing if at least one of two conditions is true when the right operand has a required side effect.\r\n d. Testing if at least one of two conditions is true when the left operand has a required side effect." },
                {"q6.4","\r a. before the body begins execution\r\n b. after the body begins to execute, but before it finishes\r\n c. after the entire body executes\r\n d. None of the above.\r\n" },
                {"q6.5","\r a. if (gender == 1 || age >= 65)\r\n{\r\n++seniorFemales;\r\n}\r\n b. if (gender == 1 && age >= 65)\r\n{\r\n++seniorFemales;\r\n}\r\n c. if (gender == 1 AND age >= 65)\r\n{\r\n++seniorFemales;\r\n}\r\n d. if (gender == 1 OR age >= 65)\r\n{\r\n++seniorFemales;\r\n}\r\n" },
                {"q6.6","\r a. int total = 0;\r\nfor (int i = 20; i < 0; i += 1)\r\n{\r\ntotal += i;\r\n}\r\n b. int total = 0;\r\nfor (int i = 0; i <= 20; total += i, i += 2);\r\n c. int total = 0;\r\nfor (int i = 0, i <= 20, total += i; i += 2);\r\n d. int total = 0;\r\nfor (int i = 2; i < 20; total += i, i += 2);\r\n" },
                {"q6.7","\r a. do…while\r\n b. loop\r\n c. switch\r\n d. for\r\n" },
                {"q6.8","\r a. for (int i = 1; i < 10;)\r\n b. for (; i == 3;)\r\n c. for (i == 3)\r\n d. None of the above.\r\n" },
                {"q6.9","\r a. for statement header\r\n b. increment header\r\n c. repetition header\r\n d. None of the above.\r\n" },
                {"q6.10","\r a. fatal error\r\n b. off-by-one error\r\n c. syntax error\r\n d. None of the above.\r\n" },
                {"q6.11","\r a. The output from these segments is not the same.\r\n b. The scope of the control variable i is different for the two segments.\r\n c. Both (a) and (b) are true.\r\n d. Neither (a) nor (b) is true.\r\n" },
                {"q6.12","\r a. continue\r\n b. break\r\n c next\r\n d. None of the above.\r\n" },
                {"q6.13","\r a. nesting\r\n b. selection\r\n c. stacking\r\n d. None of the above.\r\n" },
                {"q6.14","\r a. placing control statements within each other\r\n b. placing control statements one after another\r\n c. reducing the number of statements required by combining statements\r\n d. None of the above.\r\n" },
                {"q6.15","\r a. True\r\n b. False" },
                {"q6.16","\r a. True\r\n b. False" },
                {"q6.17","\r a. True\r\n b. False" },
                {"q6.18","\r a. True\r\n b. False" },
                {"q6.19","\r a. Structured programming produces programs that are easier to test.\r\n b. Structured programming requires four forms of control.\r\n c. Structured programming produces programs that are easier to modify\r\n d. Structured programming promotes simplicity.\r\n" },
                {"q6.20","\r a. True\r\n b. False" },
                {"q6.21","\r a. True\r\n b. False" },
                {"q6.22","\r a. <Alt>-z\r\n b. <Ctrl>-z\r\n c. <Windows>-z\r\n d. <Shift>-z\r\n" },
                {"q6.23","\r a. True\r\n b. False" },
                {"q6.24","\r a. True\r\n b. False" },
                {"q6.25","\r a. The condition (gender == FEMALE) is evaluated first and the evaluation stops immediately.\r\n b. The condition (age >= 65) is evaluated first and the evaluation stops immediately.\r\n c. Both conditions are evaluated, from left to right.\r\n d. Both conditions are evaluated, from right to left.\r\n" },
                {"q6.26","\r a. The break statement is used to exit a repetition statement early and continue execution after the loop.\r\n b. A break statement can only break out of an immediately enclosing while, for, do…while or switch statement.\r\n c. The break statement, when executed in a while, for or do…while, skips the remaining statements in the loop body and proceeds with the next iteration of the loop.\r\n d. Common uses of the break statement are to escape early from a loop or to skip the remainder of a switch." },
                {"q6.27","\r a. True\r\n b. False" },
                {"q6.28","\r a. C# does not include an exponentiation operator.\r\n b. The expression Math.Pow(x, y) calculates the value of x raised to the yth power.\r\n c. C# will implicitly convert a double to a decimal, or vice versa.\r\n d. In loops, avoid calculations for which the result never changes-such calculations should typically be placed before the loop. Optimizing compilers will typically do this for you." },
                {"q6.29","\r a. zero times\r\n b. at least once\r\n c. more than once\r\n d. undeterminable\r\n" },
                {"q6.30","\r a. for (int j = 10; j <= 1; ++j)\r\n b. for (int j = 1; j <= 10; ++j)\r\n c. for (int j = 10; j > 1; --j)\r\n d. for (int j = 10; j >= 1; --j)\r\n" },
                {"q6.31","\r a. classification\r\n b. optimization\r\n c. interpretation\r\n d. None of the above.\r\n" },
                {"q6.32","\r a. True\r\n b. False" },
                {"q6.33","\r a. True\r\n b. False" },
                {"q6.34","\r a. fall through\r\n b. syntax error\r\n c. infinite loop\r\n d. None of the above.\r\n" },
                {"q6.35","\r a. True\r\n b. False" },
                
                //Chapter 7
                {"q7.1","\r a. True\r\n b. False" },
                {"q7.2","\r a. True\r\n b. False" },
                {"q7.3","\r a. In C# 6, this method can be defined with an expression-bodied method as: static int Cube(int x) => x * x * x; The value of x * x * x is returned to Cube's caller implicitly.\r\n b. The symbol => follows the method's parameter list and introduces the method's body-no braces or return statement are required. This can be used only with static methods.\r\n c. If the expression to the right of => does not have a value (e.g., a call to a method that returns void), the expression-bodied method must return void.\r\n d. Similarly, a read-only property can be implemented as an expression-bodied property. The following re-implements the IsNoFaultState property we used in the textbook to return the result of a logical expression: public bool IsNoFaultState => State == \"MA\" || State == \"NJ\" || State == \"NY\" || State == \"PA\";\r\n" },
                {"q7.4","\r a. recursive call\r\n b. recursion step(s)\r\n c. a base case or multiple base cases\r\n d. None of the above.\r\n" },
                {"q7.5","\r a. True\r\n b. False" },
                {"q7.6","\r a. special\r\n b. independent\r\n c. static\r\n d. dependent\r\n" },
                {"q7.7","\r a. True\r\n b. False" },
                {"q7.8","\r a. Methods with the same signatures but different return types.\r\n b. Methods with different signatures but the same return type.\r\n c. Methods with different number of arguments.\r\n d. Method with different types of arguments.\r\n" },
                {"q7.9","\r a. True\r\n b. False" },
                {"q7.10","\r a. True\r\n b. False" },
                {"q7.11","\r a. call only other static methods of the same class directly\r\n b. manipulate only static fields in the same class directly\r\n c. be called using the class name and a dot (.)\r\n d. All of the above\r\n" },
                {"q7.12","\r a. Scope refers to the classes that have access to a variable.\r\n b. Scope determines whether a variable's value can be altered.\r\n c. Scoping allows the programmer to use a class without using its fully qualified name.\r\n d. Scope is the portion of a program that can refer to an entity by its simple name." },
                {"q7.13","\r a. True\r\n b. False" },
                {"q7.14","\r a. It begins at the opening { of the class declaration and terminates at the closing }\r\n b. It limits label scope to only the method in which it is declared.\r\n c. It begins at the identifier's declaration and ends at the terminating right brace (}).\r\n d. It is valid for one statement only.\r\n" },
                {"q7.15","\r a. when the app does not need to use strings\r\n b. when the app does not take command-line arguments\r\n c. when the app does not output any strings\r\n d. All of the above\r\n" },
                {"q7.16","\r a. True\r\n b. False" },
                {"q7.17","\r a. reiterative\r\n b. self-calling\r\n c. repeat-calling\r\n d. recursive\r\n" },
                {"q7.18","\r a. If a method does not return a value, the return-value-type in the method declaration can be omitted.\r\n b. Placing a semicolon after the right parenthesis enclosing the parameter list of a method declaration is a syntax error.\r\n c. Re-declaring a method parameter as a local variable in the method's body is a compilation error.\r\n d. Forgetting to return a value from a method that should return a value is a compilation error." },
                {"q7.19","\r a. True\r\n b. False" },
                {"q7.20","\r a. a variable with one copy shared by all class objects\r\n b. a variable whose value may not be changed\r\n c. all of the above\r\n d. None of the above.\r\n" },
                {"q7.21","\r a. True\r\n b. False" },
                {"q7.22","\r a. constants\r\n b. variables\r\n c. expressions\r\n d. All of the above\r\n" },
                {"q7.23","\r a. Sqrt(36);\r\n b. Math.Sqrt(36);\r\n c. Math.Sqrt = 36;\r\n d. None of the above.\r\n" },
                {"q7.24","\r a. int\r\n b. string\r\n c. bool\r\n d. char\r\n" },
                {"q7.25","\r a. True\r\n b. False" },
                {"q7.26","\r a. True\r\n b. False" },
                {"q7.27","\r a. methods that contain only a return statement that returns a value\r\n b. read-only properties in which the get accessor contains only a return statement\r\n c. methods that contain single statement bodies.\r\n d. All of the above\r\n" },
                {"q7.28","\r a. an error is generated\r\n b. the field is \"hidden\" until the method is finished executing\r\n c. the field will override the variable from the method\r\n d. None of the above.\r\n" },
                {"q7.29","\r a. True\r\n b. False" },
                {"q7.30","\r a. nothing\r\n b. null\r\n c. void\r\n d. None of the above.\r\n" },
                {"q7.31","\r a. True\r\n b. False" },
                {"q7.32","\r a.  implicitly\r\n b. x(float)\r\n c. (float)x\r\n d. x = float\r\n" },
                {"q7.33","\r a. classes\r\n b. methods\r\n c. modules\r\n d. None of the above.\r\n" },
                {"q7.34","\r a. True\r\n b. False" },
                {"q7.35","\r a. True\r\n b. False" },
                {"q7.36","\r a. a compilation error occurs\r\n b. a runtime error occurs\r\n c. the object's ToString method is implicitly called\r\n d. the object's class name is used\r\n" },
                {"q7.37","\r a. information about the type and its data\r\n b. data of that type\r\n c. the address of the location in memory where data is stored\r\n d. None of the above.\r\n" },
                {"q7.38","\r a. import\r\n b. using\r\n c. load\r\n d. namespace\r\n" },
                {"q7.39","\r a. has a different name than another method, but the same parameters.\r\n b. has the same name as another method, but different parameters.\r\n c. has the same name and parameters as a method defined in another class.\r\n d. has the same name and parameters, but a different return type than another method." },
                {"q7.40","\r a. return statement\r\n b. method header\r\n c. method call\r\n d. None of the above." },
                {"q7.41","\r a. passed to\r\n b. returned from\r\n c. manipulated in\r\n d. All of the above.\r\n" },
                {"q7.42","\r a. True\r\n b. False" },
                {"q7.43","\r a. True\r\n b. False" },
                {"q7.44","\r a. True\r\n b. False" },
                {"q7.45","\r a. method name\r\n b. return type\r\n c. number of the parameters\r\n d. order of the parameters\r\n" },
                {"q7.46","\r a. implicit\r\n b. widening\r\n c. explicit\r\n d. None of the above.\r\n" },
                {"q7.47","\r a. sbyte\r\n b. int\r\n c. ulong\r\n d. double\r\n" },
                {"q7.48","\r a. True\r\n b. False" },
                
                //Chapter 8
                {"q8.1","\r a. positive integers\r\n b. negative integers\r\n c. non-consecutive integers\r\n d. zero\r\n" },
                {"q8.2","\r a. True\r\n b. False" },
                {"q8.3","\r a. Type PropertyName {get, set;} = initializer;\r\n b. Type PropertyName {get | set} = initializer;\r\n c. Type PropertyName {get; set} = initializer;\r\n d. Type PropertyName {get; set;} = initializer;\r\n" },
                {"q8.4","\r a. int total = 0;\r\nfor (int row = 0; row < items.Length; ++row)\r\n{\r\ntotal = 0;\r\nfor (int column = 0; column < a[row].Length; ++column)\r\n{\r\ntotal += a[row][column];\r\n}\r\n}\r\n b. int total = 0;\r\nfor (int row = 0; row < items. Length; ++row)\r\n{\r\nfor (int column = 0; column < a[row]. Length; ++column)\r\n{\r\ntotal += a[row][column];\r\n}\r\n}\r\n c. int total = 0;\r\nfor (int row = 0; row < items. Length; ++row)\r\n{\r\nfor (int column = 0; column < a[column].length; ++column)\r\n{\r\ntotal += a[row][column];\r\n}\r\n}\r\n d. int total = 0;\r\nfor (int row = 0; row < items. Length; ++row)\r\n{\r\ntotal = 0;\r\nfor (int column = 0; column < a[column].length; ++column)\r\n{\r\ntotal += a[row][column];\r\n}\r\n}\r\n" },
                {"q8.5","\r a. True\r\n b. False" },
                {"q8.6","\r a. write-only variables\r\n b. finals\r\n c. named constants\r\n d. All of the above\r\n" },
                {"q8.7","\r a. foreach (numbers)\r\n b. foreach (number in numbers)\r\n c. foreach (int number in numbers)\r\n d. foreach (int number in int[] numbers)\r\n" },
                {"q8.8","\r a. Creates a double array containing 13 elements.\r\n b. Creates a double array containing 14 elements.\r\n c. Creates a double array containing 15 elements.\r\n d. Declares but does not create a double array.\r\n" },
                {"q8.9","\r a. True\r\n b. False" },
                {"q8.10","\r a. True\r\n b. False" },
                {"q8.11","\r a. value\r\n b. position\r\n c. size\r\n d. None of the above.\r\n" },
                {"q8.12","\r a. True\r\n b. False" },
                {"q8.13","\r a. preventing the structure from going past the end of the array\r\n b. storing the value of each element that is traversed\r\n c. acting as a counter to traverse the array\r\n d. None of the above.\r\n" },
                {"q8.14","\r a. A, C, D\r\n b. A, B, D\r\n c. C, D\r\n d. A, B, C, D\r\n" },
                {"q8.15","\r a. True\r\n b. False" },
                {"q8.16","\r a. int[,] sum = new int[3, 4];\r\n b. int[] sum = new int[2, 4];\r\n c. int sum[] = new int[2, 2];\r\n d. None of the above.\r\n" },
                {"q8.17","\r a. True\r\n b. False" },
                {"q8.18","\r a. replace\r\n b. override\r\n c. overrule\r\n d. supersede\r\n" },
                {"q8.19","\r a. items[3. 4]\r\n b. items[3][4]\r\n c. items[3, 4]\r\n d. None of the above.\r\n" },
                {"q8.20","\r a. Book[] books = new Book[numberElements];\r\n b. Book[] books = new Book()[numberElements];\r\n c. new Book() books[];\r\nbooks = new Book[numberElements];\r\n d. All of the above.\r\n" },
                {"q8.21","\r a. ModifyArray(double[] list)\r\n b. ModifyArray(double[] : list)\r\n c. ModifyArray(double list[])\r\n d. ModifyArray(list)\r\n" },
                {"q8.22","\r a. True\r\n b. False" },
                {"q8.23","\r a. constant\r\n b. dynamic\r\n c. static\r\n d. None of the above.\r\n" },
                {"q8.24","\r a. static\r\n b. const\r\n c. fixed\r\n d. None of the above.\r\n" },
                {"q8.25","\r a. rows\r\n b. columns\r\n c. both a and b\r\n d. None of the above\r\n" },
                {"q8.26","\r a. arrays\r\n b. collections\r\n c. databases\r\n d. both a and b\r\n" },
                {"q8.27","\r a. True\r\n b. False" },
                {"q8.28","\r a. Prior to C# 6, auto-implemented properties required both a get and a set accessor.\r\n b. Client code can use C# 6 getter-only auto-implemented properties only to get each property's value.\r\n c. C#6 getter-only auto-implemented properties are read only.\r\n d. C#6 getter-only auto-implemented properties can be initialized only in their declarations." },
                {"q8.29","\r a. ArrayOutOfBoundsException.\r\n b. ArrayElementOutOfBoundsException.\r\n c. IndexOutOfRangeException.\r\n d. ArrayException.\r\n" },
                {"q8.30","\r a. True\r\n b. False" },
                {"q8.31","\r a. ++arrayName[i]\r\n b. arrayName++[i]\r\n c. arrayName[i++]\r\n d. None of the above.\r\n" },
                {"q8.32","\r a. TranslateToString()\r\n b. String()\r\n c. ConvertToString()\r\n d. ToString()\r\n" },
                {"q8.33","\r a. The new keyword should be used to create an array.\r\n b. When an array is created, the number of elements must be placed in square brackets following the type of element being stored.\r\n c. The elements of an array of integers have a value of null before they are initialized.\r\n d. A for loop is an excellent way to initialize the elements of an array." },
                {"q8.34","\r a. A and C\r\n b. A and D\r\n c. B and D\r\n d. B and C\r\n" },
                {"q8.35","\r a. True\r\n b. False" },
                {"q8.36","\r a. 0\r\n b. 3\r\n c. 9\r\n d. 0\r\n" },
                {"q8.37","\r a. You can have many catch blocks to handle different types of exceptions that might be thrown in the corresponding try block.\r\n b. The runtime performs array bounds checking.\r\n c. When an exception is thrown, the try block in which it occurs terminates and a corresponding catch block, if there is one, begins executing-if you declared any variables in the try block, they are accessible in the catch block.\r\n d.  The catch block declares an exception parameter's type and name. The catch block can handle exceptions of the specified type.\r\n" },
                {"q8.38","\r a. True\r\n b. False" },
                {"q8.39","\r a. True\r\n b. False" },
                {"q8.40","\r a. Result is: 62\r\n b. Result is: 64\r\n c. Result is: 65\r\n d. Result is: 67\r\n" },
                {"q8.41","\r a. Error\r\n b. Fault\r\n c. Message\r\n d. Note\r\n" },
                {"q8.42","\r a. True\r\n b. False" },
                {"q8.43","\r a. Result is: 280\r\n b. Result is: 154\r\n c. Result is: 286\r\n d. Result is: 332\r\n" },
                {"q8.44","\r a. True\r\n b. False" },
                {"q8.45","\r a. True\r\n b. False" },
                {"q8.46","\r a. double A[15];\r\n b. double() A = new double[15];\r\n c. double[] A = new double[25];\r\n d. All of the above.\r\n" },
                {"q8.47","\r a. (foreach type_identifer in arrayName)\r\n b. foreach (arrayName)\r\n c. foreach (type_identifer in arrayName)\r\n d. None of the above.\r\n" },
                {"q8.48","\r a. True\r\n b. False" },
                {"q8.49","\r a. A do while statement\r\n b. A for statement\r\n c. Two nested for statements\r\n d. Three nested for statements\r\n" },
                {"q8.50","\r a. True\r\n b. False" },
                
                //Chapter 9
                {"q9.1","\r a. True\r\n b. False" },
                {"q9.2","\r a. XML\r\n b. SQL\r\n c. HTTP\r\n d. LINQ\r\n" },
                {"q9.3","\r a. True\r\n b. False" },
                {"q9.4","\r a. True\r\n b. False" },
                {"q9.5","\r a. True\r\n b. False" },
                {"q9.6","\r a. the data source\r\n b. where to put the data\r\n c. the condition(s) for including the item\r\n d. the Location property\r\n e. the data type\r\n" },
                {"q9.7","\r a. True\r\n b. False" },
                {"q9.8","\r a. A new LINQ query must be used when changes are made to the data source.\r\n b. A LINQ query does not need to have a let clause\r\n c. A LINQ query returns an IEnumerable object\r\n d. LINQ stands for Language Integrated Query.\r\n" },
                {"q9.9","\r a. True\r\n b. False" },
                {"q9.10","\r a. dynamically resize\r\n b. add items anywhere in the List<T>\r\n c. contain objects of any one type\r\n d. Both a and b\r\n" },
                {"q9.11","\r a. True\r\n b. False" },
                {"q9.12","\r a. True\r\n b. False" },
                {"q9.13","\r a. True\r\n b. False" },
                {"q9.14","\r a. True\r\n b. False" },
                {"q9.15","\r a. Any\r\n b. First\r\n c. Count\r\n d. None of the above\r\n" },
                {"q9.16","\r a. a method within a LINQ query\r\n b. a subquery\r\n c. a new range variable\r\n d. None of the above\r\n" },
                {"q9.17","\r a. True\r\n b. False" },
                {"q9.18","\r a. Any\r\n b. First\r\n c. Count\r\n d. None of the above\r\n" },
                {"q9.19","\r a. only other lists\r\n b. only integers\r\n c. objects of any one type\r\n d. None of the above\r\n" },
                {"q9.20","\r a. True\r\n b. False" },
                {"q9.21","\r a. Any\r\n b. Distinct\r\n c. Count\r\n d. None of the above\r\n" },
                {"q9.22","\r a. True\r\n b. False" },
                {"q9.23","\r a. where, put\r\n b. from, put\r\n c. from, select\r\n d. where, select\r\n e. in, foreach\r\n" },
                {"q9.24","\r a. Length\r\n b. Size\r\n c. getUpperBound\r\n d. Count\r\n" },
                {"q9.25","\r a. True\r\n b. False" },

            };

            Dictionary<string, string> answers = new Dictionary<string, string>()
            {
                // Chapter 3
                {"q3.1","d" },
                {"q3.2","b" },
                {"q3.3","a" },
                {"q3.4","a" },
                {"q3.5","b" },
                {"q3.6","b" },
                {"q3.7","a" },
                {"q3.8","a" },
                {"q3.9","c" },
                {"q3.10","d" },
                {"q3.11","b" },
                {"q3.12","b" },
                {"q3.13","b" },
                {"q3.14","b" },
                {"q3.15","d" },
                {"q3.16","b" },
                {"q3.17","a" },
                {"q3.18","a" },
                {"q3.19","b" },
                {"q3.20","a" },
                {"q3.21","a" },
                {"q3.22","b" },
                {"q3.23","b" },
                {"q3.24","b" },
                {"q3.25","b" },
                {"q3.26","a" },
                {"q3.27","a" },
                {"q3.28","a" },
                {"q3.29","a" },
                {"q3.30","b" },
                {"q3.31","c" },
                {"q3.32","b" },
                {"q3.33","b" },
                {"q3.34","b" },
                
                // Chapter 4
                {"q4.1","b" },
                {"q4.2","a" },
                {"q4.3","d" },
                {"q4.4","a" },
                {"q4.5","c" },
                {"q4.6","b" },
                {"q4.7","d" },
                {"q4.8","b" },
                {"q4.9","b" },
                {"q4.10","b" },
                {"q4.11","b" },
                {"q4.12","b" },
                {"q4.13","c" },
                {"q4.14","d" },
                {"q4.15","d" },
                {"q4.16","a" },
                {"q4.17","d" },
                {"q4.18","b" },
                {"q4.19","b" },
                {"q4.20","b" },
                {"q4.21","d" },
                {"q4.22","a" },
                {"q4.23","c" },
                {"q4.24","b" },
                {"q4.25","b" },
                {"q4.26","b" },
                {"q4.27","a" },
                {"q4.28","a" },
                {"q4.29","a" },
                {"q4.30","b" },
                {"q4.31","b" },
                {"q4.32","d" },
                {"q4.33","b" },
                {"q4.34","b" },
                {"q4.35","b" },
                {"q4.36","b" },
                {"q4.37","c" },
                {"q4.38","c" },
                {"q4.39","d" },
                {"q4.40","d" },
                {"q4.41","b" },
                
                // Chapter 5
                {"q5.1","b" },
                {"q5.2","a" },
                {"q5.3","a" },
                {"q5.4","e" },
                {"q5.5","b" },
                {"q5.6","b" },
                {"q5.7","b" },
                {"q5.8","c" },
                {"q5.9","b" },
                {"q5.10","c" },
                {"q5.11","a" },
                {"q5.12","c" },
                {"q5.13","c" },
                {"q5.14","a" },
                {"q5.15","a" },
                {"q5.16","a" },
                {"q5.17","b" },
                {"q5.18","b" },
                {"q5.19","d" },
                {"q5.20","b" },
                {"q5.21","b" },
                {"q5.22","a" },
                {"q5.23","b" },
                {"q5.24","a" },
                {"q5.25","d" },
                {"q5.26","b" },
                {"q5.27","b" },
                {"q5.28","b" },
                {"q5.29","a" },
                {"q5.30","a" },
                {"q5.31","d" },
                {"q5.32","d" },
                {"q5.33","a" },
                {"q5.34","b" },
                {"q5.35","b" },
                {"q5.36","b" },
                {"q5.37","a" },
                {"q5.38","c" },
                {"q5.39","b" },
                {"q5.40","d" },
                {"q5.41","b" },
                {"q5.42","b" },
                {"q5.43","b" },
                {"q5.44","d" },
                {"q5.45","a" },
                {"q5.46","b" },
                {"q5.47","c" },
                               
                //Chapter 6
                {"q6.1","d" },
                {"q6.2","b" },
                {"q6.3","c" },
                {"q6.4","c" },
                {"q6.5","b" },
                {"q6.6","b" },
                {"q6.7","b" },
                {"q6.8","c" },
                {"q6.9","a" },
                {"q6.10","b" },
                {"q6.11","c" },
                {"q6.12","a" },
                {"q6.13","c" },
                {"q6.14","b" },
                {"q6.15","b" },
                {"q6.16","a" },
                {"q6.17","a" },
                {"q6.18","a" },
                {"q6.19","b" },
                {"q6.20","a" },
                {"q6.21","a" },
                {"q6.22","b" },
                {"q6.23","b" },
                {"q6.24","b" },
                {"q6.25","a" },
                {"q6.26","c" },
                {"q6.27","b" },
                {"q6.28","c" },
                {"q6.29","b" },
                {"q6.30","d" },
                {"q6.31","b" },
                {"q6.32","a" },
                {"q6.33","b" },
                {"q6.34","a" },
                {"q6.35","b" },
                
                //Chapter 7
                {"q7.1","a" },
                {"q7.2","b" },
                {"q7.3","b" },
                {"q7.4","d" },
                {"q7.5","b" },
                {"q7.6","c" },
                {"q7.7","b" },
                {"q7.8","a" },
                {"q7.9","a" },
                {"q7.10","a" },
                {"q7.11","d" },
                {"q7.12","d" },
                {"q7.13","a" },
                {"q7.14","c" },
                {"q7.15","b" },
                {"q7.16","a" },
                {"q7.17","d" },
                {"q7.18","a" },
                {"q7.19","b" },
                {"q7.20","a" },
                {"q7.21","a" },
                {"q7.22","d" },
                {"q7.23","b" },
                {"q7.24","b" },
                {"q7.25","a" },
                {"q7.26","a" },
                {"q7.27","d" },
                {"q7.28","b" },
                {"q7.29","b" },
                {"q7.30","c" },
                {"q7.31","b" },
                {"q7.32","c" },
                {"q7.33","b" },
                {"q7.34","a" },
                {"q7.35","b" },
                {"q7.36","c" },
                {"q7.37","c" },
                {"q7.38","b" },
                {"q7.39","b" },
                {"q7.40","c" },
                {"q7.41","d" },
                {"q7.42","a" },
                {"q7.43","a" },
                {"q7.44","b" },
                {"q7.45","a" },
                {"q7.46","b" },
                {"q7.47","d" },
                {"q7.48","b" },
                
                //Chapter 8
                {"q8.1","b" },
                {"q8.2","b" },
                {"q8.3","d" },
                {"q8.4","a" },
                {"q8.5","b" },
                {"q8.6","c" },
                {"q8.7","c" },
                {"q8.8","b" },
                {"q8.9","b" },
                {"q8.10","b" },
                {"q8.11","b" },
                {"q8.12","b" },
                {"q8.13","b" },
                {"q8.14","d" },
                {"q8.15","a" },
                {"q8.16","a" },
                {"q8.17","a" },
                {"q8.18","b" },
                {"q8.19","d" },
                {"q8.20","a" },
                {"q8.21","d" },
                {"q8.22","a" },
                {"q8.23","c" },
                {"q8.24","b" },
                {"q8.25","c" },
                {"q8.26","d" },
                {"q8.27","b" },
                {"q8.28","d" },
                {"q8.29","c" },
                {"q8.30","a" },
                {"q8.31","a" },
                {"q8.32","d" },
                {"q8.33","c" },
                {"q8.34","c" },
                {"q8.35","b" },
                {"q8.36","c" },
                {"q8.37","c" },
                {"q8.38","a" },
                {"q8.39","b" },
                {"q8.40","c" },
                {"q8.41","c" },
                {"q8.42","a" },
                {"q8.43","c" },
                {"q8.44","b" },
                {"q8.45","b" },
                {"q8.46","c" },
                {"q8.47","c" },
                {"q8.48","a" },
                {"q8.49","c" },
                {"q8.50","a" },
                
                //Chapter 9
                {"q9.1","b" },
                {"q9.2","b" },
                {"q9.3","b" },
                {"q9.4","b" },
                {"q9.5","a" },
                {"q9.6","c" },
                {"q9.7","b" },
                {"q9.8","a" },
                {"q9.9","b" },
                {"q9.10","d" },
                {"q9.11","a" },
                {"q9.12","b" },
                {"q9.13","b" },
                {"q9.14","b" },
                {"q9.15","a" },
                {"q9.16","c" },
                {"q9.17","a" },
                {"q9.18","c" },
                {"q9.19","c" },
                {"q9.20","b" },
                {"q9.21","b" },
                {"q9.22","a" },
                {"q9.23","c" },
                {"q9.24","d" },
                {"q9.25","a" },

            };

            bool testMe = true;
            while (testMe)
            {
                Console.Clear();
                // Creates exam array for exam questions
                Random rdm = new Random();
                int[,] examQuestions = new int[7, 7];
                Shuffle(rdm, examQuestions); // shuffle each new exam

                List<string> list = new List<string>() { " " };


                int correct = 0;
                foreach (var set in Questions)
                {
                    if (list.Count < 281)
                    {
                        list.Add(set.Key);
                    }
                }

                int examNum = 1;
                foreach (var examQuestion in examQuestions)
                {
                    Console.WriteLine(examNum + ".)");
                    Console.Write(list[examQuestion - 1] + ": ");
                    Console.WriteLine(Questions[list[examQuestion - 1]] + "\n");
                    Console.WriteLine(options[list[examQuestion - 1]]);
                    string input = Console.ReadLine();

                    if (input == answers[list[examQuestion - 1]])
                    {
                        Console.WriteLine("Good job!\n\n");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect!\n The correct answer is: {answers[list[examQuestion - 1]]}\n\n");

                    }
                    ++examNum;
                }
                string again = "k";
                while (again != "y" && again != "n")
                {
                    Console.WriteLine($"Good job! You scored {Math.Round(correct / 0.49, 2)}%");
                    Console.WriteLine("Would you like to try again? (y/n)");
                    again = Console.ReadLine();
                    if (again == "y")
                    {
                        testMe = true;
                    }
                    else if (again == "n")
                    {
                        testMe = false;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter 'y' for yes, or 'n' for no!");

                    }
                }
            }
        }

        private static void Shuffle(Random rdm, int[,] examQuestions)
        {
            for (var row = 0; row < examQuestions.GetLength(0); ++row)
            {
                for (var column = 0; column < examQuestions.GetLength(1); ++column)
                {
                    switch (row)
                    {
                        // Chapter 3
                        case 0:
                            List<int> aux0 = new List<int>();
                            while (aux0.Count < 8)
                            {
                                int random = rdm.Next(1, 36);
                                while (aux0.Contains(random))
                                {
                                    random = rdm.Next(1, 36);
                                };
                                aux0.Add(random);
                            }
                            examQuestions[row, column] = aux0[column];
                            break;
                        // Chapter 4
                        case 1:
                            List<int> aux1 = new List<int>();
                            while (aux1.Count < 8)
                            {
                                int random = rdm.Next(36, 77);
                                while (aux1.Contains(random))
                                {
                                    random = rdm.Next(36, 77);
                                };
                                aux1.Add(random);
                            }
                            examQuestions[row, column] = aux1[column];
                            break;
                        // Chapter 5
                        case 2:
                            List<int> aux2 = new List<int>();
                            while (aux2.Count < 8)
                            {
                                int random = rdm.Next(77, 125);
                                while (aux2.Contains(random))
                                {
                                    random = rdm.Next(77, 125);
                                };
                                aux2.Add(random);
                            }
                            examQuestions[row, column] = aux2[column];
                            break;
                        // Chapter 6
                        case 3:
                            List<int> aux3 = new List<int>();
                            while (aux3.Count < 8)
                            {
                                int random = rdm.Next(125, 161);
                                while (aux3.Contains(random))
                                {
                                    random = rdm.Next(125, 161);
                                };
                                aux3.Add(random);
                            }
                            examQuestions[row, column] = aux3[column];
                            break;
                        // Chapter 7
                        case 4:
                            List<int> aux4 = new List<int>();
                            while (aux4.Count < 8)
                            {
                                int random = rdm.Next(161, 210);
                                while (aux4.Contains(random))
                                {
                                    random = rdm.Next(161, 210);
                                };
                                aux4.Add(random);
                            }
                            examQuestions[row, column] = aux4[column];
                            break;
                        // Chapter 8
                        case 5:
                            List<int> aux5 = new List<int>();
                            while (aux5.Count < 8)
                            {
                                int random = rdm.Next(210, 261);
                                while (aux5.Contains(random))
                                {
                                    random = rdm.Next(210, 261);
                                };
                                aux5.Add(random);
                            }
                            examQuestions[row, column] = aux5[column];
                            break;
                        // Chapter 9
                        case 6:
                            List<int> aux6 = new List<int>();
                            while (aux6.Count < 8)
                            {
                                int random = rdm.Next(261, 281);
                                while (aux6.Contains(random))
                                {
                                    random = rdm.Next(261, 281);
                                };
                                aux6.Add(random);
                            }
                            examQuestions[row, column] = aux6[column];
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}

