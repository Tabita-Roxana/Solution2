#pragma checksum "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "507e8d55a9a1fdcfa18e529042633228cf56e87a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Todos</h3>\r\n");
            __builder.AddMarkupContent(1, "<h1> Todo list</h1>\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n    Filter by User Id: ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                                        (arg)=>FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by completed status:\r\n    ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control selectpicker");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                                           (arg) => FilterByCompletedStatus(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width: 100px");
            __builder.OpenElement(15, "option");
            __builder.AddContent(16, "Both");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "option");
            __builder.AddContent(19, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "option");
            __builder.AddContent(22, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
 if (todosToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em> Loading...</em></p>");
#nullable restore
#line 29 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
} else if (!todosToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<p><em> No ToDo items exist.Please add some.</em></p>");
#nullable restore
#line 34 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "<thead><tr><th>User ID</th>\r\n            <th>ToDo ID</th>\r\n            <th> Title </th>\r\n            <th> Completed? </th>\r\n            <th>Remove</th>\r\n            <th>Edit</th></tr></thead>\r\n        ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 49 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
         foreach (var item in todosToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 52 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                      item.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 53 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                      item.TodoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 54 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                      item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "checkbox");
            __builder.AddAttribute(42, "checked", 
#nullable restore
#line 56 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                                     item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                        (arg)=>CompletedChange(arg,item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                        () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
                                        () => Edit(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<i class=\"oi oi-pencil\" style=\"color: #1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\tabit\RiderProjects\Solution2\LoginEx\Pages\Todos.razor"
}

#line default
#line hidden
#nullable disable
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