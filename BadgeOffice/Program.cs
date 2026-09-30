/*
*Name:        Grayson Wininger
*Course:      CSCI 1250, Section 001
*Assignment:  Lab 03, The Badge Office
*Date:        September 30, 2026
*Description: Builds a student badge from a name, two random assignments,
*.            and the walking distance to a first class
*/

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

//Prompts for x and y for dorm and classroom, prompts for walking speed, takes user input for all
Console.WriteLine("What is the dorm's x?");
int dormX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the dorm's y?");
int dormY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the classroom's x?");
int classroomX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the Classroom's y?");
int classroomY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your walking speed in feet per second?");
Double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(classroomX - dormX,2) + Math.Pow(classroomY - dormY,2));
int walkTimeQuotient = Convert.ToInt32(distance) / Convert.ToInt32(walkingSpeed);
int walkingTimeRemainder = Convert.ToInt32(distance) % Convert.ToInt32(walkingSpeed);

string walkTime = walkingTimeRemainder + " " + "min" + " " + walkingTimeRemainder + " " + "sec";

