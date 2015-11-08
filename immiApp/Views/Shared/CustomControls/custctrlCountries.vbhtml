@ModelType immiApp.CustomCtrlCountry
@Code
    Layout = Nothing
End Code
<select class="form-control col-md-6 @Model.ClassName" id="@Model.Id" name="@Model.Id">
    @Code
        For Each _country As KeyValuePair(Of Integer, String) In Model.Countries
            @<option 
            value = "@_country.Key"
            @(If(_country.Key = Convert.ToInt32(Model.DefaultValue), "selected", ""))
            > 
        @(_country.Value)
            </option>
        Next
    End Code
</select>
