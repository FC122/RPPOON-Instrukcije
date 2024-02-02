namespace dip
{
    /*Dajte primjer pseudokoda koji narusava nacelo dependency 
    inversion te objasnite u cemu se to ogleda i zasto je to problem*/

    class Square
    {
        public int Length { get; private set; }
    }

    class AreaCalculator
    {
        double CalculateArea(Square square)
        {
            return square.Length * square.Length;
        }
    }

    /*Klase na visim razinama ne trebaju ovisiti o klasama na 
    nizim razinama, nego (oboje) trebaju ovisiti o apstrakciji*/

    /*Na primjeru iznad vidi se kresenje DIPa u tome sto AreaCalculator 
    ovisi o klasi Square. To je problem ako u zelimo dodati jos jedan 
    oblik za koji zelimo racunati povrsinu sa klasom area calculator*/
}