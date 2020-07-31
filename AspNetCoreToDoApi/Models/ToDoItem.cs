namespace AspNetCoreToDoApi.Models
{
    // A model is a set of classes that represent the data that the app manages
    // The Id property functions as the unique key in a relational database
    // Model classes can go anywhere in the project, but the Models folder is used by convention
    public class ToDoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
