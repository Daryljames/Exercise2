using Exercise2.Models;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TodoItem item1 = new TodoItem(1, "wake up");
            TodoItem item2 = new TodoItem(2, "stand up");

            List<TodoList> myList = new List<TodoList>();

            bool isForMainMenu = true;
            while (isForMainMenu)
            {
                Console.WriteLine("1 - Display All Lists");
                Console.WriteLine("2 - Show Items");
                Console.WriteLine("3 - Create New List");
                Console.WriteLine("4 - Select List");
                Console.WriteLine("5 - Quit");
                Console.WriteLine("==========================");
                Console.Write("Enter Number: ");

                int choice = Convert.ToInt32(Console.ReadLine());


                bool isContinue = true;



                while (isContinue)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("==========================");

                        if (myList.Count > 0)
                        {
                            Console.WriteLine("Here is your list");

                            foreach (TodoList list in myList)
                            {
                                Console.WriteLine(list.GetTodoList());
                                isContinue = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have any items in your list");
                            Console.WriteLine("==========================");

                            isContinue = false;
                        }

                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter the id of a list");
                        Console.Write("Enter ID: ");

                        int id = Convert.ToInt32(Console.ReadLine());

                        // Console.WriteLine(id);

                        if (myList.Count() == 0)
                        {
                            Console.WriteLine("Returned an Empty TodoList");
                            isContinue = false;
                        }
                        else
                        {
                            foreach (TodoList list in myList)
                            {
                                if (list.Id == id)
                                {
                                    Console.WriteLine(list.GetAllTodoItem());
                                    isContinue = false;
                                }
                            }
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter new list name:");
                        string name = Console.ReadLine();

                        int numOfList = myList.Count();

                        TodoList list = new TodoList(numOfList + 1, name);

                        myList.Add(list);
                        isContinue = false;

                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Enter the id of a list");
                        Console.Write("Enter ID: ");

                        int id = Convert.ToInt32(Console.ReadLine());

                        // Console.WriteLine(id);

                        if (myList.Count() == 0)
                        {
                            Console.WriteLine("Returned an Empty TodoList");
                            isContinue = false;
                        }
                        else
                        {
                            foreach (TodoList todoListItem in myList)
                            {
                                if (todoListItem.Id == id)
                                {
                                    List<TodoItem> todoItems = todoListItem.GetAllTodoItem();
                                    bool isForSecondMenu = true;

                                    while (isForSecondMenu)
                                    {
                                        Console.WriteLine("1 - Display all Items");
                                        Console.WriteLine("2 - Create New Item");
                                        Console.WriteLine("3 - Delete Item");
                                        Console.WriteLine("4 - Update Item");
                                        Console.WriteLine("5 - Go back");
                                        Console.WriteLine("==========================");
                                        Console.Write("Enter Number: ");

                                        int secondMenuChoice = Convert.ToInt32(Console.ReadLine());

                                        bool isSecondMenuOngoing = true;

                                        while (isSecondMenuOngoing)
                                        {
                                            if (secondMenuChoice == 1)
                                            {
                                                if (todoListItem.GetAllTodoItem().Count() == 0)
                                                {
                                                    Console.WriteLine("Empty Todo, please add todo items");
                                                    isSecondMenuOngoing = false;
                                                }
                                                else
                                                {
                                                    todoListItem.GetAllTodoItem();
                                                    isSecondMenuOngoing = false;
                                                }

                                            }
                                            else if (secondMenuChoice == 2)
                                            {
                                                Console.WriteLine("Set new todo item:");
                                                string content = Console.ReadLine();

                                                int numOfTodos = todoItems.Count();

                                                TodoItem todo = new TodoItem(numOfTodos + 1, content);

                                                todoItems.Add(todo);
                                                isSecondMenuOngoing = false;
                                            }
                                            else if (secondMenuChoice == 3)
                                            {
                                                Console.WriteLine("Enter the id of a todo item");
                                                Console.Write("Enter ID: ");

                                                int itemId = Convert.ToInt32(Console.ReadLine());

                                                if (todoItems.Count() == 0)
                                                {
                                                    Console.WriteLine("Returned an Empty Todo Items");
                                                    isSecondMenuOngoing = false;
                                                }
                                                else
                                                {
                                                    foreach (TodoItem item in todoItems)
                                                    {
                                                        if (item.Id == itemId)
                                                        {
                                                            todoItems.Remove(item);
                                                            isSecondMenuOngoing = false;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Invalid id");
                                                            isSecondMenuOngoing = false;
                                                        }
                                                    }
                                                }
                                            }
                                            else if (secondMenuChoice == 4)
                                            {
                                                Console.WriteLine("Enter the id of a todo item");
                                                Console.Write("Enter ID: ");

                                                int itemId = Convert.ToInt32(Console.ReadLine());

                                                foreach (TodoItem item in todoItems)
                                                {
                                                    if (item.Id == itemId)
                                                    {
                                                        item.Update();
                                                        isSecondMenuOngoing = false;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Invalid id");
                                                        isSecondMenuOngoing = false;
                                                    }
                                                }
                                            }
                                            else if (secondMenuChoice == 5)
                                            {
                                                isForSecondMenu = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (choice == 5)
                    {
                        isForMainMenu = false;
                    }
                }

            }


        }
    }
}