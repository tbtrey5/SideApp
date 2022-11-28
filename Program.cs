using Object;
Movies[] inventory = new Movies[50];
MovieUtility utility = new MovieUtility(inventory);
MovieReports reports = new MovieReports(inventory);

utility.GetAllMovies();
reports.PrintAllMovies();

reports.Top5();
