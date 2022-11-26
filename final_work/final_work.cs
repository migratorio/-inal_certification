// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Наберите 'END', если хотите прекратить ввод");
string[] arrUser = GetArrayFromUser("Введите ", "-й элемент массива: ");

string[] arrFixedLength = GetArrayFixedLength(arrUser);

PrintResult(arrUser, arrFixedLength);

//============================FUNCTIONS=========================================
//Функция создаёт пользовательский строковый массив
static string[] GetArrayFromUser(string message1, string message2)
{
    string[] tempArr = new string[1];
    for(int i = 0; ; i++)	// Бесконечный цикл, прерываемый пользователем
    {
        Console.Write(message1 + i + message2);
	    string y = Console.ReadLine() ?? "";
        
        string endArr = "END";  // прерываем ввод элементов массива по набору "END"
        int resCompare = endArr.CompareTo(y);
        if (resCompare == 0) 
	        break;

    	Array.Resize(ref tempArr, i + 1);	//Меняем размер массива по мере увеличения количества его элементов
    	tempArr[i] = y;   
    }
    return tempArr;
}

//---------------------------------------
//Функция фильтрует пользовательский массив и создаёт новый, строки которого содержат не более 3-х символов
static string[] GetArrayFixedLength(string[] arr)
{
    int j = 0;
    string[] tempArr = new string[1];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            Array.Resize(ref tempArr, j+1);	//Меняем размер массива по мере увеличения количества его элементов
            tempArr[j] = arr[i];
            j++;
        }
    }
    return tempArr;
}
//---------------------------------------
//Функция выводит в консоль нпчальный и отфильтрованный массивы
static void PrintResult(string[] arr1, string[] arr2)
{
    for(int i = 0; i < arr1.Length; i++)
    {
        if(i < arr1.Length -1)
            Console.Write($"'{arr1[i]}',");
        else
            Console.Write($"'{arr1[i]}' -> ");
    }
    for(int i = 0; i < arr2.Length; i++)
    {
        if(i < arr2.Length -1)
            Console.Write($"'{arr2[i]}',");
        else
            Console.Write(arr2[i]);
    }
}