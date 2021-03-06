// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginEx.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using LoginEx;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using LoginEx.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
using LoginEx.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
using LoginEx.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
       
    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;
    
    private int? filterById;
    private bool? filterByIsCompleted;
    

    protected override async Task OnInitializedAsync()
    {
        allTodos = TodoData.GetTodos();
        todosToShow = allTodos;
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoId == todoId);
        TodoData.RemoveTodo(todoId);
        allTodos.Remove(todoToRemove);
        todosToShow.Remove(todoToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        TodoData.Update(todo);
    }

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch(Exception e){}
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(args.Value.ToString());

        }
        catch (Exception e) {}
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t => (filterById != null && t.UserId == filterById || filterById == null) &&
                                          (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosData TodoData { get; set; }
    }
}
#pragma warning restore 1591
