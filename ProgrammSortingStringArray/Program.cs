Console.WriteLine("Введите текст");
string userText = Console.ReadLine();


string [] userStringArray = userText.Split(' ');
int size = CounterStringLengthMax3Char(userStringArray);
string [] resultStringArray = new string [size];
SortingStringLengthMax3Char(userStringArray, resultStringArray);

foreach (var sub in resultStringArray)
{
    Console.WriteLine($"{sub}");
} 


int CounterStringLengthMax3Char(string [] inputArray)
{
    int count = 0;
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length < 4)
        {
            count++;
        }
    }
    return count;

}

void SortingStringLengthMax3Char (string [] inputArray1, string [] inputArray2)
{
    for(int i = 0, j = 0; i < inputArray1.Length; i++)
    {
        if(inputArray1[i].Length < 4)
        {
            inputArray2[j] = inputArray1[i];
            j++;
        }
    }

}
