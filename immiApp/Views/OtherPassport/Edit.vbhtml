@ModelType  immiApp.PassportModels
@Code
    Layout = Nothing
End Code
<form class="form-horizontal" role="form">
    <input name="_appGuid" type="hidden" value="" />
    <input name="_stepNumber" type="hidden" value="0" />
    <!-- #region Passport details -->
    <div class="form-group row">
        <p>Enter details exactly as shown on the passport.</p>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Family name </label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Family Name" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0a0b0a"
                   name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0a0b0a" title="Family name" maxlength="100" size="50"
                   value="@Model.FamilyName" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Given names</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Given Names" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0b0b0a"
                   name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d0b0b0a" title="Given names" maxlength="100" size="50"
                   value="@Model.GivenName" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5 ">Sex</label>
        <div class="col-md-6">
            <label class="radio-inline">
                <input class="radio" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1aidm128506048"
                       name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1a" type="radio" value="1" @(If(Model.Sex = 1, "checked", "")) />
                Male
            </label>
            <label class="radio-inline">
                <input class="radio" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1aidm128505832"
                       name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1a" type="radio" value="2"  @(If(Model.Sex = 2, "checked", ""))/>
                Female
            </label>
            <label class="radio-inline">
                <input class="radio" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1aidm128505616"
                       name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d1a1a" type="radio" value="3"  @(If(Model.Sex = 3, "checked", "")) />
                Other
            </label>
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Date of Birth</label>
        <div class="col-md-6">
            @Code
                Dim _defaultdate = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.Dateofbirth.Day, .month = Model.Dateofbirth.Month, .year = Model.Dateofbirth.Year}

            End Code
            @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a", .Id = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0d2a1a", .DefaultValue = _defaultdate})
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Passport number</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Passport number" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e0a1a"
                   name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e0a1a" title="Passport number" maxlength="14" size="14"
                   value="@Model.PassportNumber" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Country of passport</label>
        <div class="col-md-4">
            @Html.Partial("~/Views/Shared/CustomControls/custctrlPassportCountry.vbhtml", New CustomCtrlPassportCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e1a1a", .Id = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e1a1a", .DefaultValue = Model.Country})
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Nationality of passport holder</label>
        <div class="col-md-4">
            @Html.Partial("~/Views/Shared/CustomControls/custctrlPassportCountry.vbhtml", New CustomCtrlPassportCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e2a1a", .Id = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e2a1a", .DefaultValue = Model.Nationality})
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Date of issue</label>
        <div class="col-md-6">
            @Code
                Dim _defaultdate_2a0b0a0a0a4a0a0c0h3a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.DateofIssue.Day, .month = Model.DateofIssue.Month, .year = Model.DateofIssue.Year}

            End Code
            @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a", .Id = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e3a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0h3a1a})
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Date of expiry</label>
        <div class="col-md-6">
            @Code
                Dim _defaultdate_2a0b0a0a0a4a0a0c0h4a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.DateofExpiry.Day, .month = Model.DateofExpiry.Month, .year = Model.DateofExpiry.Year}

            End Code
            @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a", .Id = "_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e4a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0h4a1a})
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-5">Place of issue / issuing authority</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Place of issue" id="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e5a1a"
                   name="_2a0b0a0a0a4a0a0c0be4d-dlg-_0b0bj0a0a0e5a1a" title="Place of issue / issuing authority" maxlength="60" size="50"
                   value="@Model.PlaceofIssue" />
        </div>

    </div>
    <p class="text-info form-group">It is strongly recommended that the passport be valid for at least six months</p>
    <!-- #endregion  Passport details -->
</form>