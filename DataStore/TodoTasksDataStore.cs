using System.Collections.Generic;
using ToDo.API.Models;

namespace Todo.API.DataStore
{
    public class TodoTasksDataStore
    {
        public static TodoTasksDataStore Current { get; } = new TodoTasksDataStore();
        public List<TodoTasksDto> TodoTasks { get; set; }

        public TodoTasksDataStore() 
        {
            TodoTasks = new List<TodoTasksDto>()
            {
                new TodoTasksDto()
                {
                    Id = 0,
                    Title = "Fishing trip",
                    Description = "Things to do before going fishing.",
                    TodoItems = new List<TodoItemDto>
                    {
                        new TodoItemDto()
                        {
                            Id = 0,
                            Title= "Buying Fishing rods",
                            IsComplete = false
                        },
                        new TodoItemDto()
                        {
                            Id = 1,
                            Title= "Acquire bait",
                            IsComplete = false

                        }
                    }
                },
                new TodoTasksDto()
                {
                    Id = 1,
                    Title = "Grocery Shopping",
                    Description = "Shopping list for groceries.",
                    TodoItems = new List<TodoItemDto>
                    {
                        new TodoItemDto()
                        {
                            Id = 0,
                            Title= "Onions",
                            IsComplete = true
                        },
                        new TodoItemDto()
                        {
                            Id = 1,
                            Title= "Eggs",
                            IsComplete = false

                        },
                        new TodoItemDto()
                        {
                            Id = 2,
                            Title= "Chillies",
                            IsComplete = false

                        },
                        new TodoItemDto()
                        {
                            Id = 3,
                            Title= "Coriander",
                            IsComplete = false

                        }
                    }
                },
                new TodoTasksDto()
                {
                    Id = 2,
                    Title = "Household chores",
                    Description = "Household chores todo for the weekend.",
                    TodoItems = new List<TodoItemDto>()
                    {
                        new TodoItemDto()
                        {
                            Id = 0,
                            Title = "Laundry",
                            IsComplete = false
                        }

                    }
                }
            };
        }
    }
}
