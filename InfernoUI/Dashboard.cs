namespace InfernoUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // Validate the API URL


        try
        {
            systemStatus.Text = "Calling API...";

            await Task.Delay(2000); // Simulate network delay

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error occurred while calling API.";
        }
    }

    private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }
}
