using Z2Lib.Enum;

namespace Z2Lib.Model
{
    public class Game
    {
        private string _name;
        private int _releaseYearDate;
        private GenereType _genre;
        private Company _creatorCompany;
        private int _numOfCopiesSold; 
        private decimal _cost;

        public Game(string name, int releaseYearDate, GenereType genre,
            Company creatorCompany, int numOfCopiesSold, decimal cost)
        {
            _name = name;
            if (!(9999 >= releaseYearDate && releaseYearDate >= 1800)) 
            {
                throw new Exception("The year is not in the range from 1800 to 9999.\n" +
                    $"Year = {releaseYearDate}");
            }
            _releaseYearDate = releaseYearDate;
            _genre = genre;
            _creatorCompany = creatorCompany;
            if (!(numOfCopiesSold >= 0))
            {
                throw new Exception("The number of copies sold cannot be less than zero.");
            }
            _numOfCopiesSold = numOfCopiesSold;
            if (!(cost >= 0))
            {
                throw new Exception("The cost of a copy cannot be less than zero.");
            }
            _cost = cost;
        }

        public override string ToString()
        {
            return $"Name: {_name}\n" +
                $"Date release: {_releaseYearDate}\n" +
                $"Genre {_genre}\n" +
                $"Creator: {_creatorCompany}\n" +
                $"Number of copies sold: {_numOfCopiesSold}\n" +
                $"Cost: {_cost}";
        }
    }
}
