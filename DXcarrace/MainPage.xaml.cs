using DXcarrace.Classes;
namespace DXcarrace;


public partial class MainPage : ContentPage
{
	private readonly int screenWidth;
	Car audi;
	Car nissan;
	bool isFinish = false;
	public MainPage()
	{
		InitializeComponent();
		audi = new Car("audi", 220, 10);
		audi.UseFuelRate = 10;
		nissan = new Car("nissan", 180, 3);
		nissan.UseFuelRate = 8;
		LabelCar1.Text = audi.ShowInfo();
		LabelCar2.Text = nissan.ShowInfo();
		
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (!this.isFinish)
		{
			var screenWidth = Application.Current.MainPage.Width;
			this.audiRun(screenWidth);
			this.nissanRun(screenWidth);
			LabelCar1.Text = audi.ShowInfo();
			LabelCar2.Text = nissan.ShowInfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
			ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
			this.isFinish = false;
		}
	}
	private void audiRun(double distance)
	{
		var timeuse = audi.TimeUseFormRun(distance);
		ImageCar1.TranslateTo(distance - 100, 0, timeuse * 1000, Easing.Linear);
	}

	private void nissanRun(double distance)
	{
		var timeuse = nissan.TimeUseFormRun(distance);
		ImageCar2.TranslateTo(distance - 100, 0, timeuse * 1000, Easing.Linear);
	}
}