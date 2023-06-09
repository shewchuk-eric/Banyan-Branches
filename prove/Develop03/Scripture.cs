public class Scripture
{
    private string[] _single = new string[] {"Mark","8","33","But when he had turned about and looked on his disciples, he rebuked Peter, saying, Get thee behind me, Satan: for thou savourest not the things that be of God, but the things that be of men."};
    private string[] _multi = new string[] {"Abraham","3","24","25","And there stood one among them that was like unto God, and he said unto those who were with him: We will go down, for there is space there, and we will take of these materials, and we will make an earth whereon these may dwell; And we will prove them herewith, to see if they will do all things whatsoever the Lord their God shall command them;"};
     private string[] _split = new string[] {"D&C","84","19","21","And this greater priesthood administereth the gospel and holdeth the key of the mysteries of the kingdom, even the key of the knowledge of God. And without the ordinances thereof, and the authority of the priesthood, the power of godliness is not manifest unto men in the flesh."};
    private string _verse; // holds the verse as it works through the progressive blanking of individual words
    private string _citation; // holds the verse citation

    public Scripture()
    {
        _verse = VersePicker();
    }

    private string VersePicker()
    {
        Random randomGenerator = new Random(); // create a random number generator
        int number = randomGenerator.Next(0, 15);
        if (number < 5)
            {
               Reference citation = new Reference(_single[0], _single[1], _single[2]);
               _citation = citation.GetCitation();
               string verse = _single[3];
               return verse; 
            }
        else if (number > 4 && number < 10)
            {
               Reference citation = new Reference(_multi[0], _multi[1], _multi[2], _multi[3]);
               _citation = citation.GetCitation();
               string verse = _multi[4];
               return verse;
            }
        else
            {
               string joiner = ",";
               Reference citation = new Reference(_split[0], _split[1], _split[2], joiner, _split[3]);
               _citation = citation.GetCitation();
               string verse = _split[4];
               return verse;
            }
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetCitation()
    {
        return _citation;
    }
}