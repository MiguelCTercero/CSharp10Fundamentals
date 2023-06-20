// See https://aka.ms/new-console-template for more information

// int age = 23;

// bool a = age == 23;
// Console.WriteLine("Age is 23: " + a);

// bool b = age > 23;
// Console.WriteLine("Age is greater than 23: " + b);

// bool c = (age >= 18) && (age <= 65);
// Console.WriteLine("Age is between 18 and 65: " + c);

// int age1 = 16;
// int age2 = 64;

// bool d = (age1 >= 18) && (age2 <= 65);
// Console.WriteLine("Age1 is greater than 18 and age2 is less than 65:" + d);
// bool e = (age1 >= 18) || (age2 <= 65);
// Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65:" + e);

// Console.WriteLine("Enter the age of the new Candidate: ");
// int age = int.Parse(Console.ReadLine());

// if(age < 18){
//     Console.WriteLine("Too young to apply, kid");
//     Console.WriteLine("Send hate mail to candidate");
// }else if(age > 65){
//     Console.WriteLine("Sorry, you are too old and since we are vapid airheads, considered worthless.");
//         Console.WriteLine("Send hate mail to the candidate.");
       
// }else{
//     Console.WriteLine("Great, you can now start with the application!");
// }

// switch (age){
//     case < 18:
//     case > 65:
//         Console.WriteLine("Sorry, your age is not within the range we are looking for");
//         break;
//     case 23:
//         Console.WriteLine("Wow, exactly waht we are looking for");
//         break;
//     default:
//         Console.WriteLine("Great, you can now start with the application!");
//         break;
// } 

// DateTime today = DateTime.Now;
// bool endOfMonthPaymentStarted = false;

// if(today.Date.Day == 20){
//     Console.WriteLine("Please start end-of-month employee payments");
// }else if(today.Date.Day >= 25 && !endOfMonthPaymentStarted){
//     Console.WriteLine("Payments will be late!");
// }

// Console.WriteLine("Chose the action you want to do:");
// Console.WriteLine("1. Add Employee");
// Console.WriteLine("2. Update Employee");
// Console.WriteLine("3. Delete Employee");
// Console.WriteLine("99. Exit Application");
// string selectedAction = Console.ReadLine();

// while(selectedAction != "99"){
//     switch (selectedAction){
//     case "1":
//         Console.WriteLine("Adding new Employee...");
//         break;
//     case "2":
//         Console.WriteLine("Updating Employee...");
//         break;
//     case "3":
//         Console.WriteLine("Deleting Employee");
//         break;
//     default:
//         Console.WriteLine("Invalid input");
//         break;
//     }

//     Console.WriteLine("Chose the action you want to do:");
//     Console.WriteLine("1. Add Employee");
//     Console.WriteLine("2. Update Employee");
//     Console.WriteLine("3. Delete Employee");
//     Console.WriteLine("99. Exit Application");
//     selectedAction = Console.ReadLine();
// }

// Console.WriteLine("Enter a value: ");
// int max = int.Parse(Console.ReadLine());
// int i =0;
// while(i < max){
//     Console.WriteLine(i);
//     i++;
// }

// Console.WriteLine("Loop Finished!");

int i = 0;
int j = 0;

while(i < 20){
    while (j < 10){
        Console.WriteLine(i.ToString() + j.ToString());
        j++;
    }
    j = 0;
    i++;
}