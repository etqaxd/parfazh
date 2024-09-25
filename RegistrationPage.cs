namespace parfazh;

public class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};

        Title = "Common";
        Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
       
    }
}