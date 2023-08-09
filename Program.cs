namespace ToDoListProgram
{
    internal class Program
    {
       public static List<string> Tasklist = new List<string>();

        static string UsersName;

        public static int noOfTasks = Tasklist.Count;


        static void Main(string[] args)
        {
            GetName();
            bool ProgramExited = false;
            do
                ProgramExited = DisplayMenu();
            while (ProgramExited == false);
        }

        public static void GetName()
        {
            Console.WriteLine("Please enter your name:");
            UsersName = Console.ReadLine();
            Console.WriteLine($"Hello {UsersName}.");
        }


        public static bool DisplayMenu()
        {
            int Input;

            Console.WriteLine("Type 1 to add tasks.");
            Console.WriteLine("Type 2 to view task list.");
            Console.WriteLine("Type 3 to edit a task.");
            Console.WriteLine("Type 4 to exit program.");
            Console.WriteLine("Type 5 to view the total number of tasks.");
            Input = Convert.ToInt16(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    AddTasks();
                    break;
                case 2:
                    ViewList();
                    break;
                case 3:
                    EditTask();
                    break;
                case 4:
                    Console.WriteLine("You are exiting the program!");
                    return true;
                case 5:
                    HaveYouReachedTotalTasks(howManyTasks);
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                break;
            }
            return false;
        }


        public static void AddTasks()
        {
            string TaskItem;
            Console.WriteLine("Please enter your tasks. Type 'DONE' to return to the main menu.");
            TaskItem = Console.ReadLine();

            switch (TaskItem)
            {
                default:
                    Tasklist.Add(TaskItem);
                    AddTasks();
                    break;
                case "DONE":
                    break;
            }
        }


        public static void EditTask()
        {
            
            ViewList();
            Console.WriteLine("Type the index number of the task you would like to edit:");
            int SelectedIndex = Convert.ToInt16(Console.ReadLine());

            switch (SelectedIndex)
            {
                default:
                    Console.WriteLine("Enter the updated task:");
                    string UpdatedTask = Console.ReadLine();
                    Tasklist[SelectedIndex] = UpdatedTask;
                    Console.WriteLine("Task updated successfully!");
                    break;
                case int invalidInput when invalidInput < 0 || invalidInput > Tasklist.Count:
                    Console.WriteLine("Invalid index number.");
                    break;
            }
        }

        public static void ViewList()
        {
            int TaskIndex = 0;
            Console.WriteLine("Here are your tasks:");
            foreach (string task in Tasklist)
            {
                Console.WriteLine($"[{TaskIndex++}] {task}");
            }
        }

        public static int HaveYouReachedTotalTasks(int howManyTasks)
        {
            howManyTasks = noOfTasks;

            int remainingTasks = howManyTasks - 5;
            return remainingTasks;
        }
    }
}