namespace Object
{
    public class MovieReports
    {
        private Movies[] inventory;

        public MovieReports(Movies[] inventory)
        {
            this.inventory = inventory;
        }


        public void PrintAllMovies()
        {
            for(int i = 0; i < Movies.GetCount(); i++)
            {
                System.Console.WriteLine(inventory[i].ToString());
            }
        }

            //Add Top 5
            public void Top5()
            {
                int sum = 0;

                for(int i = 0; i < Movies.GetCount(); i++)
                {
                    sum += inventory[i].GetMovieID();
                }

                System.Console.WriteLine($"The Average movie is {sum/Movies.GetCount()}");
            }

    }
}