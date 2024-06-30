﻿using TaskProject;

List<Tasks> tasks = [];
Tasks task = new Tasks();
Adapter adapter = new ListAdapter(tasks);
int option = 0;
while (true)
{
    Console.WriteLine(@"
------------ Menu --------------
 1. Tasks list
 2. Add task
 3. Update task
 4. Delete task
 5. Search task
 6. Download tasks
 7. Switch views
 8. Exit");
    Console.Write("Choose option:");
    if (int.TryParse(Console.ReadLine(), out option))
    {
        switch (option)
        {
            case 1: ListTasks(); break;
            case 2: AddTask(); break;
            case 3: UpdateTasks(); break;
            case 4: DeleteTasks(); break;
            case 5: SearchTasks(); break;
            case 6: DownloadTasks(); break;
            case 7: adapter = new GridAdapter(tasks); ListTasks(); break;
            case 8: return;
        }
    }
}

void ListTasks()
{
    adapter.Display();
}
void AddTask()
{
    Console.WriteLine(@"------ Add Task ------");
    task = (Tasks)task.Clone();
    task.TaskName = "";
    Console.Write($"Task Name: ");
    task.TaskName = Console.ReadLine() ?? "";
    Console.Write($"Prioity [{task.Priority}]: ");
    if (int.TryParse(Console.ReadLine(), out int prio))
    {
        task.Priority = prio;
    }
    Console.Write($"Execution date [{task.ExecutionDate.ToShortDateString()}]: ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
    {
        task.ExecutionDate = date;
    }
    Console.Write($"Tag [{task.Tag}]: ");
    string tag = Console.ReadLine() ?? string.Empty;
    if (tag != string.Empty)
    {
        task.Tag = tag;
    }
    tasks.Add(task);
}
void UpdateTasks()
{

}
void DeleteTasks()
{

}
void SearchTasks()
{

}
void DownloadTasks()
{

}