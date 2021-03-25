// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
using TodoList.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todoGoogle")]
    public partial class ToDoGoogle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "d:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
      
    private List<ToDoTask> tasks;
    private List<ToDoTaskList> tasksList;
    private ToDoTaskList selectTaskList;
    //
    private ToDoTask newTask = new ToDoTask();
    private string titleNewTask = "Введите название новой задачи";
    private string titleNewListTask = "Введите название нового списка";
    //
    BSModal ModalCreateTask { get; set; }
    BSModal ModalCreateListTask{get;set;}


    protected override async Task OnInitializedAsync()
    {
        tasksList = ToDoTaskService.GetToDoTaskLists();
    }

    private void GetToDoTasksList()
    {
        tasksList = ToDoTaskService.GetToDoTaskLists();
    }
    private bool GetToDoTasksInList(string id)
    {
        tasks = ToDoTaskService.GetToDoTasksInListAsync(id);
        if (tasks != null)
        {
            return true;
        }
        else return false;

    }

    private void AddNewTaskInList()
    {
        ToDoTaskService.AddNewTaskInList(selectTaskList, titleNewTask);
        ModalCreateTask.Hide();
    }

    private void AddNewListTask(){
        ToDoTaskService.AddNewListTask(titleNewListTask);
        ModalCreateListTask.Hide();
    }

    private void onclick(ToDoTaskList e)
    {
        selectTaskList = e;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToDoTaskService ToDoTaskService { get; set; }
    }
}
#pragma warning restore 1591
