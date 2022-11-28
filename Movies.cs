namespace Object
{
    public class Movies
    {




        //tracked in movieinventory.txt

        //MovieID
        private int movieID;
        //MovieTitle
        private string movieTitle;
        //Genre
        private string genre;
        //In stock indicator
        private bool inStock;


        private static int count;

        public Movies(int movieID, string movieTitle, string genre, bool inStock)
        {
            this.movieID = movieID;
            this.movieTitle = movieTitle;
            this.genre = genre;
            this.inStock = inStock;

        }

        public static void IncCount()
        {
            count++;
        }
        public Movies()
        {
            //no arg constructor
        }

        public void SetMovieID(int movieID)
        {
            this.movieID = movieID;
        }
        public int GetMovieID()
        {
            return movieID;
        }

        public void SetMovieTitle(string movieTitle)
        {
            this.movieTitle = movieTitle;
        }

        public string GetMovieTitle()
        {
            return movieTitle;
        }

        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public string GetGenre()
        {
            return genre;
        }

        public void GetStock(bool inStock)
        {
            this.inStock = true;
        }
        public bool InStock()
        {
            return true;
        }

        public override string ToString()
        {
            return movieID + "\t" + movieTitle + "\t" + genre + "\t" + inStock;
        }

        public static void SetCount(int count)
        {
            Movies.count = count;
        }

        public static int GetCount()
        {
            return count;
        }


    }
}