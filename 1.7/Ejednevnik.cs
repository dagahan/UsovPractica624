using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
}

class Program
{
    static List<Task> tasks = new List<Task>();
    static string filename = "tasks.json";

    static void Main(string[] args)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
        }

        while (true)
        {
            Console.WriteLine("------МЕНЮ--ЕЖЕДНЕВНИКА------");
            Console.WriteLine("1) Добавить задачу");
            Console.WriteLine("2) Удалить задачу");
            Console.WriteLine("3) Редактировать задачу");
            Console.WriteLine("4) Просмотреть задачи на сегодня");
            Console.WriteLine("5) Просмотреть задачи на завтра");
            Console.WriteLine("6) Просмотреть задачи на неделю");
            Console.WriteLine("7) Просмотреть все задачи");
            Console.WriteLine("8) Просмотреть задачи, которые предстоит выполнить");
            Console.WriteLine("9) Просмотреть задачи, которые уже прошли");
            Console.WriteLine("10) Выйти");
            Console.WriteLine("------------\n");

            Console.WriteLine("Введите номер пункта: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            if (choice == 1) //Добавить задачу
            {
                AddTask();
            }
            
            else if (choice == 2) //Удалить задачу
            {
                DeleteTask();
            }
            
            else if (choice == 3)///Редактировать задачу
            {
                EditTask();
            }
            
            else if (choice == 4)//Просмотреть задачи на сегодня
            {
                ViewTasksByDate(DateTime.Today);
            }
            
            else if (choice == 5)//Просмотреть задачи на завтра
            {
                ViewTasksByDate(DateTime.Today.AddDays(1));
            }
            
            else if (choice == 6)//Просмотреть задачи на неделю
            {
                ViewTasksForAWeek();
            }
            
            else if (choice == 7)//Просмотреть все задачи
            {
                ViewAllTasks();
            }
            
            else if (choice == 8)//Просмотреть задачи, которые предстоит выполнить
            {
                ViewUpcomingTasks();
            }
            
            else if (choice == 9)//Просмотреть задачи, которые уже прошли
            {
                ViewPastTasks();
            }
            
            else if (choice == 10)//Выйти
            {
                SaveAndExit();
            }
        }
    }

    static void AddTask()
    {
        Task newTask = new Task();
        Console.Write("(Для Отмены Введите -1)\nВведите название задачи: ");
        newTask.Title = Console.ReadLine();
        
        if (newTask.Title != "-1")
        {
            Console.Write("(Для Отмены Введите -1)\nВведите описание задачи: ");
            newTask.Description = Console.ReadLine();
            if (newTask.Description != "-1")
            {
                Console.Write("(Для Отмены Введите -)\nВведите дату выполнения задачи (гггг-мм-дд): ");
                newTask.DueDate = DateTime.Parse(Console.ReadLine());
                if (newTask.Description != "-1")
                {
                    tasks.Add(newTask);
                }
                else
                {
                    Console.WriteLine("Отмена");
                }
            }
            else
            {
                Console.WriteLine("Отмена");
            }
        }
        else
        {
            Console.WriteLine("Отмена");
        }
        
        SaveTasks();
    }

    static void DeleteTask()
    {
        ViewAllTasks();
        Console.Write("(Для Отмены Введите -1)\nВведите номер задачи для удаления: ");
        int index = int.Parse(Console.ReadLine());
        
        if (index == -1)
        {
            Console.WriteLine("Отмена");
        }
        
        else if (index > 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            SaveTasks();
        }
        
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }
    }

    static void EditTask()
    {
        ViewAllTasks();
        Console.Write("(Для Отмены Введите -1)\nВведите номер задачи для редактирования: ");
        int index = int.Parse(Console.ReadLine());


        if (index == -1)
        {
            Console.WriteLine("Отмена");
        }
        else if (index >= 0 && index < tasks.Count)
        {
            Console.Write("Введите новое название задачи: ");
            tasks[index].Title = Console.ReadLine();
            Console.Write("Введите новое описание задачи: ");
            tasks[index].Description = Console.ReadLine();
            Console.Write("Введите новую дату выполнения задачи (гггг-мм-дд): ");
            tasks[index].DueDate = DateTime.Parse(Console.ReadLine());
            SaveTasks();
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    static void ViewTasksByDate(DateTime date) //смотрит задачу, соответствующую дате на вход (юзает в меню задачи на сегодня, завтра, на неделю)
    {
        Console.WriteLine($"Задачи на {date.ToShortDateString()}: ");
        foreach (var task in tasks)
        {
            if (task.DueDate.Date == date.Date)
            {
                Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата выполнения: {task.DueDate.ToShortDateString()}");
            }
        }
    }

    static void ViewTasksForAWeek()
    {
        Console.WriteLine("Задачи на неделю:");
        for (int i = 0; i < 7; i++)
        {
            DateTime date = DateTime.Today.AddDays(i);
            ViewTasksByDate(date);
        }
    }

    static void ViewAllTasks()//чекнуть все задачки
    {
        Console.WriteLine("Все задачи: ");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}. Название: {tasks[i].Title}, Описание: {tasks[i].Description}, Дата выполнения: {tasks[i].DueDate.ToShortDateString()}");
        }
    }

    static void ViewUpcomingTasks()
    {
        Console.WriteLine("Ваши Будушие задачи: ");
        foreach (var task in tasks)
        {
            if (task.DueDate >= DateTime.Today)
            {
                Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата выполнения: {task.DueDate.ToShortDateString()}");
            }
        }
    }

    static void ViewPastTasks()
    {
        Console.WriteLine("Прошедшие по времени задачи: ");
        foreach (var task in tasks)
        {
            if (task.DueDate < DateTime.Today)
            {
                Console.WriteLine($"Название: {task.Title}, Описание: {task.Description}, Дата выполнения: {task.DueDate.ToShortDateString()}");
            }
        }
    }

    static void SaveTasks()
    {
        string json = JsonConvert.SerializeObject(tasks);
        File.WriteAllText(filename, json);
    }

    static void SaveAndExit()
    {
        SaveTasks();
        Environment.Exit(0);
    }
}