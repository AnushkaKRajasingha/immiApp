@Code
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Terms and Conditions"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group col-xs-12">
            <a class="form-control" href="#" data-toggle="modal" data-target="#modalApp" data-modelid="termsncond" data-title="Terms and Conditions">View Terms and Conditions</a><br />
        </div>
        <div class="form-group col-xs-12">
            <a class="form-control" href="#" data-toggle="modal" data-target="#modalApp" data-modelid="viewprystm" data-title="Privacy statement">View Privacy statement</a>
        </div>
        <div class="form-group col-xs-12">
            <label class="control-label checkbox pull-left">
                <input type="checkbox" onclick="jQuery('.buttonNext').toggleClass('buttonDisabled',!this.checked);" checked  />
                I have read and agree to the terms and conditions
            </label>
        </div>
    </div>
</form>