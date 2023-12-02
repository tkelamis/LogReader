using LogReader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader
{
    public class Menu : IMenu
    {
        public string GiveMeThePath()
        {
            Console.WriteLine("Give me the path to the logs...");
            var path = Console.ReadLine();
            Console.WriteLine();
            return path;
        }
        public List<string> GetListOfFilesFromDirectory(string pathName)
        {
            List<string> filesList = new List<string>();
            int count = 0;

            while (!Directory.Exists(pathName))
            {
                Console.WriteLine($"Directory {pathName} does not exist! Give me a right path");
                pathName = Console.ReadLine();
            }

            var names = Directory.GetFiles(pathName);
            Console.WriteLine("The files contained in this path are:");
            foreach (var file in names)
            {
                count++;
                Console.WriteLine("{0}.{1}", count, Path.GetFileName(file));
                filesList.Add(Path.Combine(pathName, Path.GetFileName(file)));

            }
            return filesList;
        }
        public string SelectFileToOpenAndGiveMeItsPath(List<string> filesList)
        {
            while (true)
            {
                Console.WriteLine("\nWhich logs file do you want to draw data from?\n");

                if (int.TryParse(Console.ReadLine(), out int numberOfFileToOpen) && numberOfFileToOpen >= 1 && numberOfFileToOpen <= filesList.Count)
                {
                    string pathOfFile = Path.GetFullPath(filesList[numberOfFileToOpen - 1]);

                    if (File.Exists(pathOfFile))
                    {
                        return pathOfFile;
                    }
                    else
                    {
                        Console.WriteLine("The selected file doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid file number.");
                }
            }
        }
        public void ChooseCategoryOfLogs(List<LogData> logList)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Show me the logs with error");
                Console.WriteLine("2. Show me the logs with warnings");
                Console.WriteLine("3. Show me the logs with info");
                Console.WriteLine("4. Show me the users mentioned in the logs");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                if (Enum.TryParse(Console.ReadLine(), out LogType choice))
                {
                    Console.WriteLine();

                    switch (choice)
                    {
                        case LogType.ShowErrorLogs:
                            ShowMeErrorLogs(logList);
                            break;
                        case LogType.ShowWarningLogs:
                            ShowMeWarningLogs(logList);
                            break;
                        case LogType.ShowInfoLogs:
                            ShowMeSucceededLogs(logList);
                            break;
                        case LogType.ShowUserNames:
                            ShowMeUsersNames(logList);
                            break;
                        case LogType.Exit:
                            Console.WriteLine("Goodbye!!!");
                            return; // Exit the method
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option number.");
                }
            }
        }
        private void ShowMeErrorLogs(List<LogData> data)
        {
            var errorLogs = data.Where(dato => dato.ErrorType == "ERROR").ToList();

            if (errorLogs.Any())
            {
                foreach (var log in errorLogs)
                {
                    Console.WriteLine($"{log.Description}, {log.DateTime}, {log.ErrorType}");
                }
                Console.WriteLine($"Total of {errorLogs.Count} error logs");
            }
            else
            {
                Console.WriteLine("No error logs found.");
            }
        }
        private void ShowMeWarningLogs(List<LogData> data)
        {
            var warningLogs = data.Where(dato => dato.ErrorType == "WARNING").ToList();
            if (warningLogs.Any())
            {
                foreach (var log in warningLogs)
                {
                    Console.WriteLine($"{log.Description}, {log.DateTime}, {log.ErrorType}");
                }
                Console.WriteLine();
                Console.WriteLine($"Total of {warningLogs.Count} warning logs");
            }
            else
            {
                Console.WriteLine("No error logs found.");
            }
        }
        private void ShowMeSucceededLogs(List<LogData> data)
        {
            var succededLogs = data.Where(dato => dato.ErrorType == "INFO").ToList();
            if (succededLogs.Any())
            {
                foreach (var log in succededLogs)
                {
                    Console.WriteLine($"{log.Description}, {log.DateTime}, {log.ErrorType}");
                }
                Console.WriteLine($"Total of {succededLogs.Count} info logs");
            }
            else
            {
                Console.WriteLine("No error logs found.");
            }
        }
        private void ShowMeUsersNames(List<LogData> list)
        {
            var listOfUsers = ExtractUsers(list);

            foreach (var user in listOfUsers)
            {
                Console.WriteLine(user.Name);
            }
        }
        private List<Users> ExtractUsers(List<LogData> list)
        {
            var usersList = list
                .Where(item => item.Description.Contains("User"))
                .Select(item =>
                {
                    var nameStartIndex = item.Description.IndexOf("User") + 6;
                    var nameEndIndex = item.Description.LastIndexOf("'");
                    var name = item.Description.Substring(nameStartIndex, nameEndIndex - nameStartIndex);

                    return new Users { Name = name };
                })
                .ToList();

            return usersList;
        }
    }
}
