using Session_04;

// Exercise 1 *********************************************

Console.WriteLine("Exercise 1\n");
string name = "Giannis Eskioglou";

var ex1 = new Exercise1();

string reversedName = ex1.Reverse(name);
string reversedNameLib = ex1.ReverseWithLib(name);

Console.WriteLine("Reversed name without libraries:   " + reversedName);
Console.WriteLine("Reversed name with libraries:   " + reversedNameLib);
Console.WriteLine();


// Exercise 2 *********************************************

Console.WriteLine("Exercise 2\n");

int number = new Validation().Validate();

var ex2 = new Exercise2();

Console.WriteLine($"Sum: {ex2.Sum(number)}");
Console.WriteLine($"Product: {ex2.Product(number)}");
Console.WriteLine();

// Exercise 3 *********************************************

Console.WriteLine("Exercise 3");

var ex3 = new Exercise3();

number = new Validation().Validate();

int[] primeNumbers = ex3.FindPrimeNumbers(number);

ex3.printArray(primeNumbers);

Console.WriteLine();

// Exercise 4 *********************************************

Console.WriteLine("Exercise 4");

int[] array1 = { 2, 4, 9, 12 };
int[] array2 = { 1, 3, 7, 10 };

var ex4 = new Exercise4();
int[] mulArray = ex4.multiply(array1, array2);
ex3.printArray(mulArray);

Console.WriteLine();

// Exercise 5 * ********************************************

Console.WriteLine("Exercise 5");

int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100};

var ex5 = new Exercise5();
int[] sortedArray = ex5.BubbleSort(array);

ex5.printArray(sortedArray);

int[] secondArray = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

sortedArray = ex5.SelectionSort(secondArray);

ex5.printArray(sortedArray);

