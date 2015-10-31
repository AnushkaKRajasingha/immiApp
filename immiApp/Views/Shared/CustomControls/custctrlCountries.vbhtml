@ModelType immiApp.CustomCtrlCountry
@Code
    Layout = Nothing
End Code
<select class="form-control col-md-6 @Model.ClassName"  id="@Model.Id" name="@Model.Id" >
    @Code
        For Each _country As KeyValuePair(Of String, String) In Model.Countries
            @<option value = "@_country.Key" >@_country.Key</Option>
        Next
    End Code    
</select>

