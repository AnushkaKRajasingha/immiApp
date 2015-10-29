@Code
    ViewData("Title") = "step10"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Critical Data Confirmation"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <h3>Migrating family members</h3>
            <label>All information provided is important to the processing of this application. <br />
                If the information included on this page is incorrect, it may lead to denial of permission to board an aircraft to Australia, even if a visa has been granted.
            </label>
        </div>
        <div class="form-group">
            <label class="label-default">Confirm that the following information is correct and that it is in the correct fields.</label>
        </div>       
       
        <!-- #region Member1-->
        <div class="form-group">
            <h3>Sample Member 01</h3>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Family Name</label>
            <label class="text-info col-md-3">Sample Family Name</label>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Given names</label>
            <label class="text-info col-md-3">Sample Given names</label>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Sex</label>
            <label class="text-info col-md-3">Male</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Date of Birth</label>
            <label class="text-info col-md-3">Sample - 09 Nov 1975</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Country of birth</label>
            <label class="text-info col-md-3">Sample - UNITED KINGDOM</label>
            <button data-placement="top" title="Place of birth"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="pob1_title"
                    type="button"></button>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Passport number</label>
            <label class="text-info col-md-3">Sample - Passport number</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Country of passport</label>
            <label class="text-info col-md-3">Sample - UNITED KINGDOM - BRITISH CITIZEN - GBR</label>
        </div>
        <!-- #endregion Member2-->
        <!-- #region Member2-->
        <div class="form-group">
            <h3>Sample Member 02</h3>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Family Name</label>
            <label class="text-info col-md-3">Sample Family Name</label>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Given names</label>
            <label class="text-info col-md-3">Sample Given names</label>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Sex</label>
            <label class="text-info col-md-3">Male</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Date of Birth</label>
            <label class="text-info col-md-3">Sample - 09 Nov 1975</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Country of birth</label>
            <label class="text-info col-md-3">Sample - UNITED KINGDOM</label>
            <button data-placement="top" title="Place of birth"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="pob1_title"
                    type="button"></button>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Passport number</label>
            <label class="text-info col-md-3">Sample - Passport number</label>
        </div>
        <div class="form-group">
            <label class="control-label col-md-3">Country of passport</label>
            <label class="text-info col-md-3">Sample - UNITED KINGDOM - BRITISH CITIZEN - GBR</label>
        </div>
        <!-- #endregion Member2-->
    </div>
</form>

