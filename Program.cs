string[] arr = { "Test1", "aa", "hello", "(-:"};
int quantityElements = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length <= 3)
    {
        quantityElements++;
    }
}

string[] arrRes = new string[quantityElements];
int k = 0;
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j].Length <= 3)
    {
        arrRes[k] = arr[j];
        k++;
    }
}
