using System.Security.Cryptography.X509Certificates;

string[] files = {"photo.jpeg","picture.png","document.docx","application.exe","secret_file.docx",
                  "virus.exe", "nude_boobs.png","my_project.cpp","password.txt","game.exe"};

var group_by_extension = files.GroupBy(f => f.Substring(f.IndexOf('.')+1));

foreach (var extension in group_by_extension)
{
    Console.Write($"[{extension.Key} - {extension.Count()}] - ");
    foreach (var group_of_files in extension)
    {
        Console.Write($"{group_of_files}, ");
    }
    Console.WriteLine();
}