namespace CS_161_Movie_theater_final
{
    public partial class Form1 : Form
    {
        List<string> movieNames;
        List<string> genres;
        List<string> descriptions;
        List<decimal> prices = new List<decimal>();
        List<int> ratings = new List<int>();

        Dictionary<string, int> indexPairs = new Dictionary<string, int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize Lists (Read from files)
            movieNames = ReadFile("movies_names");
            genres = ReadFile("movies_genres");
            descriptions = ReadFile("movies_descriptions");
            // Convert string list to int
            List<string> temp = ReadFile("movies_ratings");
            foreach (string r in temp)
            {
                int num = 0;
                if (!int.TryParse(r, out num))
                    MessageBox.Show("Parsing Error");
                ratings.Add(num);
            }
            // make price random
            Random rand = new Random();
            for (int i = 0; i < genres.Count; i++)
            {
                prices.Add(rand.Next(50, 100) / 10.0m);
            }

            // Populate Dictionary with indexes
            for (int i = 0; i < movieNames.Count(); i++)
            {
                indexPairs.Add(movieNames[i], i);
            }

            RenderListBox(movieNames);
        }

        private void RenderListBox(List<string> list)
        {
            movieListbox.Items.Clear();
            // Add names to listbox
            foreach (string s in list)
            {
                movieListbox.Items.Add(s);
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
            List<string> tempNames = movieNames.ToList();
            List<string> tempGenres = genres.ToList();
            List<decimal> tempPrices = prices.ToList();

              


            MessageBox.Show(tempNames.Count().ToString());

            // 1) Check if name search matches
            for (int i = 0; i < tempNames.Count(); i++)
            {

            }


            // 2) Check if price range is good
            for (int i = 0; i < tempNames.Count(); i++)
            {
                decimal userInput = decimal.Parse(priceBox.Text);

                if (tempPrices[i] > userInput)
                {
                    tempNames.RemoveAt(i);
                    tempGenres.RemoveAt(i);
                    tempPrices.RemoveAt(i);
                    i--;
                }

            }


            // 3) Check if Genre Matches

            //loop through all movies
            // create string variable that holds which genre current movie is
            // if genre doesnt match the genre selected, remove movie
            for (int i = 0; i < tempNames.Count; i++)
            {
                string[] genreList = {"","","",""};
                if (scaryCheck.Checked) genreList[0] = "Horror";
                if (romanceCheck.Checked) genreList[1] = "Romance";
                if (comedyCheck.Checked) genreList[2] = "Comedy";
                if (famliyCheck.Checked) genreList[3] = "Family";

                if (!(genreList[0] == tempGenres[i] || 
                    genreList[1] == tempGenres[i] ||
                    genreList[2] == tempGenres[i] ||
                    genreList[3] == tempGenres[i])) 
                {
                    tempNames.RemoveAt(i);
                    tempGenres.RemoveAt(i);
                    tempPrices.RemoveAt(i);
                    i--;
                }
            }

            MessageBox.Show(tempNames.Count().ToString());
            RenderListBox(tempNames);
        }

        private void movieListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int index = indexPairs["name"];


            int index = indexPairs[movieListbox.Items[movieListbox.SelectedIndex].ToString()];
            
            nameOutput.Text = movieNames[index];
            costOutput.Text = prices[index].ToString();
            descriptionOutput.Text = descriptions[index];
            
        }
    }
}
