using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.API.DataStore;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    public class TodoTasksController: Controller
    {
        [HttpGet()]
        public IActionResult GetTodoTasks() 
        {
            return Ok(TodoTasksDataStore.Current.TodoTasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoTask(int id)
        {
            var outTask = TodoTasksDataStore.Current.TodoTasks.FirstOrDefault( 
                t => t.Id == id);
            if(outTask == null) {
                return NotFound();
             } 
             return Ok(outTask);
        }
    }
}
