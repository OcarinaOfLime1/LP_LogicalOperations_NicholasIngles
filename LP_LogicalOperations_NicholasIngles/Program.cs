// See https://aka.ms/new-console-template for more information

//Nicholas Ingles
//Question: Is a given number even AND positive?

using static System.Formats.Asn1.AsnWriter;

int num = 6;
bool isEven = (num % 2 == 0);
bool isPositive = (num > 0);
bool isEvenAndPositive = isEven && isPositive;

Console.WriteLine($"Is 'num' even and positive? {isEvenAndPositive}");

//Question: Is the user an "admin" OR a "moderator"?

string input = "moderator";
bool isAdmin = input == "admin";
bool isModerator = input == "moderator";
bool isAuthorized = isAdmin || isModerator;

Console.WriteLine($"Is the user authorized? {isAuthorized}");

//Question: Is the voter 18 or older AND 100 or younger?

int age = 21;
bool isAgeAtLeast18 = age >= 18;
bool isAgeAtMost100 = age <= 100;
bool isEligibleToVote = isAgeAtLeast18 && isAgeAtMost100;

Console.WriteLine($"Is the person eligible to vote? {isEligibleToVote}");

//Question: Is the user online AND logged in?

bool isOnline = true;
bool isLoggedIn = true;
bool canAccess = isOnline & isLoggedIn;

Console.WriteLine($"Can the user access? {canAccess}");

//Question: Is players score equal to or greater than 1000 AND less than or equal to 5000?

int playerScore = 1200;
bool isHighScore = playerScore >= 1000;
bool isLowScore = playerScore <= 5000;
bool isHighOrLowScore = isHighScore && isLowScore;

Console.WriteLine($"Is the player's score a high or low score? {isHighOrLowScore}");

//Question: Has the user paid OR the trial has NOT expired?

bool hasPaid = false;
bool isTrialExpired = false;
bool canAccessWithPayment = hasPaid;
bool canAccessWithTrial = isTrialExpired == false;
bool canAccessContent = canAccessWithPayment || canAccessWithTrial;

Console.WriteLine($"Can the user access content? {canAccessContent}");

//Question: Can user access highly secure facility?

bool hasAccessCard = true;
bool hasBiometricScan = true;
int securityClearanceLevel = 6;
bool canEnter = hasAccessCard;
bool canProceedToLevel2 = hasAccessCard && hasBiometricScan;
bool canProceedToLevel3 = hasAccessCard && hasBiometricScan && securityClearanceLevel >= 5;

Console.WriteLine("Level 1 - Can Enter: " + canEnter);
Console.WriteLine("Level 2 - Can Proceed (Biometric Scan): " + canProceedToLevel2);
Console.WriteLine("Level 3 - Can Proceed (Security Clearance): " + canProceedToLevel3);