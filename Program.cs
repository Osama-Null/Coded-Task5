#region ControlFlow-Ch1
using System.Runtime.CompilerServices;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
#endregion
Console.WriteLine("\n________________\n");
#region ControlFlow-Bonus
int t = 5;
while (t >= 1)
{
    Console.WriteLine(t);
    t--;
}
#endregion
Console.WriteLine("\n________________\n");
#region Arrays-Ch1
string[] arr = { "Sunday [8:00 pm- 3:00 pm]", "Monday [8:00 pm- 3:00 pm]", "Tuesday [8:00 pm- 3:00 pm]", "Wedensday [8:00 pm- 3:00 pm]", "Thursday [8:00 pm- 3:00 pm]" };
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
#endregion
Console.WriteLine("\n________________\n");
#region Arrays-Ch2
int[] arr3 = { 23, 9, 7, 4 };
int temp = 0;
for (int i = 0; i < arr3.Length; i++)
{
    temp += arr3[i];
}

Console.WriteLine(temp);
#endregion
Console.WriteLine("\n________________\n");
#region Arrays-Bonus
//It can be used for creating table with data for example:
string[,] arr4 = { { "23", "9" }, { "9", "4" } };
//Output might be: 23 9
//                  9 4
Console.WriteLine("It can be used for creating table with data for example:\r\nstring[,] arr4 = { { \"23\", \"9\" }, { \"9\", \"4\" } };\r\nOutput might be: 23 9\r\n                  9 4 ");
#endregion