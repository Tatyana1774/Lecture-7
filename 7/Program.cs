// Перебор слов
int n = 1;
void FindWords(string alphabet, char[] word, int Length = 0)
{
    if (Length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[Length] = alphabet[i];
        FindWords(alphabet, word, Length + 1);
    }
}
FindWords("аисв", new char[4]);