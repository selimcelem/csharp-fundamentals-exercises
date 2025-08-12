//Declaration
int[] intArray; //int array
string[] stringArray; // string array

//Initialization
intArray = new int[5];
stringArray = new string[4];

//Storing the values
intArray[0] = 1;
intArray[1] = 2;
intArray[2] = 3;
intArray[3] = 4;
intArray[4] = 5;

//Storing the values in a single statement

//Option 1
int[] intArray2 = new int[] { 1, 2, 3, 4, 5 };

//Option 2
int[] intArray3 = { 1, 2, 3, 4, 5 };

//Retrieving the values
Console.WriteLine(intArray[4]);

//Printing all the elements
foreach (var item in intArray)
{
    Console.WriteLine(item);
}

//Single dimensional | int[] intArray;

//Multi dimensional | Dimension are specified inside the brackets [] | Comma(,) is used to seperate dimensions
//2D array
int[,] twoDimensionalArray = new int[2, 3]; //2-Rows and 3-Colums
{
    { 1,2,3},
    { 4,5,6},
}
//Access 2D array
Console.WriteLine(twoDimensionalArray[0,1]);

//3-Dimensional array
int[,,] threeD = new int[2, 1, 2]
    {   
        {{1,2}},
        {{3,4}}
    };

//Jagged array
int[][] jaggedArray1 = new int[3][];
jaggedArray1[0] = new int[] { 0, 1, 2, 3 };
jaggedArray1[1] = new int[] { 4, 5 };
jaggedArray1[2] = new int[] { 6, 7 };

//Another example of Jagged array
int[][,] jaggedArray2 = new int[2][,]
    {
        new int[,]{{2,3},{ 4, 5 }},
        new int[,]{{6,7},{8,9},{10,11 }},
    };

//Summary
//Arrays are used to storem multiple elements of same size
//Type can be any valid type
//Array is a reference type
//One you create an array you can't change its dimensions
//Elements are accessed using an index which starts from 0
//There are three different types - Single dimensional, multi dimensional and jagged array