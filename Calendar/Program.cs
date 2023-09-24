// See https://aka.ms/new-console-template for more information
using Calendar.Entities;
Console.WriteLine("Inheritance");
Meeting meeting1 = new()
{
    Title = "Yetgen Jump & Akbank Backend Planlama Toplantısı ",
    Details = new List<string>(){
        "Eğitim süreci"
    },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    EndTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new(){ "zeynep@gmail.com", "zehra@gmail.com", "banu@gmail.com" },
};

ToDo toDo1 = new()
{
    Title = "Yetgen Jump & Akbank Backend Planlama Toplantısı ",
    Details = new List<string>(){
        "Eğitim süreci"
    },
    StartTime = new DateTime(2023, 09, 20, 21, 00, 00),
    EndTime = new DateTime(2023, 09, 20, 22, 00, 00),
    Importance = "High Priority",
    
};


meeting1.GetNotification();
toDo1.GetNotification();


