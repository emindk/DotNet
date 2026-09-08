using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TodoWebFormsApp.Models;

namespace TodoWebFormsApp.Controllers
{
    public class ToDoController : ApiController
    {
        // We create a simple in-memory list for demo purposes
        private static List<ToDoItem> _toDoList = new List<ToDoItem>()
        {
            new ToDoItem { Id = 1, Text = "Read a book.", IsCompleted = false },
            new ToDoItem { Id = 2, Text = "Go to School!", IsCompleted = true },
            new ToDoItem { Id = 3, Text = "Study .NET", IsCompleted = true },
            new ToDoItem { Id = 4, Text = "Practice More...", IsCompleted = false }
        };

        // GET: api/ToDo
        [HttpGet]
        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _toDoList;
        }

        // GET: api/ToDo/5
        [HttpGet]
        public IHttpActionResult GetItem(int id)
        {
            var item = _toDoList.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        // POST: api/ToDo
        [HttpPost]
        public IHttpActionResult CreateItem([FromBody] ToDoItem newItem)
        {
            if (newItem == null)
                return BadRequest("Invalid Input.");

            // We give 1 more than the highest value for Id (primitive approach)
            var maxId = _toDoList.Any() ? _toDoList.Max(x => x.Id) : 0;
            newItem.Id = maxId + 1;

            _toDoList.Add(newItem);
            return Ok(newItem);
        }

        // PUT: api/ToDo/5
        [HttpPut]
        public IHttpActionResult UpdateItem(int id, [FromBody] ToDoItem updatedItem)
        {
            if (updatedItem == null)
                return BadRequest("Invalid Input.");

            var existingItem = _toDoList.FirstOrDefault(x => x.Id == id);
            if (existingItem == null)
                return NotFound();

            existingItem.Text = updatedItem.Text;
            existingItem.IsCompleted = updatedItem.IsCompleted;

            return Ok(existingItem);
        }

        // DELETE: api/ToDo/5
        [HttpDelete]
        public IHttpActionResult DeleteItem(int id)
        {
            var item = _toDoList.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            _toDoList.Remove(item);
            return Ok();
        }
    }
}
