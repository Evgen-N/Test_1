// GeekBrains Test_1

try {}
    catch (Exception e)
    {
    #pragma warning disable CA2200 
    #pragma warning disable CS8600
    #pragma warning disable CS8604
    #pragma warning disable CS8603
        throw e;
    }

int PromptInt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

string PromptString(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    return readInput;
}

void ShowStringArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

string [] GenerateStringArray(int Length)
{
    string [] array= new string[Length];
    for(int i = 0; i < Length; i++)
    {
        array[i] = PromptString($"Enter element number {i + 1}, please: ");
    }
    return array;
}

string [] SortStringArray(string [] startArray)
{
    int counter1 = 0;
    int counter2 = 0;
        for(int i = 0; i < startArray.Length; i++)
    {
        if(startArray[i].Length <= 3) counter1++;
    }

    string [] endArray= new string[counter1];
    
    for(int i = 0; i < startArray.Length; i++)
    {
        if(startArray[i].Length <= 3) 
        {
            endArray[counter2] = startArray[i];
            counter2++;
        }
    }
    return endArray;
}


int Length = PromptInt("Enter the length of the array, please: ");
string [] startArray = GenerateStringArray(Length);
string [] endArray = SortStringArray(startArray);

ShowStringArray(startArray);
Console.Write (" -> ");
ShowStringArray(endArray);