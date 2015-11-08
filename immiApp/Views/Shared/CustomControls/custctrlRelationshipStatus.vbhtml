@ModelType immiApp.CustomCtrlRelationshipStatus
@Code
    Layout = Nothing
End Code
<select class="form-control input-sm @Model.ClassName" id="@Model.Id" name="@Model.Id"  title="Relationship status" data-toggleclsprefix="@Model.DataTogglePrefix" data-toggleclass="@Model.DataToggleClass" onchange="toggelElementBySelectOption(this);">
    <option value="1" data-null="1"></option>
    <option value="2"> De Facto </option>
    <option value="3"> Engaged </option>
    <option value="4" > Married </option>
</select>