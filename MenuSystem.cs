using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuSystem
{
    class Menu
    {
        static void Main(string[] args)
        {
          MenuRun();
        }

        static void MenuRun()
        {  //creating a list for the menu options
          List<string> MenuList = new List<string>()
          {
          "a) Trinary Converter",
          "b) School Roster",
          "c) ISBN Verifier",
          "q) End the program"
          };

          //menu display
          Console.WriteLine("Choose one of the following options: ");
          Console.WriteLine("-------------------------------------");

          //loop used for displaying list created

          foreach (string menu in MenuList)
          {
            Console.WriteLine(menu);
          }
          //loop = if user enters q, the user will exit the program
          string input = Console.ReadLine().ToLower();
          switch (input)
          {
            
            case "q": //if user enters a, user exit
            {
            break;
            }

            case "a":   //if user enters a, method 'Converter' will start
            {
            Trinary.Converter();
            break;    //break loop after input = a
            }

            case "b":
            {
            School.SchoolRoster();   //if user enters b, method 'SchoolRoster' will start
            break;      ////break loop after input = b
            }

            case "c": //if user enters c, method 'ISBN' will start
            {
            ISBN.VerifyISBN();
            break;        //break loop after input = c
            }     
            
          //error handling
            default:
            {
            Console.WriteLine("Enter only values 'a', 'b', 'c' and 'q'");
            break;
            }
        }
      }
        // Test plan for Trinary Converter:

        /*
        1. Test with empty input:
        User input: " "
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."

        2. Test with only one trinary digit:
        User input: "1"
        Expected output: 1
        Actual output: 1

        3. Test with a large trinary number:
        User input: "1122000120"
        Expected output: 32091
        Actual output: 32091

        4. Test with input containing no numbers:
        User input: "abcdef"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."

        5. Test with input containing only zero:
        User input: "0"
        Expected output: 0
        Actual output: 0

        6. Test with input containing only special characters:
        User input: "_!"£$%"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."

        7. Test with input containing only lower and upper case characters:
        User input: "AaEebD"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."

        8. Test with both trinary numbers and lower case characters:
        User input: "1a220b"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."
        
        9. Test with input containing only one non trinary number:
        User input: "7"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."

        10. Test with input containing large non trinary numbers:
        User input: "457224529"
        Expected output: Error ("Please only enter valid trinary numbers.")
        Actual output: "Please only enter valid trinary numbers."
      
        11. Test with input including the same trinary number:
        User input: "1111111"
        Expected output: 1093
        Actual output: 1093

        12. Test with only one trinary number:
        User input: "2"
        Expected output: 2
        Actual output: 2

        12. Test with only two valid trinary numbers:
        User input: "10"
        Expected output: 3
        Actual output: 3

        12. Test with only three valid trinary numbers:
        User input: "112"
        Expected output: 14
        Actual output: 14


        */


      class Trinary {

      
            public static void Converter()
            {
              Console.WriteLine("Enter a trinary number: ");
              string trinaryNo = Console.ReadLine();   //takes user input as variable trinaryNo


              foreach (char numbers in trinaryNo) {    //error handling, goes through user input and checks for valid trinary numbers
              if (numbers != '1' && numbers != '2' && numbers != '0') {

                Console.WriteLine("Please only enter valid trinary numbers."); }

                else {

              double decimalNo = 0;  //set first value as 0 

              for (int i = 0; i < trinaryNo.Length; i++)  //iterates over each character in TrinaryNo
              {
                char trinaryPosition = trinaryNo[i];
                int trinaryDouble = int.Parse(trinaryPosition.ToString());
                decimalNo = decimalNo * 3 + trinaryDouble;
              }
              
              Console.WriteLine($"The given trinary number {trinaryNo} converted to a decimal number is: {decimalNo}");
              return;
            }
            }
            }
      }

          class School {

            public static void SchoolRoster()
            {

                Dictionary<string, List<string>> school = new Dictionary<string, List<string>>();

                do {
                Console.WriteLine("Please enter student name and form number (Format: student name form number)");
                string input = Console.ReadLine();

                //string[]splitStudents = input.Split(',');

                //if (input.Length >= 4)
                //{
                  
                 // string studentName1 = splitStudents[0];
                 // string studentForm1 = splitStudents[1];
                 // string studentName2 = splitStudents[2];
                 // string studentForm2 = splitStudents[3];

                 // school[studentForm1] = new List<string>();
                 // school[studentForm1].Add(studentName1);
                 // school[studentForm2] = new List<string>();
                  //school[studentForm2].Add(studentName2);
                 // Console.WriteLine($"Form {studentForm1}: {studentName1} \nForm {studentForm2}: {studentName2}");
                //}

             

                string[] splitInfo = input.Split(' ');
                string studentName = splitInfo[0];
                string studentForm = splitInfo[1];

                school[studentForm] = new List<string>();
                school[studentForm].Add(studentName);
                Console.WriteLine($"Form {studentForm}: {studentName}");
                
                
                Console.WriteLine($"Please enter 'yes' to add more students and 'no' if you don't want to add any more students.");
                }
                while (Console.ReadLine() == "yes");

                
        

              /*
                  Console.WriteLine("Ask me one of the questions: \nWho is enrolled in school right now? \nAdd student's name to the class list for a form. \nIf you would like to know which students are enrolled in certain forms, please enter form + form number \nEnter 'More information' \nOr ask for the total number of students enrolled");
                  string input = Console.ReadLine().ToLower();

              Dictionary<string, string> form2 = new Dictionary<string, string>(); //dictionary to store students from form2
              
              form2.Add("student1", "Aimee");
              form2.Add("student2", "Blair");
              form2.Add("student3", "James");
              form2.Add("student4", "Paul"); 
              
              Dictionary<string, string> form3 = new Dictionary<string, string>(); ////dictionary to store students from form3
              form3.Add("student1", "Claire");
              form3.Add("student2", "Chelsea");

              Dictionary<string, string> form4 = new Dictionary<string, string>(); //dictionary to store students from form4
              form4.Add("student1", "Chris");
              form4.Add("student2", "Jennifer");
    
              Dictionary<string, string> form6 = new Dictionary<string, string>(); //dictionary to store students from form6
              form6.Add("student1", "Kareem");

              Dictionary<string, string> form7 = new Dictionary<string, string>(); //dictionary to store students from form7
              form7.Add("student1", "Logan");

              Dictionary<string, int> school = new Dictionary<string, int>();  //int value represents total number of students in each form and total represents total number of students at school
              school.Add("form 2", 4);
              school.Add("form 3", 2);
              school.Add("form 4", 2);
              school.Add("form 6", 1);
              school.Add("form 7", 1);
              school.Add("total", 10);

              Dictionary<string, List<string>> SchoolStudents = new Dictionary<string, List<string>>();
              SchoolStudents.Add("2", new List<string> { "Aimee", "Blair", "James", "Paul" });
              SchoolStudents.Add("3", new List<string> { "Claire", "Chelsea" });
              SchoolStudents.Add("4", new List<string> { "Chris", "Jennifer" });
              SchoolStudents.Add("6", new List<string> { "Kareem" });
              SchoolStudents.Add("7", new List<string> { "Logan" });

              while (true)
              {
              if (input == "form 2")
              {

              {
                string student1 = form2["student1"];  //accessing elements from dictionary
                string student2 = form2["student2"];
                string student3 = form2["student3"];
                string student4 = form2["student4"];

                Console.WriteLine($"There is {student1}, {student2}, {student3}, {student4} in form 2.");
                break;
              }
              }
              
              
              if (input == "form 3")
              {

              {
                string student1 = form3["student1"];
                string student2 = form3["student2"];

                Console.WriteLine($"There is {student1}, {student2} in form 3.");
                break;
              }
              }

              if (input == "form 4")
              {

              {
                string student1 = form4["student1"];
                string student2 = form4["student2"];

                Console.WriteLine($"There is {student1}, {student2} in form 4.");
                break;
              }
              }

              if (input == "form 6")
              {

              {
                string student1 = form6["student1"];

                Console.WriteLine($"There is only {student1} in form 6.");
                break;
              }
              }

              if (input == "form 7")
              {

              {
                string student1 = form7["student1"];

                Console.WriteLine($"There is only {student1} in form 7.");
                break;
              }
              }

              if (input == "total")
              {

              {
                int total = school["total"];

                Console.WriteLine($"There is {total} enrolled students at school.");
                break;
              }
              }

              if (input == "add to form 2")
              {
                Console.WriteLine("Please enter students' name: ");
                string value = Console.ReadLine();  
                string key1 = "student4" + form2.Count;
                form2.Add(key1, value);   //adding to dictionary
                Console.Write($"{value} has been added to form 2.");
                
                break;
              }

              if (input == "add to form 3")
              {
                Console.WriteLine("Please enter students' name: ");
                string value = Console.ReadLine();  
                string key1 = "student4" + form3.Count;
                form2.Add(key1, value);
                Console.Write($"{value} has been added to form 3.");
                
                break;
              }

              if (input == "add to form 4")
              {
                Console.WriteLine("Please enter students' name: ");
                string value = Console.ReadLine();  
                string key1 = "student4" + form4.Count;
                form2.Add(key1, value);
                Console.Write($"{value} has been added to form 4.");
                
                break;
              }
              
              if (input == "add to form 6")
              {
                Console.WriteLine("Please enter students' name: ");
                string value = Console.ReadLine();  
                string key1 = "student4" + form6.Count;
                form2.Add(key1, value);
                Console.Write($"{value} has been added to form 6.");
                
                break;
              }

              if (input == "add to form 7")
              {
                Console.WriteLine("Please enter students' name: ");
                string value = Console.ReadLine();  
                string key1 = "student4" + form7.Count;
                form2.Add(key1, value);
                Console.Write($"{value} has been added to form 7.");
                
                break;
              }

              if (input == "more information")
              {
                Console.WriteLine("Enter student's name and their form (student name, form number)");
                string input1 = Console.ReadLine();

                
                string[] splitInfo = input.Split(',');
                string studentName = splitInfo[0];
                string studentForm = splitInfo[1];

                Console.WriteLine($"Form{studentForm}: {studentName}");

                break;
              }
              else
              {
              Console.WriteLine("Invalid input. Please enter a valid question or form name.");
              break;
              }
              }
              */
              } //method SchoolRoster
            } //class School

          class ISBN
          {
            public static void VerifyISBN()
            {
              Console.WriteLine("Enter an ISBN number in order to check if the number is valid: ");
              string input = Console.ReadLine();

              string[] invalid = {"-"};  //array with invalid strings to ignore

              //if (input.Contains("X"))
              //{
                //input = input.Replace("X","10");
              //}

              string ISBNno = new string(input.Where(c => Char.IsDigit(c) && !invalid.Contains(c.ToString())).ToArray()); //filters out given characters from the string,, https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-8.0, https://stackoverflow.com/questions/8511774/extracting-digits-from-string-in-c-sharp

              //foreach (char ISBN in ISBNno)
              //{
              //if (ISBN.Equals("X"))
              //{
              //ISBNno = ISBNno.Replace ("X", "10");
                  
              //}
              //}

              Console.WriteLine($"ISBN to calculate is: {ISBNno}");

              int count = 10;
              int result = 0;

              for (int i = 0; i < ISBNno.Length; i++)
              {
              
              char ISBNposition = ISBNno[i];
              int ISBNdigit = int.Parse(ISBNposition.ToString());
              result += ISBNdigit * (10 - i);
              }

              bool Xdigit = ISBNno[ISBNno.Length - 1] == 'X'; //checks if last digit is X
              if (Xdigit)
              {
                result += 10 * count;
               
              }
            

              if (result % 11 == 0)
              {
              Console.WriteLine("ISBN-10 is valid");
              }
              else
              {
              Console.WriteLine("ISBN-10 is invalid");
              }
              } //method VerifyISBN
          } //class ISBN
              
            
}//program class

} //Menu system class
