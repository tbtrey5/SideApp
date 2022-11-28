namespace Object
{
    public class MovieUtility
    {
        //Responsible for getting all the movies
  
        private Movies[] inventory;


        public MovieUtility(Movies[] inventory)
        {
            this.inventory = inventory;
            //may be able to make nother tracking transactions the same way
        }
        public void GetAllMovies()
        {
        Movies.SetCount(0);
        StreamReader inFile = new StreamReader("movieinventory.txt");
        string line = inFile.ReadLine();

        while(line != null)
        {
            string[] temp = line.Split('#');

            inventory[Movies.GetCount()] = new Movies(int.Parse(temp[0]), temp[1], temp[2], bool.Parse(temp[3]));

            Movies.IncCount();
            line = inFile.ReadLine();
        }
        


        inFile.Close();
        }

    }
}