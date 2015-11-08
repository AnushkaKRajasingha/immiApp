@ModelType IEnumerable(Of immiApp.ApplicationModels)
@Code
    ViewData("Title") = "ListApps"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>List of applications</h2>

<p>
    @Html.ActionLink("Create New", "Create", "Application", Nothing, New With {.class = "btn btn-primary btn-success"})
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.UniqueID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PrimaryApplicent.FamilyName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PrimaryApplicent.Dateofbirth)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.LastUpdate)
            </th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>
                    @Html.ActionLink(item.UniqueID, "Details", "Application", New With {.id = item.Guid}, Nothing)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.PrimaryApplicent.FamilyName)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.PrimaryApplicent.Dateofbirth)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.LastUpdate)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Details", New With {.id = item.Guid}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Guid})
                </td>
            </tr>
        Next
    </tbody>
</table>
