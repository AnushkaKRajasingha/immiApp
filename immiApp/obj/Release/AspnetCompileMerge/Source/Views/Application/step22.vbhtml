@Code
    ViewData("Title") = "step22"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Visa history"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has the applicant or any person included in this application ever had a visa cancelled?</label>
            <label class="radio-inline" for="cancelled">
                <input type="radio" name="cancelled" value="yes" data-target="cancelled-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cancelled">
                <input type="radio" name="cancelled" value="no" checked data-target="cancelled-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cancelled-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has the applicant or any person included in this application ever been refused an entry permit or visa to Australia?</label>
            <label class="radio-inline" for="refused">
                <input type="radio" name="refused" value="yes" data-target="refused-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="refused">
                <input type="radio" name="refused" value="no" checked data-target="refused-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="refused-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>
    </div>
</form>

