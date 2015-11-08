@ModelType immiApp.ApplicationModels
@Code
    ViewData("Title") = "step4"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Critical data confirmation"
End Code
<div class="form-horizontal">
    <div>
        <p class="form-group">
            <label>All information provided is important to the processing of this application.</label>
            <label>If the information included on this page is incorrect, it may lead to denial of permission to board an aircraft to Australia, even if a visa has been granted.</label>
            <label class="text-danger"><strong>Confirm that the following information is correct and that it is in the correct fields.</strong></label>
        </p>
        <div class="form-group">
            <label class="control-label col-md-3">Family Name</label>
            <label class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.FamilyName)</label>
            
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Given names</label>
            <Label Class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.GivenName)</label>
            
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Sex</label>
            <Label Class="text-info col-md-3">@Html.Raw((If(Model.PrimaryApplicent.Sex = 1, "Male", (If(Model.PrimaryApplicent.Sex = 2, "Female", "Other")))))</label>
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Date of Birth</label>
            <Label Class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.Dateofbirth.ToShortDateString())</label>
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Country of birth</label>
            
            <Label Class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.PlaceofBirth.GetCountryName())</label>
            
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Passport number</label>
            <Label Class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.Passport.PassportNumber)</label>
        </div>
        <div Class="form-group">
            <Label Class="control-label col-md-3">Country of passport</label>
            <Label Class="text-info col-md-3">@Html.Raw(Model.PrimaryApplicent.Passport.GetCountryName())</label>
        </div>
        <div Class="form-group">
            <Label Class="control-label radio-inline col-xs-12 col-md-3">Is the above information correct?</label>
            <Label Class="radio-inline" for="rdb_infocorrect">
                <input type = "radio" value="1" checked data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" id="_2a0b0a0a0a4a0a0d0j0b0idm196343864"
                                                                                                        name="_2a0b0a0a0a4a0a0d0j0b0" onclick="jQuery('.buttonNext').toggleClass('buttonDisabled',!this.checked);"/>
                Yes
            </label>
            <Label Class="radio-inline" for="rdb_infocorrect">
                <input type = "radio" value="2" data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" id="_2a0b0a0a0a4a0a0d0j0b0idm196315496"
                                                                                                    name="_2a0b0a0a0a4a0a0d0j0b0" checked onclick="jQuery('.buttonNext').toggleClass('buttonDisabled',this.checked);" />
                No
            </label>
        </div>
    </div>
</div>


