@ModelType immiApp.NationalIDs
@Code
    Layout = Nothing
End Code
<form class="form-horizontal" role="form">
    <input name="_appGuid" type="hidden" value="" />
    <input name="_stepNumber" type="hidden" value="0" />
    <!-- #region Nid Details -->
    <div class="form-group row">
        <p>Enter details exactly as shown on the national identity document.</p>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Family name </label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Family Name" id="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d0a1a0"
                   name="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d0a1a0" title="Family name" maxlength="100" size="50"
                   value="@Model.FamilyName" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Given names</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Given Names" id="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d1a1a0"
                   name="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0d1a1a0" title="Given names" maxlength="100" size="50"
                   value="@Model.GivenName" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5 ">Type Of Document</label>
        <div class="col-md-4">
            <select class="form-control" id="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0e0b0"
                    name="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0e0b0" title="Type of document">
                @Code
                    For Each __niddoc As KeyValuePair(Of Integer, String) In New immiApp.NidTypes().DocTypes
                        @<option value="@__niddoc.Key" @(If(__niddoc.Key = Model.TypeOfDocument, "selected", "")) >
                        @__niddoc.Value
                         </option>
                    Next
                End Code
            </select>
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Identification number (if shown)</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Identification number" id="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0f0b0"
                   name="_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0f0b0" title="Identification number" maxlength="100" size="50"
                   value="@Model.IdNumber" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Country of issue</label>
        <div class="col-md-4">
            @Html.Partial("~/Views/Shared/CustomControls/custctrlCountries.vbhtml", New CustomCtrlCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0g0b0", .Id = "_2a0b0a0a0a4a0a0c0bf3d-dlg-_0b0bj0a0a0g0b0", .DefaultValue = Model.CountryofIssue})
        </div>
    </div>
    <!-- #endregion Nid Details -->
</form>
