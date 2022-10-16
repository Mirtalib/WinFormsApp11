using WinFormsApp11.Models;
using WinFormsApp11.User_Control;

namespace WinFormsApp11.Veiw;

public partial class MovieForm : Form
{
    
    public MovieForm(Movie _movie)
    {
        InitializeComponent();
        var userControl = new UC_Movies(_movie!);
        userControl.Dock = DockStyle.Top;
        panel1.Controls.Add(userControl);
    }

    private void button1_Click(object sender, EventArgs e)
        => DialogResult = DialogResult.OK;

    private void btnCancel_Click(object sender, EventArgs e)
        => DialogResult = DialogResult.Cancel;
}
