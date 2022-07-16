using System.Security.Cryptography.X509Certificates;

string[] files = {"photo.jpeg","picture.png","document.docx","application.exe","secret_file.docx",
                  "virus.exe", "nude_boobs.png","my_project.cpp","password.txt","game.exe"};
                  

List<string> extensions=new List<string>();

foreach (var file in files)
{
    var index = file.IndexOf('.') + 1;
    extensions.Add(file.Substring(index, file.Length-index));
}

Dictionary<string, int> list_of_files = new Dictionary<string, int>();

int count = 0;
foreach (var str in extensions)
{
    for (int i = 0; i < extensions.Count; i++)
    {
        if (str == extensions[i])
        {
            count++;
        }
    }
    if (!list_of_files.ContainsKey(str))
    {
        list_of_files.Add(str,count);
    }
    count = 0;
}

foreach (var item in list_of_files)
{
    Console.WriteLine(item.ToString());
}