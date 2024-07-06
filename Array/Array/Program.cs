

Console.WriteLine("!-D Array");

int[] arr = new int[] { 1, 2, 3, 4, 6 };

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine("\n\n2-D Array read");

int[,] arr2 = new int[3, 3] { {1,2,3 }, {4,5,6 }, {7,8,9 } };

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        arr2[i, j] = int.Parse(Console.ReadLine());
//    }
//}

Console.WriteLine("\n\n@-D Array accepted");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(arr2[i, j] + " ");
    }
}

Console.WriteLine("\n\nJagged Array");
int[][] JaggedArray = new int[3][]
{
    new int[]{1,2,3, 4},
    new int[]{4,2,2 },
    new int[]{5,2}
};

for(int i = 0; i<JaggedArray.Length; i++)
{
    Console.Write("Row " + i+" : ");
    for (int j = 0;j < JaggedArray[i].Length; j++)
    {
        Console.Write(JaggedArray[i][j]+" ");
    }
    Console.WriteLine();
}

