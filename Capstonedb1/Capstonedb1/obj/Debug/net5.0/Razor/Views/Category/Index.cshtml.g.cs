#pragma checksum "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bad10712a670b7e840719de1ea4cb97639bbdc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\_ViewImports.cshtml"
using Capstonedb1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\_ViewImports.cshtml"
using Capstonedb1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bad10712a670b7e840719de1ea4cb97639bbdc3", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080e191721ca13c209f612a24d680987b09ec585", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
  
    ViewBag.Tile = "Category List";
    int no = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"navbar navbar-light mt-1\">\r\n    <a class=\"navbar-brand btn btn-outline-light\" data-bs-toggle=\"modal\"\r\n       data-bs-target=\"#AddCategoryModel\">\r\n        Add\r\n    </a>\r\n</nav>\r\n<div class=\"text-danger\">");
#nullable restore
#line 15 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
                    Write(ViewData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"text-success\">");
#nullable restore
#line 16 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
                     Write(ViewData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""modal fade"" id=""AddCategoryModel"" tabindex=""-1"" aria-labelledby=""AddCategory"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalLabel"">
                    Add Category
                </h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>

            </div>
            <div class=""modal-body"">
                <div class=""row m-2"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtCategory"" name=""category"" placeholder=""Enter Category name"" />
                        <div class=""text-danger"" id=""divCategoryError"">

                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismis");
            WriteLiteral(@"s=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnCategory"">Add Category</button>
                </div>
            </div>
        </div>

    </div>

</div>

<div class=""modal fade"" id=""EditCategoryModel"" tabindex=""-1"" aria-labelledby=""EditCategory"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""exampleModalLabel"">
                    Edit Category
                </h4>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""row m-2"">
                    <div class=""col-sm-12"">
                        <input type=""hidden"" class=""form-control"" id=""editCategoryId"" />
                        <input type=""text"" class=""form-control"" id=""editCategoryName"" name=""Newcategory"" placeholder=""E");
            WriteLiteral(@"nter New Category name"" />
                        <div class=""text-danger"" id=""divEditCategoryError""></div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnEditCategory"">Save Changes</button>
                </div>
            </div>
        </div>
    </div>
</div>




<div class=""border border-1 rounded border-secondary bg-dark text-white p-1 m-1"">
    <div class=""row fs-5 fw-bold"">
        <div class=""col-sm-2 m-1"">Sr.No</div>
        <div class=""col-sm-4 m-1"">Name</div>
        <div class=""col-sm-3 m-1"">Actions</div>
    </div>

");
#nullable restore
#line 83 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
     foreach (Category each in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row border rounded m-1 align-items-center fs-6 word-wrap bg-light text-dark\">\r\n            <div class=\"col-sm-2 pt-2\">\r\n                ");
#nullable restore
#line 87 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
           Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-4 pt-2\">\r\n                ");
#nullable restore
#line 91 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
           Write(each.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-sm-3 pt-2\">\r\n\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 3893, "\"", 3972, 1);
#nullable restore
#line 97 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
WriteAttributeValue("", 3900, Url.Action("EditCategory", "Category", new { editCategoryId = each.Id}), 3900, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm m-1\" data-bs-toggle=\"modal\"\r\n                   data-bs-target=\"#EditCategoryModel\" data-id=\"");
#nullable restore
#line 98 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
                                                           Write(each.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4137, "\"", 4208, 1);
#nullable restore
#line 100 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
WriteAttributeValue("", 4144, Url.Action("RemoveCategory", "Category", new { Cid = each.Id }), 4144, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you sure you want to delete this category?\')\" class=\"btn btn-danger btn-sm m-1\">Delete</a>\r\n\r\n\r\n            </div>\r\n\r\n");
#nullable restore
#line 105 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
              
                no = no + 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 109 "C:\my data\OneDrive - Arrow Electronics, Inc\Desktop\.Net Task\Capstonedb1\Capstonedb1\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function IsBlank(input) {
            let value = input.val().trim();

            if (value == undefined || value == '') {
                return true;
            }
            return false;

        }

        function IsOnlyNumeric(input) {
            let value = input.val().trim();
            return isNaN(value);
        }

        $(document).ready(function () {
            $('#btnCategory').on(""click"", function () {
                $(""#divCategoryError"").text("""");
                let category = $('#txtCategory');
                let blank = IsBlank(category);

                if (!blank) {
                    if (!IsOnlyNumeric(category)) {
                        $(""#divCategoryError"").text(""Only numbers are not allowed"");
                        return;
                    }
                    else {

                        $.post(""/Category/AddCategory"", {
                            name: category.val().trim()
                        },
   ");
                WriteLiteral(@"                         function (data) {
                                if (data) {
                                    alert(""Success"");
                                    window.location.href = ""/Category/Index"";
                                }
                                else {
                                    alert("" Category name already exists"");
                                }
                            });
                    }
                }
                else {
                    $(""#divCategoryError"").text(""Category should not empty"");
                    return;
                }
            })
        })

        $(document).ready(function () {
            $(""#EditCategoryModel"").on(""show.bs.modal"", function (e) {
                // Get the button that triggered the modal
                var button = $(e.relatedTarget);
                // Get the ID of the category to be edited from data-id attribute of the button
                var categoryId = butto");
                WriteLiteral(@"n.data(""id"");
                // Get the name of the category to be edited from data-name attribute of the button
                var categoryName = button.data(""name"");
                // Fill the form fields with category ID and name
                $(""#editCategoryId"").val(categoryId);
                $(""#editCategoryName"").val(categoryName);
            });

            $(""#btnEditCategory"").on(""click"", function () {
                var categoryId = $(""#editCategoryId"").val();
                var categoryName = $(""#editCategoryName"").val().trim();


                if (!categoryName) {
                    $(""#divEditCategoryError"").text(""Category name is required."");
                    return;
                }

                // Update category using AJAX
                $.ajax({
                    url: ""/Category/Edit"",
                    method: ""POST"",
                    data: {
                        Cid: categoryId,
                        name: categoryName
          ");
                WriteLiteral(@"          },
                    success: function (data) {
                        if (data.success) {
                            // Refresh the category list after successful update
                            location.reload();
                        } else {
                            $(""#divEditCategoryError"").text(data.message);
                        }
                    },
                    error: function () {
                        $(""#divEditCategoryError"").text(""An error occurred while updating the category."");
                    }
                });
            });
        });
    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
