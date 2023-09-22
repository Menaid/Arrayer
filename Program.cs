int[] numbers = { 12, 21, 3, 4, 0, 6, 1, 8, 9 };
for (int i = 0; i < numbers.Length; i++)
{
    sort();
}

foreach (int num in numbers)
{
    Console.Write(num + ", ");
}
void sort()
{
for (int i = 0; i < numbers.Length -1; i++)
{
    int a = numbers[i];
    int b = numbers[i + 1];

    if (a > b)
    {
        numbers[i] = b;
        numbers[i + 1] = b;
    }
}

}

void display()
{
    foreach (int a in numbers)
    {

    }
}