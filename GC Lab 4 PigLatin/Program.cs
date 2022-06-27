bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Enter a word");
    string line = Console.ReadLine().ToLower().Trim();
    string[] phrase = line.Split(" ");
    string pigLatin = "";

    foreach (string word in phrase)
        {  
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char firstLetter = word[0]; 
            if (vowels.Contains(firstLetter))
            {
                string x = vowelFirst(word);
                pigLatin += x + " ";
            }
            else
            {
                string y = checkForVowels(line);
                pigLatin += y + " ";
            }
        }
   //if word starts with vowel
   static string vowelFirst (string line)
    {
        return line + "way";
    }

    //if word starts with consonant: finding the first vowel
    static string checkForVowels(string line)
    {
        string modifiedWord = "";
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < line.Length; i++)
        {
            if (vowels.Contains(line[i]))
            {
                modifiedWord = line.Substring(i, line.Length - i) + line.Substring(0, i) + "ay";
                break;
            }
        }
        return modifiedWord;
    }

    Console.WriteLine(pigLatin);

    //loop back to start
    Console.WriteLine("Would you like to translate again? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "n")
    {
        runProgram = false;
    }
}





