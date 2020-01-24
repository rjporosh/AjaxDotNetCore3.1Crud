#pragma checksum "C:\Users\Rj Porosh\source\repos\CoreAjaxCrud\CoreAjaxCrud\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a2b2381c053ce3430f964db0bf6f53c12563d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Rj Porosh\source\repos\CoreAjaxCrud\CoreAjaxCrud\Views\_ViewImports.cshtml"
using CoreAjaxCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rj Porosh\source\repos\CoreAjaxCrud\CoreAjaxCrud\Views\_ViewImports.cshtml"
using CoreAjaxCrud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a2b2381c053ce3430f964db0bf6f53c12563d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a52724b809008f86cfb9e8c77695161621bf23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/Users.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Rj Porosh\source\repos\CoreAjaxCrud\CoreAjaxCrud\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <script>
            $.ajax({
        url: ""/Home/List"",
        type: ""GET"",
        contentType: ""application/json;charset=utf-8"",
        dataType: ""json"",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.Age + '</td>';
                html += '<td>' + item.State + '</td>';
                html += '<td>' + item.Country + '</td>';
                html += '<td><a href=""#"" onclick=""return getbyID(' + item.Id + ')"">Edit</a> | <a href=""#"" onclick=""Delele(' + item.Id + ')"">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    </script>
    <h2>Users Record<");
            WriteLiteral(@"/h2>
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"" onclick=""clearTextBox();"">Add New User</button><br /><br />
    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>
                    ID
                </th>
                <th>
                    Name
                </th>
                <th>
                    Age
                </th>
                <th>
                    State
                </th>
                <th>
                    Country
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody class=""tbody""></tbody>
    </table>
</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <butto");
            WriteLiteral("n type=\"button\" class=\"close\" data-dismiss=\"modal\">×</button>\r\n                <h4 class=\"modal-title\" id=\"myModalLabel\">Add Employee</h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a2b2381c053ce3430f964db0bf6f53c12563d97039", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""Id"">ID</label>
                        <input type=""text"" class=""form-control"" id=""Id"" placeholder=""Id"" disabled=""disabled"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Name"">Name</label>
                        <input type=""text"" class=""form-control"" id=""Name"" placeholder=""Name"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Age"">Age</label>
                        <input type=""text"" class=""form-control"" id=""Age"" placeholder=""Age"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""State"">State</label>
                        <input type=""text"" class=""form-control"" id=""State"" placeholder=""State"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""Country"">Country</la");
                WriteLiteral("bel>\r\n                        <input type=\"text\" class=\"form-control\" id=\"Country\" placeholder=\"Country\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a2b2381c053ce3430f964db0bf6f53c12563d99563", async() => {
                WriteLiteral("\r\n                    <label for=\"usersDropdown\"><b>Users</b></label>\r\n                    <select class=\"form-control\" id=\"usersDropdown\" name=\"usersDropdown\"></select>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""btnAdd"" onclick=""return Add();"">Add</button>
                <button type=""button"" class=""btn btn-primary"" id=""btnUpdate"" style=""display:none;"" onclick=""Update();"">Update</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a2b2381c053ce3430f964db0bf6f53c12563d911562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
    debugger;
    loadData();
    $.ajax({
        type: ""GET"",
        url: ""/Home/getUser"",
        data: ""{}"",
        success: function (data) {
            var s = '<option value=""-1"">Please Select a User</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value=""' + data[i].Id + '"">' + data[i].Name + '</option>';
            }
            $(""#usersDropdown"").html(s);
        }
    });
});
function loadData() {
    $.ajax({
        url: ""/Home/List"",
        type: ""GET"",
        contentType: ""application/json;charset=utf-8"",
        dataType: ""json"",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.Age + '</td>';
                html += '<td>' + item.S");
            WriteLiteral(@"tate + '</td>';
                html += '<td>' + item.Country + '</td>';
                html += '<td><a href=""#"" onclick=""return getbyID(' + item.Id + ')"">Edit</a> | <a href=""#"" onclick=""Delele(' + item.Id + ')"">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function Add() {
    debugger;
    var res = validate();
    if (res == false) {
        return false;
    }

    var empObj = {
        Id: $('#Id').val(),
        Name: $('#Name').val(),
        Age: $('#Age').val(),
        State: $('#State').val(),
        Country: $('#Country').val()  ,
    };
    $.ajax({
        url: ""/Home/Add"",
        data: JSON.stringify(empObj),
        type: ""POST"",
        contentType: ""application/json;charset=utf-8"",
        dataType: ""json"",
        success: function (result) {
            loadData();
            get");
            WriteLiteral(@"Users();
            //  $('#myModal').modal('hide');
            $('#Id').val(result.Id)
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function getbyID(Id) {
    $('#Name').css('border-color', 'lightgrey');
    $('#Age').css('border-color', 'lightgrey');
    $('#State').css('border-color', 'lightgrey');
    $('#Country').css('border-color', 'lightgrey');
    $.ajax({
        url: ""/Home/GetbyID/"" + Id,
        typr: ""GET"",
        contentType: ""application/json;charset=UTF-8"",
        dataType: ""json"",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#Name').val(result.Name);
            $('#Age').val(result.Age);
            $('#State').val(result.State);
            $('#Country').val(result.Country);
            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
       ");
            WriteLiteral(@"     alert(errormessage.responseText);
        }
    });
    return false;
}
function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var empObj = {
        Id: $('#Id').val(),
        Name: $('#Name').val(),
        Age: $('#Age').val(),
        State: $('#State').val(),
        Country: $('#Country').val(),
    };
    $.ajax({
        url: ""/Home/Update"",
        data: JSON.stringify(empObj),
        type: ""POST"",
        contentType: ""application/json;charset=utf-8"",
        dataType: ""json"",
        success: function (result) {
            loadData();
            getUsers();
            $('#myModal').modal('hide');
            $('#Id').val("""");
            $('#Name').val("""");
            $('#Age').val("""");
            $('#State').val("""");
            $('#Country').val("""");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function Delele(ID) {
    var ans ");
            WriteLiteral(@"= confirm(""Are you sure you want to delete this Record?"");
    if (ans) {
        $.ajax({
            url: ""/Home/Delete/"" + ID,
            type: ""POST"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                loadData();
                getUsers();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}
function getUsers() {
    $.ajax({
        type: ""GET"",
        url: ""/Home/getUser"",
        data: ""{}"",
        success: function (data) {
            var s = '<option value=""-1"">Please Select a User</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value=""' + data[i].Id + '"">' + data[i].Name + '</option>';
            }
            $(""#usersDropdown"").html(s);
        }
    });  
}
function clearTextBox() {
    $('#Id').val("""");
    $('#Name').val("""");
 ");
            WriteLiteral(@"   $('#Age').val("""");
    $('#State').val("""");
    $('#Country').val("""");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#Name').css('border-color', 'lightgrey');
    $('#Age').css('border-color', 'lightgrey');
    $('#State').css('border-color', 'lightgrey');
    $('#Country').css('border-color', 'lightgrey');
}
function validate() {
    var isValid = true;
    if ($('#Name').val().trim() == """") {
        $('#Name').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Name').css('border-color', 'lightgrey');
    }
    if ($('#Age').val().trim() == """") {
        $('#Age').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Age').css('border-color', 'lightgrey');
    }
    if ($('#State').val().trim() == """") {
        $('#State').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#State').css('border-color', 'lightgrey');
    }
    if ($('#Country').val().trim() == """") {
     ");
            WriteLiteral("   $(\'#Country\').css(\'border-color\', \'Red\');\r\n        isValid = false;\r\n    }\r\n    else {\r\n        $(\'#Country\').css(\'border-color\', \'lightgrey\');\r\n    }\r\n    return isValid;\r\n}\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a2b2381c053ce3430f964db0bf6f53c12563d919256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
