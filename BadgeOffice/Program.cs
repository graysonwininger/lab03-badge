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
string username = fullName[0] + lastName;
username = username.ToLower();

//Creates first and last initials
string firstInitial = firstName[0].ToString();
string lastInitial = lastName[0].ToString();

//Displays to screen
Console.WriteLine("Name on badge:" + nameOnBadge);
Console.WriteLine("Username:" + username);
Console.WriteLine("Initials:" + firstInitial + "." + lastInitial + ".");
Console.WriteLine("Letters in last name:" + lastName.Length);