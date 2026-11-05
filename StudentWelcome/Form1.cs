namespace StudentWelcome;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnWelcome_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        lblMessage.Text = name.Length == 0 ? "Please enter your name." : $"Welcome, {name}!";
    }
}
