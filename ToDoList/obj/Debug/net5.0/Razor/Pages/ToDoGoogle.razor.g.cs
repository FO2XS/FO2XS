#pragma checksum "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ad815971d2b326e0c16bdc10c57c80f14ba3af"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
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
            __builder.AddMarkupContent(0, "<h1>Задачки из Гугла</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Здесь будут показываться задачки из моих гугл тасков</p>");
#nullable restore
#line 9 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
 if (tasksList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>На настоящий момент какие либо задачи отсутствуют</em></p>");
#nullable restore
#line 12 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "ol");
#nullable restore
#line 17 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
         foreach (var taskList in tasksList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "style", "display: inline-table; margin-left: 15px");
            __builder.OpenComponent<BlazorStrap.BSBasicForm>(6);
            __builder.AddAttribute(7, "IsInline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.TodoList.Pages.ToDoGoogle.TypeInference.CreateBSBasicInput_0(__builder2, 9, 10, 
#nullable restore
#line 21 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
                , 11, "width: 300px; background: orange", 12, 
#nullable restore
#line 21 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                           taskList.Title

#line default
#line hidden
#nullable disable
                , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskList.Title = __value, taskList.Title)));
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenComponent<BlazorStrap.BSButton>(15);
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                          ()=>ToDoTaskService.DeleteTaskList(taskList.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "X");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n                \r\n                <br>");
#nullable restore
#line 26 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                 if (@GetToDoTasksInList(taskList.Id))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "style", "margin-left: 0px; padding-left: 0px");
#nullable restore
#line 29 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                         foreach (var task in tasks)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "style", "list-style-type: none");
            __builder.OpenComponent<BlazorStrap.BSBasicForm>(24);
            __builder.AddAttribute(25, "IsInline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.TodoList.Pages.ToDoGoogle.TypeInference.CreateBSBasicInput_1(__builder2, 27, 28, 
#nullable restore
#line 33 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                             InputType.Text

#line default
#line hidden
#nullable disable
                , 29, "width: 300px; background: #2795a3", 30, 
#nullable restore
#line 33 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                                           task.Title

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.Title = __value, task.Title)));
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.OpenComponent<BlazorStrap.BSButton>(33);
                __builder2.AddAttribute(34, "style", "background-color: #33727a;");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                                               ()=>ToDoTaskService.DeleteTaskFromList(taskList.Id, task.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "X");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<br>\r\n                <br>");
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenComponent<BlazorStrap.BSButton>(39);
            __builder.AddAttribute(40, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                         () => ModalCreateTask.Show()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "Добавить новую задачу");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenComponent<BlazorStrap.BSButton>(44);
            __builder.AddAttribute(45, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                         () => ModalCreateListTask.Show()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "Добавить новый список");
            }
            ));
            __builder.CloseComponent();
            __builder.OpenComponent<BlazorStrap.BSModal>(48);
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(50);
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                   () => ModalCreateTask.Hide()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "Новая задача");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(57, "div");
                    __builder3.AddMarkupContent(58, "\r\n                Выберите в какой список добавить задачу\r\n                <br>");
#nullable restore
#line 59 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                 foreach (var item in tasksList)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<BlazorStrap.BSButton>(59);
                    __builder3.AddAttribute(60, "IsActive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                              () => selectTaskList = item

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(63, 
#nullable restore
#line 61 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                                             item.Title

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n                        <br>");
#nullable restore
#line 63 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(65, "p");
                    __Blazor.TodoList.Pages.ToDoGoogle.TypeInference.CreateBSBasicInput_2(__builder3, 66, 67, 
#nullable restore
#line 65 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
                    , 68, 
#nullable restore
#line 65 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                          titleNewTask

#line default
#line hidden
#nullable disable
                    , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => titleNewTask = __value, titleNewTask)));
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSModalFooter>(71);
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSButton>(73);
                    __builder3.AddAttribute(74, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 70 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                             Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                      AddNewTaskInList

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(77, "Добавить");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSButton>(79);
                    __builder3.AddAttribute(80, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 71 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                             Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                          () => ModalCreateTask.Hide()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(83, "Отмена");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 51 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                   ModalCreateTask = (BlazorStrap.BSModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.OpenComponent<BlazorStrap.BSModal>(85);
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(87);
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                   () => ModalCreateListTask.Hide()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(90, "Новый список");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(92);
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(94, "div");
                    __builder3.OpenElement(95, "p");
                    __Blazor.TodoList.Pages.ToDoGoogle.TypeInference.CreateBSBasicInput_3(__builder3, 96, 97, 
#nullable restore
#line 81 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
                    , 98, 
#nullable restore
#line 81 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                                          titleNewListTask

#line default
#line hidden
#nullable disable
                    , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => titleNewListTask = __value, titleNewListTask)));
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSModalFooter>(101);
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSButton>(103);
                    __builder3.AddAttribute(104, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 86 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                             Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                      AddNewListTask

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(107, "Добавить");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSButton>(109);
                    __builder3.AddAttribute(110, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 87 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                             Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                                                          () => ModalCreateListTask.Hide()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(113, "Отмена");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(114, (__value) => {
#nullable restore
#line 76 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
                   ModalCreateListTask = (BlazorStrap.BSModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 90 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "D:\Университет\4 семестр\Веб-программирование\by Земцов\TodoList\Pages\ToDoGoogle.razor"
      
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
namespace __Blazor.TodoList.Pages.ToDoGoogle
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
