@Code
    ViewData("Title") = "step25"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Partner visa declarations"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="control-label"><strong>Warning</strong></label>
            <br />
            <p >Giving false or misleading information is a serious offence.</p>
            <p>The applicants declare that they:</p>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have read and understood the information provided to them in this application.</label>
            <label class="radio-inline" for="declaretion1">
                <input type="radio" name="declaretion1" value="yes" checked data-target="declaretion1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion1">
                <input type="radio" name="declaretion1" value="no" data-target="declaretion1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have provided complete and correct information in every detail on this form, and on any attachments to it.</label>
            <label class="radio-inline" for="declaretion2">
                <input type="radio" name="declaretion2" value="yes" checked data-target="declaretion2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion2">
                <input type="radio" name="declaretion2" value="no" data-target="declaretion2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Understand that if any fraudulent documents or false or misleading information has been provided with this application, or if any of the applicants fail to satisfy the Minister of their identity, the application may be refused and the applicant(s), and any member of their family unit, may become unable to be granted a visa for a specified period of time.</label>
            <label class="radio-inline" for="declaretion3">
                <input type="radio" name="declaretion3" value="yes" checked data-target="declaretion3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion3">
                <input type="radio" name="declaretion3" value="no" data-target="declaretion3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Understand that if documents are found to be fraudulent or information to be incorrect after the grant of a visa, the visa may subsequently be cancelled.</label>
            <label class="radio-inline" for="declaretion4">
                <input type="radio" name="declaretion4" value="yes" checked data-target="declaretion4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion4">
                <input type="radio" name="declaretion4" value="no" data-target="declaretion4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Understand that if this application is approved, any person not included in this application will not have automatic right of entry to Australia.</label>
            <label class="radio-inline" for="declaretion5">
                <input type="radio" name="declaretion5" value="yes" checked data-target="declaretion5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion5">
                <input type="radio" name="declaretion5" value="no" data-target="declaretion5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Will inform the Department of Immigration and Border Protection in writing immediately as they become aware of a change in circumstances (including change of address) or if there is any change relating to information they have provided in or with this application, while it is being considered.</label>
            <label class="radio-inline" for="declaretion6">
                <input type="radio" name="declaretion6" value="yes" checked data-target="declaretion6-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion6">
                <input type="radio" name="declaretion6" value="no" data-target="declaretion6-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have read the information contained in the Privacy Notice (Form 1442i).</label>
            <label class="radio-inline" for="declaretion7">
                <input type="radio" name="declaretion7" value="yes" checked data-target="declaretion7-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion7">
                <input type="radio" name="declaretion7" value="no" data-target="declaretion7-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Understand that the department may collect, use and disclose the applicant's personal information (including biometric information and other sensitive information) as outlined in the Privacy Notice (Form 1442i).</label>
            <label class="radio-inline" for="declaretion8">
                <input type="radio" name="declaretion8" value="yes" checked data-target="declaretion8-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion8">
                <input type="radio" name="declaretion8" value="no" data-target="declaretion8-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <h3>Life in Australia - Australian values</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">The applicant declares that all persons included in this application who are 18 years or over have read, or had explained to them, information provided by the Australian Government on Australian society and values and agrees to the Australian Values statement.</label>
            <label class="radio-inline" for="declaretion9">
                <input type="radio" name="declaretion9" value="yes" checked data-target="declaretion9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="declaretion9">
                <input type="radio" name="declaretion9" value="no" data-target="declaretion9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group col-xs-12">
            <a class="form-control" href="#" data-toggle="modal" data-target="#modalApp" data-modelid="termsncond" data-title="Life in Australia booklet link">Life in Australia booklet link</a><br />
        </div>
        <div class="form-group col-xs-12">
            <a class="form-control" href="#" data-toggle="modal" data-target="#modalApp" data-modelid="viewprystm" data-title="Australian values statement">Australian values statement</a>
        </div>
    </div>
</form>

