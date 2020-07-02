#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb044f40852c08ba63335d154969d3a0b9d448cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Playlist_Index), @"mvc.1.0.view", @"/Views/Playlist/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\_ViewImports.cshtml"
using MediaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
using MediaApp.Models.Index;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb044f40852c08ba63335d154969d3a0b9d448cf", @"/Views/Playlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Playlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlaylistListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""container"">
    <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" placeholder=""Search on playlist title or creator"" />
    <button onclick=""FilterOn()"" id=""btn"" class=""btn btn-primary""><i class=""fas fa-search""></i></button>
</div>

");
#nullable restore
#line 12 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
  if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <strong>There are currently no playlist listed.</strong>\r\n");
#nullable restore
#line 16 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <thead>
                <tr>
                    <th>
                        Title
                    </th>
                    <th>
                        Duration
                    </th>
                    <th>
                        Amount
                    </th>
                    <th>
                        Creator
                    </th>
                    <th>

                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                 foreach (PlaylistListViewModel playlist in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 47 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.PlaylistMedias.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 53 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.User.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n");
#nullable restore
#line 57 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                             if (signInManager.IsSignedIn(User))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""dropdown"">
                                    <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""fas fa-ellipsis-h""></i>
                                    </button>

                                    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
");
#nullable restore
#line 65 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                                         if (userManager.GetUserId(User) == @playlist.User.Id || User.IsInRole("Admin"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2674, "\"", 2706, 3);
            WriteAttributeValue("", 2684, "GoToEdit(", 2684, 9, true);
#nullable restore
#line 67 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
WriteAttributeValue("", 2693, playlist.Id, 2693, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2705, ")", 2705, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit info</a>\r\n                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2791, "\"", 2830, 3);
            WriteAttributeValue("", 2801, "GoToManageFilms(", 2801, 16, true);
#nullable restore
#line 68 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
WriteAttributeValue("", 2817, playlist.Id, 2817, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2829, ")", 2829, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit items</a>\r\n                                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2916, "\"", 2950, 3);
            WriteAttributeValue("", 2926, "GoToDelete(", 2926, 11, true);
#nullable restore
#line 69 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
WriteAttributeValue("", 2937, playlist.Id, 2937, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2949, ")", 2949, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 70 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3073, "\"", 3107, 3);
            WriteAttributeValue("", 3083, "GoToDetail(", 3083, 11, true);
#nullable restore
#line 72 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
WriteAttributeValue("", 3094, playlist.Id, 3094, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3106, ")", 3106, 1, true);
            EndWriteAttribute();
            WriteLiteral(">View details</a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 75 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 82 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://kit.fontawesome.com/a6748bd2b3.js"" crossorigin=""anonymous""></script>
<script>
    function GoToDetail(id) {
        window.location.href = ""Detail/?id="" + id;
    }
    function GoToManageFilms(id) {
        window.location.href = ""ManageFilms/?id="" + id;
    }
    function FilterOn() {
        var filter = document.getElementById('filter').value
        window.location.href = ""?filter="" + filter;
    }
    function GoToDelete(id) {
        window.location.href = ""Delete/?id="" + id;
    }
    function GoToEdit(id) {
        window.location.href = ""/Edit/?id="" + id;
    }
</script>

<style>
    table, td {
        border-bottom: 1px solid black;
    }

    .info {
        width: 20vw;
    }

    tr:hover {
        background-color: lightgray;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<MediaApp.Domain.User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<MediaApp.Domain.User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlaylistListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
