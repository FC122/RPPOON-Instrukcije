namespace DrugiZadatakIspit5
{
    //Refaktoriraj
    class DrugiZadatak
    {
        public List<string> palindromes(List<string> strings)
        {
            List<string> res = new List<string>();
            if (strings == null) return res;
            foreach (string str in strings)
            {
                string temp1 = str.Replace(" ", "").ToLower();
                string temp2 = new string(temp1.Reverse().ToArray());
                //Palindrome
                if (temp1.Equals(temp2))
                {
                    res.Add(str);
                }
            }
            return res;
        }
    }
}