namespace _23_3_Web_API.Models
{
    public class ToDoItem
    {
        //Model : create Blueprint
        public long Id { get; set; }  //unique key for database
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
