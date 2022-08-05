System.Console.Write("Введите несколько слов или цифр через запятую : ");
char[] separators = { ',', ';' };
int outputArraySize = 0;
int longElementCondition = 3;
string[]  enteredString = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < enteredString.Length; i++)
{
    if (enteredString[i].Length <= longElementCondition)
        outputArraySize++;
}