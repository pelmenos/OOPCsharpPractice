Dictionary<char, int> sym = new Dictionary<char, int>()
{
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000}
};

char[] number = Console.ReadLine().ToArray();
int ans = 0;
char prevNum = number[0];
for (int i = 0; i < number.Length; i++)
{
    if (prevNum != number[i])
    {
        if (sym[prevNum] < sym[number[i]])
        {
            ans -= sym[prevNum];
            ans += sym[number[i]] - sym[prevNum];
            prevNum = number[i];
            continue;
        }
    }
    ans += sym[number[i]];
    prevNum = number[i];
}

Console.WriteLine(ans);