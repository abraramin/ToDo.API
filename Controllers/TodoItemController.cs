using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Todo.API.DataStore;

namespace ToDo.API.Controllers
{
    [Route("api/todotasks")]
    public class TodoItemController: Controller
    {
        [HttpGet("{todotaskid}/todoitem")]
        public IActionResult GetTodoItem(int todoTaskId)
        {
            var task = TodoTasksDataStore.Current.TodoTasks.FirstOrDefault(t => t.Id == todoTaskId);

            if(task == null)
            {
                return NotFound();
            }
            return Ok(task.TodoItems);
        }

        [HttpGet("{todotaskid}/todoitem/{todoitemid}")]
        public IActionResult GetSingleTodoItem(int todoTaskId, int todoItemId)
        {
            var task = TodoTasksDataStore.Current.TodoTasks.FirstOrDefault(t => t.Id == todoTaskId);
            if(task == null)
            {
                return NotFound();
            }
            var item = task.TodoItems.FirstOrDefault(t => t.Id == todoItemId);
            if(item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
