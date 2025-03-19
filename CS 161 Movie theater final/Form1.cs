namespace CS_161_Movie_theater_final
{
    public partial class Form1 : Form
    {
        List<string> movieNames;
        List<string> genres;
        List<string> descriptions;
        List<int> ratings = new List<int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize Lists (Read from files)
            movieNames = ReadFile("movie_names");
            genres = ReadFile("movie_genres");
            descriptions = ReadFile("movie_descriptions");
            // Convert string list to int
            List<string> temp = ReadFile("movie_ratings");
            foreach (string r in temp)
            {
                int num = 0;
                if (int.TryParse(r, out num))
                    MessageBox.Show("Parsing Error");
                ratings.Add(num);
            } 

            

            
        }

        private List<string> ReadFile(string filename)
        {
            List<string> items = new List<string>();

            StreamReader sr = new StreamReader(filename + ".txt");
            while (!sr.EndOfStream)
            {
                items.Add(sr.ReadLine());
            }
            sr.Close();

            return items;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
