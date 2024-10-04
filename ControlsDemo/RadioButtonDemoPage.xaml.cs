namespace ControlsDemo;

public partial class RadioButtonDemoPage : ContentPage
{
	public RadioButtonDemoPage()
	{
		InitializeComponent();
	}

    private void submit_Clicked(object sender, EventArgs e)
    {
		string favoriteAnimal = "";
		if (rbCat.IsChecked) { favoriteAnimal = "Cat"; }
        else if (rbDog.IsChecked) { favoriteAnimal = "Dog"; }
        else if (rbElephant.IsChecked) { favoriteAnimal = "Elephant"; }
        else if (rbMonkey.IsChecked) { favoriteAnimal = "Monkey"; }


        string favoriteColor = "";
        if (rbRed.IsChecked) { favoriteColor = "Red"; }
        else if (rbBlue.IsChecked) { favoriteColor = "Blue"; }
        else if (rbGreen.IsChecked) { favoriteColor = "Green"; }
        else if (rbYellow.IsChecked) { favoriteColor = "Yellow"; }

        lblResults.Text = $"Your favorite animal is {favoriteAnimal} and your favorite color is {favoriteColor}.";
    }
}