string[] ArrayStrings = new string[] {"1234", "1", "1567", "-2", "computer science"};

int length = 3; 
int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

