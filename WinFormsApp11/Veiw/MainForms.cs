using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11.Fake_Depo;
using WinFormsApp11.Models;
using WinFormsApp11.User_Control;

namespace WinFormsApp11.Veiw
{
    public partial class MainForms : Form
    {

        const string _apiKey = "580270e";
        const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";

        public MainForms()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string search = $"{_url}&t={textBox1.Text}";


            using HttpClient client = new();
            string jsonStr = await client.GetStringAsync(search);


            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);


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
    }
}
