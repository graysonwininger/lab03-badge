/*
*Name:        Grayson Wininger
*Course:      CSCI 1250, Section 001
*Assignment:  Lab 03, The Badge Office
*Date:        September 30, 2026
*Description: Builds a student badge from a name, two random assignments,
*.            and the walking distance to a first class
*/

//To create random numbers
using System.Data;
using System.Security;

Random rng = new Random();

//Part 1: The Name
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
string firstInitial = firstName[0].ToString().ToUpper();
string lastInitial = lastName[0].ToString().ToUpper();

//Displays full name, name on badge, username, initials, and letters in last name 
Console.WriteLine("Full name: " + fullName);
Console.WriteLine("Name on badge: " + nameOnBadge);
Console.WriteLine("Username: " + username);
Console.WriteLine("Initials: " + firstInitial + "." + lastInitial + ".");
Console.WriteLine("Letters in last name: " + lastName.Length);

//Part 2: The Numbers
//Creates random numbers for studentID and locker number
int studentIdentification = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1,501);

//Displays studdentID and locker number
Console.WriteLine();
Console.WriteLine("StudentID: " + studentIdentification);
Console.WriteLine("Locker number:" + " " + lockerNumber);

//Part 3: The Walk
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

//Displays xs, ys, and walking speed
Console.WriteLine("Dorm x: " + dormX);
Console.WriteLine();
Console.WriteLine("Dorm y: " + dormY);
Console.WriteLine();
Console.WriteLine("Classroom x: " + classroomX);
Console.WriteLine("Classroom y: " + classroomY);
Console.WriteLine();
Console.WriteLine("Walking speed in feet per second: " + walkingSpeed);

//Caluclates distance and walking time
double distance = Math.Sqrt(Math.Pow(classroomX - dormX,2) + Math.Pow(classroomY - dormY,2));
double walkTimeQuotient = Convert.ToInt32(distance / walkingSpeed) / 60;
double walkingTimeRemainder = Convert.ToInt32(distance / walkingSpeed) % 60;

//Creates walkTime string
string walkTime = walkTimeQuotient + " min " + walkingTimeRemainder + " sec";

//Calculates the check digit
int studentIdentificationRemainder = studentIdentification % 9;

//Displays distance and walk time
Console.WriteLine();
Console.WriteLine("Distance: " + distance.ToString("F1"));
Console.WriteLine("Walk time: " + walkTime);

//Part 4: The Badge
//Displays badge
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("ETSU STUDENT BADGE".PadLeft(26));
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("NAME".PadRight(10) + nameOnBadge);
Console.WriteLine();
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine();
Console.WriteLine("ID".PadRight(10) + studentIdentification + "-" + studentIdentificationRemainder);
Console.WriteLine();
Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
Console.WriteLine();
Console.WriteLine("WALK".PadRight(10) + walkTime);
Console.WriteLine();
Console.WriteLine("==================================");


