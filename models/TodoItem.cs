namespace Exercise2.Models
{
    public class TodoItem
    {
        public int Id { get; private set; }
        public string Content { get; set; }
        public string Status { get; set; }

        public TodoItem(int id, string content)
        {
            this.Id = id;
            this.Content = content;
            this.Status = "pending";
        }

        public bool Update()
        {
            if (this.Status == "pending")
            {
                this.Status = "active";
                return true;
            }
            else if (this.Status == "active")
            {
                this.Status = "done";
                return true;
            }
            else if (this.Status == "done")
            {
                return false;
            }
            else
            {
                return false;
            }

        }

        public int GetId()
        {
            return this.Id;
        }
    }
}