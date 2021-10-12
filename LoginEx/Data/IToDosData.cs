
using System.Collections.Generic;
using LoginEx.Models;

namespace LoginEx.Data
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