namespace SestiZadatakIspit5
{
    /*
    Napisite unit test koji provjerava ispravan rad metode dane sljedecim izlistanjem koda
    */
    public class LengthEncoder
    {
        public char ValidCode { get; private set; }
        public char InvalidCode { get; private set; }
        public int LengthCutoff { get; private set; }

        public LengthEncoder(char validCode, char invalidCode, int lengthCutoff)
        {
            ValidCode = validCode;
            InvalidCode = invalidCode;
            LengthCutoff = lengthCutoff;
        }

        public string Encode(List<string> words)
        {
            string code = "";
            foreach (var word in words)
            {
                if (word.Length > LengthCutoff)
                {
                    code += ValidCode;
                }
                else
                {
                    code += InvalidCode;
                }
            }
            return code;
        }
    }

}