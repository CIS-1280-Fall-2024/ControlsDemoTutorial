namespace ControlsDemo;

public partial class CheckboxDemoPage : ContentPage
{
	public CheckboxDemoPage()
	{
		InitializeComponent();
	}

    private void btnSubmit_Clicked(object sender, EventArgs e)
    {
		string result = "";

		if (checkBox1.IsChecked)
		{
			result += "Checkbox 1\n";
		}
		if (checkBox2.IsChecked)
		{
			result += "Checkbox 2\n";
		}
		if (checkBox3.IsChecked)
		{
			result += "Checkbox 3";
		}

		lblResults.Text = result;
    }
}