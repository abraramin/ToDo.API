using System.Collections.Generic;

namespace ToDo.API.Models
{
    public class TodoTasksDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public ICollection<TodoItemDto> TodoItems { get; set; } = 
        new List<TodoItemDto>();
    }
}
