@ModelType immiApp.CustomDateCtrlModels
@Code
    Layout = Nothing
End Code
<div class="@Model.ClassName" id="@Model.Id" name="@Model.Id">
    <div class="col-xs-4">
        <select class="form-control input-sm @String.Concat(Model.ClassName, "_day")" id="@String.Concat(Model.Id, "_day")" name="@String.Concat(Model.Id, "_day")">
            <option value="??"
                    selected=""></option>
            @Code
                For d As Integer = 1 To 31
                    Dim _isselected = If(d = CType(Model.DefaultValue, CustomDateCtrlModels.DefaulDateValue).day, "selected", "")
                    @<option value="@d.ToString()" @_isselected> @d.ToString() </option>
                Next
            End Code    
        </select>
    </div>
    <div class="col-xs-4">
        <select class="form-control input-sm @String.Concat(Model.ClassName, "_month")" id="@String.Concat(Model.Id, "_month")" name="@String.Concat(Model.Id, "_month")">
            <option value="??"
                    selected=""></option>
            @Code
                For m As Integer = 1 To 12
                    Dim _monthname = MonthName(New DateTime(1, m, 1).Month.ToString(), True)
                    'Dim _isselected = If(_monthname = CType(Model.DefaultValue, CustomDateCtrlModels.DefaulDateValue).month, "selected", "")
                    Dim _isselected = If(m = CType(Model.DefaultValue, CustomDateCtrlModels.DefaulDateValue).month, "selected", "")
                    @<option value = "@_monthname" @_isselected > @_monthname </Option>
                Next
            End Code            
        </select>
    </div>
    <div class="col-xs-4">
        <input type="number" min="1900" max="2017" step="1" class="form-control input-sm @String.Concat(Model.ClassName, "_year")" placeholder="yyyy" title="year" id="@String.Concat(Model.Id, "_year")" name="@String.Concat(Model.Id, "_year")" value="@CType(Model.DefaultValue, CustomDateCtrlModels.DefaulDateValue).year" />
    </div>
</div>

