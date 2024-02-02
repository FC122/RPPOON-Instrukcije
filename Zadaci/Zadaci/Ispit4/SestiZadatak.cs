using System.Text;

namespace SestiZadatakIspit4
{
    /*Napisite unit testove (pseudokod) koji provjerava ispravan rad s
     tri razlicita testna slucaja te objasnite koje slucajeve provjeravate 
     i zasto bas njih*/
    public class StringEncoder
    {
        private double threshold;

        public StringEncoder(double threshold)
        {
            this.threshold = threshold;
        }

        public string EncodeAsBinaryString(List<double> values)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (double value in values)
            {
                if (value >= threshold)
                {
                    stringBuilder.Append("A");
                }
                else
                {
                    stringBuilder.Append("a");
                }
            }
            return stringBuilder.ToString();
        }
    }
}