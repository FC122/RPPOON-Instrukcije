namespace DrugiZadatakRjesenjeIspit5
{
    //Refaktoriraj
    class DrugiZadatak
    {
        public List<string> Palindromes(List<string> strings)
        {
            List<string> palindromes = new List<string>();

            if (strings == null)
            {
                return palindromes;
            }

            foreach (string str in strings)
            {
                if (IsPalindrome(str))
                {
                    palindromes.Add(str);
                }
            }

            return palindromes;
        }

        private bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            string trimmedString = str.Replace(" ", "").ToLower();
            string reversedString = new string(trimmedString.Reverse().ToArray());

            return trimmedString.Equals(reversedString);
        }
    }
}