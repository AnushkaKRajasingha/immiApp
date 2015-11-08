@ModelType immiApp.CustomCtrlLeagalStatus
@Code
    Layout = Nothing
End Code
<select class="form-control input-sm @Model.ClassName" id="@Model.Id" name="@Model.Id" onchange="toggelElemDisplay(this, '1,2');" checked data-target="clsLeagalStatus-opt" data-toggleclass="sr-only">
    @Code
        For Each _leagalstatus As KeyValuePair(Of Integer, String) In Model.LeagalStatus
            @<option value="@_leagalstatus.Key"
                     @(If(_leagalstatus.Key = Convert.ToInt32(Model.DefaultValue), "selected", ""))>
                @(_leagalstatus.Value)
            </option>
        Next
    End Code
</select>


