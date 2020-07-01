#pragma checksum "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62cfaa15410c4a374d14e66f539e1e9ead3ad175"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62cfaa15410c4a374d14e66f539e1e9ead3ad175", @"/Views/Playlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c984f0a7ce632dd32656ef5119182c2669c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Playlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlaylistListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div id=""container"">      
            <input type=""text"" class=""form-control"" id=""filter"" name=""filter"" />
            <button onclick=""FilterOn()"" id=""btn"" class=""btn btn-primary""><i class=""fas fa-search""></i></button>                     
    </div>

");
#nullable restore
#line 11 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
  if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <strong>There are currently no playlist listed.</strong>\r\n");
#nullable restore
#line 15 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
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
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                 foreach (PlaylistListViewModel playlist in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1153, "\"", 1187, 3);
            WriteAttributeValue("", 1163, "GoToDetail(", 1163, 11, true);
#nullable restore
#line 38 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
WriteAttributeValue("", 1174, playlist.Id, 1174, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1186, ")", 1186, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.PlaylistMedias.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"
                       Write(playlist.User.UserName.Split('@')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 56 "C:\Users\Jolien\source\repos\MediaApp\MediaApp\MediaApp\Views\Playlist\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://kit.fontawesome.com/a6748bd2b3.js"" crossorigin=""anonymous""></script>
<script>
    function GoToDetail(id) {
        window.location.href = ""Detail/?id="" + id;
    }
    function FilterOn() {
        var filter = document.getElementById('filter').value
        window.location.href = ""?filter="" + filter;
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
