Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine();

string[] originalArray = input.Split(' ');
string[] newArray = new string[originalArray.Length];
int count = 0;

foreach (string element in originalArray)
{
    if (element.Length <= 3)
    {
        newArray[count] = element;
        count++;
    }
}

Array.Resize(ref newArray, count);

Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");

foreach (string element in newArray)
{
    Console.Write(element + " ");
}