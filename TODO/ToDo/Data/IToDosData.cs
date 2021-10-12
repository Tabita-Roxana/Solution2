
using System.Collections.Generic;
using ToDo.Models;

namespace ToDo.Data
{
    public interface ITodosData
    {
        IList<Models.Todo> GetTodos();
        void AddTodo(Models.Todo todo);
        void RemoveTodo(int todoId);
        void Update(Todo todo);
        Todo Get(int id);
    }
}