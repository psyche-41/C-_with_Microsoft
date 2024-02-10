Console.Write("Input: ");
string sentence = Console.ReadLine();

char[] inSentence = sentence.ToCharArray();

string reversedString = new string(inSentence.Reverse().ToArray());
Console.WriteLine(reversedString);

int x = inSentence.Length;
char[] store = new char[x];

for (int i = 0; i < x; i++)
{
    char c = inSentence[i];
    if (Array.IndexOf(store, c) == -1)
    {
        int count = 0;
        for (int j = i + 1; j < x; j++)
        {
            if (inSentence[i] == inSentence[j])
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("The letter " + inSentence[i] + " appeared " + (count + 1) + " times.");
        }
    store[i] = c;
    }
}
