using Microsoft.AspNetCore.Components;
using Models;

namespace BlazorToDo.Bases
{
    public partial class ToDo : ComponentBase
    {
        protected readonly List<ToDoItem> ToDoItems = new();
        protected string? NewToDo;

        protected void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(NewToDo))
            {
                ToDoItems.Add(new ToDoItem { Title = NewToDo });
                NewToDo = string.Empty;
            }
        }
    }
}
