Console.Clear();
Console.Write("Введите элементы массива через запятую: ");
string[] input = Console.ReadLine().Split(',');

string[] output = new string[input.Length];
int j = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[j] = input[i];
        j++;
    }
}
Array.Resize(ref output, j);

Console.WriteLine("Новый массив:");
for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine(output[i]);
}
