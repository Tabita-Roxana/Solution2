// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\Pages\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\Pages\Adults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\tabit\RiderProjects\Solution2\Assignement1\Assignment1\Pages\Adults.razor"
 
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private int? filterById;
    private string? filterByName;

    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultsData.GetAdults();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = allAdults.First(a => a.Id == adultId);
        AdultsData.RemoveAdult(adultId);
        allAdults.Remove(adultToRemove);
    }

    private void FilterById(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e){}
        Filter();

    }

    private void FilterByName(ChangeEventArgs cEventArgs)
    {
         filterByName = "";
        try
        {
            filterByName = cEventArgs.Value.ToString();
        }
        catch (Exception e){}
        
       Filter();
    }
    private void Filter()
    {
        adultsToShow = allAdults.Where(a => (filterById != null && a.Id == filterById || filterById ==null) &&
                                            
                                            (filterByName!=null && a.LastName.Contains(filterByName) || filterByName==null)).ToList();
    }

    private void Edit(int Id)
    {
        NavMgr.NavigateTo($"Edit/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsData AdultsData { get; set; }
    }
}
#pragma warning restore 1591
