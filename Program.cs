Console.Clear();
Console.WriteLine("Введите размеры массива ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();
double[] arr2 = GetArithmeticMean(arr, m);
PrintArray2(arr2);

int[,] GetArray(int m, int n) 
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)     
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);  
        }              
     }
     return result;
}
double[] GetArithmeticMean(int[,] Array, int m) 
{   
     double[] ArithmeticMean  = new double[Array.GetLength(1)];
     for (int j = 0; j < Array.GetLength(1); j++)     
     {  
        int sum = 0;
        for(int i = 0; i < Array.GetLength(0); i++)
        {
            sum = sum + Array[i, j];
        }
        ArithmeticMean[j] = Convert.ToDouble(sum) / Convert.ToDouble(m);
    }
     return ArithmeticMean;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray2(double[] inArray)
{
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write("{0,6:F1}", inArray[i]);
    }
}