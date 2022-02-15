// See https://aka.ms/new-console-template for more information


var studentNames = new List<string>{"Tobi Foller","Yenti Buchanan","Morrie Wong"};                   

var subjectNames = new List<string>{"Music","Biology","Chemistry"};                   

var studentTfoller = new List<string>{"Music","Biology","Chemistry"};                                                                                   

var studentYbuchanan = new List<string>{"Biology","Chemistry"};

var studentMwong = new List<string>{"Biology"};

var musicStudents = new List<string>{"Tobi Foller","Yenti Buchanan"};

var biologyStudents = new List<string>{"Tobi Foller","Yenti Buchanan","Morrie Wong"};

var chemistryStudents = new List<string>{"Tobi Foller","Yenti Buchanan"};

WelcomeMessage();

GiveInstructions();

while (true)
{
   var userInput = 0;
   Console.WriteLine("Which option would you like to execute? Please enter the number."); // need to add a looped msg to user if they dont type a number
   int.TryParse(Console.ReadLine(), out userInput);

if (userInput == 0) // if user enters 0 exit student admin
    {
        break;     
    }

switch (userInput)
{
    case 1:   // if user enters 1, give list of students
     Console.WriteLine("You have entered 1, here is a list of students.\n");
    
    foreach (var students in studentNames)
    {
        Console.WriteLine($"\t{students}\n"); 
    }
    break;

    case 2:   // if user enters 2, give list of subjects
     Console.WriteLine("You have entered 2, here is a list of subjects.\n"); 

     foreach (var subjects in subjectNames)
     {
         Console.WriteLine($"\t{subjects}\n"); // if user enters 2, give list of subjects
     }
     break;

     case 3: // enrol new student
      
      var addingEnrolment = true;

      while(addingEnrolment)
      {
      Console.WriteLine("Option 3, please enter the name of the student you would like to enrol.\n"); // if user enters 3 execute add student name to list
      studentNames.Add(Console.ReadLine().Trim()); //fix possible null ref
      
      Console.WriteLine("Would you like to enrol another? Enter Y or N.\n"); // give user option to add another student in 1 go

      if (Console.ReadLine().ToUpper() != "Y") //fix possible null ref
      
      addingEnrolment = false;
      }
      break;

      case 4: // delete student from enrolment

       var deletingEnrolment = true;

       while(deletingEnrolment)
      {
      Console.WriteLine("Option 4, please enter the name of the student you would like to un-enrol.\n"); // if user enters 4 execute delete student name from list
      studentNames.Remove(Console.ReadLine().Trim()); //fix possible null ref
      
      Console.WriteLine("Would you like to un-enrol another? Enter Y or N.\n"); // give user option to delete another student in 1 go

      if (Console.ReadLine().ToUpper() != "Y") //fix possible null ref

      deletingEnrolment = false;
      }
      break;
      
      case 5: // new subject
      
      var addingSubject = true;

      while(addingSubject)
      {
      Console.WriteLine("Option 5, please enter the name of the subject you would like to add.\n"); 
      subjectNames.Add(Console.ReadLine().Trim()); //fix possible null ref
      
      Console.WriteLine("Would you like to add another subject? Enter Y or N.\n");

      if (Console.ReadLine().ToUpper() != "Y") //fix possible null ref
      
      addingSubject = false;
      }
      break;
      
      case 6: 

       var deletingSubject = true;

       while(deletingSubject)
      {
      Console.WriteLine("Option 6, please enter the name of the subject you would like to remove.\n"); 
      subjectNames.Remove(Console.ReadLine().Trim()); //fix possible null ref
      
      Console.WriteLine("Would you like to remove another subject? Enter Y or N.\n"); 

      if (Console.ReadLine().ToUpper() != "Y") //fix possible null ref

      deletingSubject = false;
      }
      break;

      case 7:   
    {
        Console.WriteLine("Please enter the full name of the student whoes subjects you would like to see.");
    var inputstudentDetails = Console.ReadLine().Trim().ToLower().Replace(" ", "");
    switch (inputstudentDetails)
    {
        case "tobifoller":
        Console.WriteLine("Tobi Foller is enrolled in the following subjects:\n");
    
    foreach (var studentDetails in studentTfoller)
    {
        Console.WriteLine($"\t{studentDetails}\n"); 
    }
    break;

        case "yentibuchanan":
        Console.WriteLine("Yenti Buchanan is enrolled in the following subjects:\n");
    
    foreach (var studentDetails in studentYbuchanan)
    {
        Console.WriteLine($"\t{studentDetails}\n"); 
    }
    break;

        case "morriwong":
        Console.WriteLine("Morri Wong is enrolled in the following subjects:\n");
    
    foreach (var studentDetails in studentMwong)
    {
        Console.WriteLine($"\t{studentDetails}\n"); 
    }
    break;
    
    default:
    Console.WriteLine("Sorry your input was not regconised, please try again.");

    break;
    }
    }
    break;
      
      default:
       ErrorMessageWrongInput();
       Console.WriteLine(" ");
       GiveInstructions();
      break;

     

    }

}



static void WelcomeMessage()
{
 Console.WriteLine("Welcome to the Universities Admin Centre.");
 Console.WriteLine("Here you will be able to choose from the following numeric options:\n");  
}

static void GiveInstructions() // list options for user
{
 Console.WriteLine("1 = See a list of students at the university");
 Console.WriteLine("2 = See a list of subjects at the university");
 Console.WriteLine("3 = Enrol a new student at the university");
 Console.WriteLine("4 = Unenrol a student");
 Console.WriteLine("5 = Add a new subject to the university catalogue");
 Console.WriteLine("6 = Remove a subject from the university catalogue");
 Console.WriteLine("7 = See a list of subjects that each student is enrolled in");
 Console.WriteLine("0 = Exit");
 Console.WriteLine(""); 
}

static void ErrorMessageWrongInput()  
{
 Console.WriteLine("Sorry, that was an incorrect input. Please look at the options again."); 
}

// static void StudentDetails(List<string> studentTfoller, List<string> studentYbuchanan, List<string> studentMwong)
// {
//     Console.WriteLine("Please enter the full name of the student whoes subjects you would like to see.");
//     var inputstudentDetails = Console.ReadLine().Trim().ToLower();
//     switch (inputstudentDetails)
//     {
//         case "tobifoller":
//         Console.WriteLine("Tobi Foller is enrolled in the following subjects:\n");
    
//     foreach (var studentDetails in studentTfoller)
//     {
//         Console.WriteLine($"\t{studentDetails}\n"); 
//     }
//     break;

//         case "yentibuchanan":
//         Console.WriteLine("Yenti Buchanan is enrolled in the following subjects:\n");
    
//     foreach (var studentDetails in studentYbuchanan)
//     {
//         Console.WriteLine($"\t{studentDetails}\n"); 
//     }
//     break;

//         case "morriwong":
//         Console.WriteLine("Morri Wong is enrolled in the following subjects:\n");
    
//     foreach (var studentDetails in studentMwong)
//     {
//         Console.WriteLine($"\t{studentDetails}\n"); 
//     }
//     break;
    
//     default:
//     Console.WriteLine("Sorry your input was not regconised, please try again.");

//     break;
//     }
// }






