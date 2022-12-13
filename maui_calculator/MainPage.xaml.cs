namespace maui_calculator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Calculate(object sender, EventArgs e)
	{
		// Get input from entry No1 and entry No2 and convert to int
		int one = int.Parse(No1.Text);
		int two = int.Parse(No2.Text);

		// Get selected index from picker and save in variable
        int selected = Select.SelectedIndex;

        //Declare result variable
        int result;

		// Control what index user chose and calculate numbers accordingly
		switch(selected)
		{ 
			case 0: result = one + two;
				Result.Text = $"{result}";
                break;
			case 1: result = one - two;
                Result.Text = $"{result}";
                break;
            case 2: result = one * two;
                Result.Text = $"{result}";
                break;
            case 3: result = one / two;
                Result.Text = $"{result}";
                break;
			default: Result.Text =  "Välj räknesätt";
				break;
        }

		SemanticScreenReader.Announce(Result.Text);
	}

}

