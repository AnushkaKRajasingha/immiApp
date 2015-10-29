@Code
    ViewData("Title") = "step4"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Critical data confirmation"
End Code
<form class="form-horizontal" role="form">
    <div>
        <p class="form-group">
            <label>All information provided is important to the processing of this application.</label>
            <label>If the information included on this page is incorrect, it may lead to denial of permission to board an aircraft to Australia, even if a visa has been granted.</label>
            <label class="text-danger"><strong>Confirm that the following information is correct and that it is in the correct fields.</strong></label>
        </p>
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
        <div class="form-group">
            <label class="control-label radio-inline col-xs-12 col-md-3">Is the above information correct?</label>
            <label class="radio-inline" for="rdb_infocorrect">
                <input type="radio" name="rdb_infocorrect" value="yes" checked data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="rdb_infocorrect">
                <input type="radio" name="rdb_infocorrect" value="no" data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
    </div>
</form>


