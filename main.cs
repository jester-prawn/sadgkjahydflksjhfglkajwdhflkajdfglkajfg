//Main class that you run when you want to start a game of command-line Shonen Showdown
//Handles most of the out-of-game menuing & initializes games
class Main
  {
  public static void main (string[] args)
    {
		//Initialization
		int num = 0;
		string text = "";
		Console.WriteLine("Welcome to Shonen Showdown./n1: Local game/n2: Online Game/n3: Card Database/n4: Exit Game");

		//Primary gameplay loop
		num = Convert.ToInt32(Console.ReadLine());
		while (num !=4){
			switch (num){
				case 1: 
					
					//Initialize local game
					Console.WriteLine("How many players per team?");
					num = Convert.ToInt32(Console.ReadLine());
					if num < 1
					{
						Console.WriteLine("Not enough players!");
					}
					else
					{
						if num > 10
						{
							Console.WriteLine("Are you sure you want that many players? (Y/N)");
							text = Console.ReadLine();
							while (!(text.Equals("Y") || text.Equals("N")))
							{
								
							}
						}
					}
				case 2:
					//Doesn't work yet
					Console.WriteLine("Nope!");
				case 3:
					//Doesn't work yet
					Console.WriteLine("Nope!);
				default:
					Console.WriteLine("Input not recognized! Try again.");
				}
			Console.WriteLine("Thanks for playing!");
			System.Threading.Thread.Sleep(2500);
			return;
			}
		}
}
