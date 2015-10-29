@Code
    ViewData("Title") = "step20"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Language"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <h3>Interpreter services</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is an interpreter required if contacted by the department?</label>
            <label class="radio-inline" for="language">
                <input type="radio" name="language" value="yes" data-target="language-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="language">
                <input type="radio" name="language" value="no" checked data-target="language-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="language-yes sr-only">
            <div class="form-group">
                <h3>Main language</h3>
            </div>
            <div class="form-group">
                <label class="text-left control-label col-md-4">Main language</label>
                <div class="col-md-3">
                    <select class="form-control input-sm">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
                <div class="col-md-2">
                    <button data-placement="bottom" title="Family and given names"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                            type="button"></button>
                </div>
            </div>
        </div>
    </div>
</form>

