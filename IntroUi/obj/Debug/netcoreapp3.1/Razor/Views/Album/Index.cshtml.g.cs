#pragma checksum "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0aba88532a8287bfdd33e36b2f26fb99aca81ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_Index), @"mvc.1.0.view", @"/Views/Album/Index.cshtml")]
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
#line 1 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/_ViewImports.cshtml"
using IntroUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/_ViewImports.cshtml"
using IntroUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aba88532a8287bfdd33e36b2f26fb99aca81ae", @"/Views/Album/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353e656a91233b506f215973cba36b7c7757f48a", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IntroUi.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
  
    ViewData["Title"] = "Albums";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Listado de álbumes disponibles</h1>\n\n");
#nullable restore
#line 8 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
 using (Html.BeginForm("Index", "Album", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div>
        <h3>Filtros</h3>
    </div>
    <div class=""input-group mb-3"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""filtroCodigo"">Código</span>
        </div>
        <input type=""number"" class=""form-control"" name=""codigo"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""filtroAlbum"">Album</span>
        </div>
        <input type=""text"" class=""form-control"" name=""album"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"" id=""filtroArtista"">Artista</span>
        </div>
        <input type=""text"" class=""form-control"" name=""artista"">
    </div>
    <div>
        <input type=""submit"" value=""Filtrar"" class=""btn btn-primary pull-left""/>
    </div>
</div>
");
#nullable restore
#line 32 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<div class=\"container\">\n    <table class=\"table table-striped\" >\n        <tr>\n            <th>Album Id</th>\n            <th>Nombre</th>\n            <th>Artista</th>\n        </tr>\n");
#nullable restore
#line 41 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 44 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
               Write(Html.DisplayFor(model => item.AlbumId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 45 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
               Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 46 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
               Write(Html.DisplayFor(model => item.Artist.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 48 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n    <div class=\"text-center\">\n");
#nullable restore
#line 51 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
         for(int i = 1; i <= ViewBag.Pages; i++)
        {
            if(i == ViewBag.ActualPage)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
           Write(Html.ActionLink($"{i} ", "Index", new { page = i }, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
                                                                                                    ;
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
           Write(Html.ActionLink($"{i} ", "Index", new { page = i }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/home/mariano/Source/vsCodeIntro/IntroUi/Views/Album/Index.cshtml"
                                                                    ;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IntroUi.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
