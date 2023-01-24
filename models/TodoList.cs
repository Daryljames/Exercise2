namespace Exercise2.Models
{
    public class TodoList
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public List<TodoItem> TodoItem { get; set; }

        public TodoList(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.TodoItem = new List<TodoItem>();
        }

        public void AddTodoItem(TodoItem item)
        {
            this.TodoItem.Add(item);
        }

        public void RemoveTodoItem(int id)
        {
            foreach (TodoItem t in TodoItem)
            {
                if (t.Id == id)
                {
                    this.TodoItem.Remove(t);
                }
            }
        }

        public int GetTodoListById()
        {
            return this.Id;
        }

        public string GetTodoListByName()
        {
            return this.Name;
        }

        public string GetTodoList()
        {
            return "Id: " + GetTodoListById + " - " + "Name: " + GetTodoListByName;
        }

        public List<TodoItem> GetAllTodoItem()
        {
            return this.TodoItem;
        }
    }
}