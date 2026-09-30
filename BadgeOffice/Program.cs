//Badge Office

//To create random numbers
Random rng = new Random();

//Prompts for name, then sets it as variable for full name and trims it
Console.WriteLine("What is your full name?");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

//Creates first name and last name
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

//Creates name on badge
string nameOnBadge = fullName.ToUpper();

//Creates username
string username = firstName[0] + lastName;
username = username.ToLower();

//Creates first and last initials
string firstInitial = firstName[0].ToString();
string lastInitial = lastName[0].ToString();

//Displays name on badge, username, initials, and letters in last name 
Console.WriteLine("Name on badge:" + nameOnBadge);
Console.WriteLine("Username:" + username);
Console.WriteLine("Initials:" + firstInitial + "." + lastInitial + ".");
Console.WriteLine("Letters in last name:" + lastName.Length);

//Creates random numbers for studentID and locker number
int studentIdentification = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1,501);

//Displays studdentID and locker number
Console.WriteLine("StudentID:" + studentIdentification);
Console.WriteLine("Locker number:" + lockerNumber);