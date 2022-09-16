using System.Drawing;

class Program
{
	static void Main()
	{
		while (true)
		{
			int choice = Convert.ToInt32(Control.GetSelect("\n~ WELCOME ~\n\n", new string[] {"Take Screenshot", "Exit"}) + 1);

			if (choice == 1)
			{
				Console.Clear();

				if (!Directory.Exists(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Images"))
					Directory.CreateDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Images");

				Console.WriteLine("Operation is starting...");
				Thread.Sleep(2500);

				Bitmap image = new Bitmap(1925, 1259);
				Size s = new Size(image.Width, image.Height);
				Graphics graphics = Graphics.FromImage(image);
				graphics?.CopyFromScreen(0, 0, 0, 0, s);
				graphics?.CopyFromScreen(0, 0, 0, 0, s);

				string fileName = string.Format($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Images" +
					@"\Image" + ".png");

				Console.WriteLine("\nScreenshot is ready !");
				image?.Save(fileName);
				
				Console.WriteLine("\nPress any key to continue...");
				Console.ReadKey();
			}
			else if (choice == 2)
				Environment.Exit(0);
		}
	}
}