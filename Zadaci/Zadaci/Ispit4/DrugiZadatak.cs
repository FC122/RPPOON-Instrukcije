namespace DrugiZadatakIspit4
{
    //Refaktoriraj
    class DrugiZadatak
    {
        public static List<char> uniqueChars(string text)
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                int occurrenceCount = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        occurrenceCount++;
                    }
                }
                if (occurrenceCount == 1)
                {
                    chars.Add(text[i]);
                }
            }
            return chars;
        }
    }

}