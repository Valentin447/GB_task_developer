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