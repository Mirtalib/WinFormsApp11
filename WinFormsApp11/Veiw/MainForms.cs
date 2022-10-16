using System.Text.Json;
using WinFormsApp11.Fake_Depo;
using WinFormsApp11.Models;
using WinFormsApp11.User_Control;

namespace WinFormsApp11.Veiw;

public partial class MainForms : Form
{

    public MainForms()
    {
        InitializeComponent();
    }

    private void MainForms_Load(object sender, EventArgs e)
    {
        for (int i = FakeDepo.GetMovies().Count - 1; i >= 0; i--)
        {
            var userControl = new UC_Movies(FakeDepo.GetMovies()[i]);
            userControl.Dock = DockStyle.Top;
            panel2.Controls.Add(userControl);
  
        }
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        const string _apiKey = "580270e";
        const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";

        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            MessageBox.Show("Enter Movie Name");
            return;
        }

        string search = $"{_url}&t={textBox1.Text}";
        using HttpClient client = new();
        string jsonStr = await client.GetStringAsync(search);
        var movie = JsonSerializer.Deserialize<Movie>(jsonStr);

        if (movie?.Title is null)
        {
            MessageBox.Show("No Such Movie");
            return;
        }

        MovieForm movieForm = new(movie!);

        DialogResult dialogResult = movieForm.ShowDialog();

        if (dialogResult == DialogResult.OK)
        {
            var userControl = new UC_Movies(movie!);
            userControl.Dock = DockStyle.Top;
            panel2.Controls.Add(userControl);
            return;
        }
    }
}
