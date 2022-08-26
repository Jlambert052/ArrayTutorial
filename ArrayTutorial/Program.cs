// See https://aka.ms/new-console-template for more information
int[] bowlscores = new int[3];
Console.WriteLine("Enter the score of your first bowling game: ");
string bowl1 = Console.ReadLine();
bowlscores[0] = Convert.ToInt32(bowl1);

Console.WriteLine("Enter the score of your second bowling game: ");
string? bowl2 = Console.ReadLine();
bowlscores[1] = Convert.ToInt32(bowl2);

Console.WriteLine("Enter the score of your third bowling game: ");
string? bowl3 = Console.ReadLine();
bowlscores[2] = Convert.ToInt32(bowl3);

int totalbowl = bowlscores[0] + bowlscores[1] + bowlscores[2];
Console.WriteLine($"Your total game score is {bowlscores[0]}, {bowlscores[1]}, and {bowlscores[2]} which adds up to {totalbowl}.");
//BOWLING GAME AND array entry.

/*
int[] games = { 145, 264, 244 };
int seriesScore = games[0] + games[1] + games[2];
Console.WriteLine(seriesScore); //OR

//inside of the braces variables can be evaluated and then arithmetic operations, which enters the string.
Console.WriteLine($"The Series score is {games[0] + games[1] + games[2]}"); 
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {myNumber}");

Console.WriteLine("Guess a number from 1 to 10: ");
Console.Write("Enter a string please, and press enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed {response}. Thanks.");


string[] names = { "jack", "ian", "billy", "josh", "caleb", "sam", "james", "karl" }; // can leave out  otherside of assignment (new string[]) and it will recognize.
//Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}, {names[3]}, {names[4]}, {names[5]}, {names[6]}, {names[7]}");

string[] names2 = new string[8];
names2[0] = "jack";
names2[1] = "ian";
names2[2] = "billy";
names2[3] = "josh";
names2[4] = "caleb";
names2[5] = "sam";
names2[6] = "james";
names2[7] = "karl";
//Console.WriteLine($"{names2[0]}, {names2[1]}, {names2[2]}, {names2[3]}, {names2[4]}, {names2[5]}, {names2[6]}, {names2[7]}");

int[] scores = new int[5];
scores[0] = 100; //puts the value in the first slot for scores. Arrays start with slot 0.
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],5}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");

int[] scores2 = new int[] { 95, 97, 100, 93, 100 };  //exception to the no semicoon after brace rule.
Console.WriteLine($"{scores2[0],5}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5}");

*/
