@Code
    ViewData("Title") = "step5"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Additional identity questions"
End Code
<form class="form-horizontal" role="form">
    <div>
        <p class="form-group">
            <label>Provide further details below, where available.</label>
        </p>
        <div class="form-group">
            <h3>Previous travel to Australia</h3>
        </div>
        <div class="form-group">
            <label class="control-label radio-inline">Has this applicant previously travelled to Australia or previously applied for a visa?</label>
            <label class="radio-inline" for="prev_aus">
                <input type="radio" name="prev_aus" value="yes"  data-target="prev_aus-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="prev_aus">
                <input type="radio" name="prev_aus" value="no" checked data-target="prev_aus-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <!-- #region prev_aus_yes -->
        <div class="prev_aus-yes sr-only">
            <div class="form-group">
                <h3>Expired passports</h3>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline">Does this applicant have expired passports that were previously used to travel to Australia?</label>
                <label class="radio-inline" for="exp_passport">
                    <input type="radio" name="exp_passport" value="yes" data-target="exp_passport-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="exp_passport">
                    <input type="radio" name="exp_passport" value="no" checked data-target="exp_passport-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <!-- #region exp_passport-yes -->
            <div class="exp_passport-yes sr-only">
                <table class="form-group">
                    <thead>
                        <tr>
                            <th>Family name</th>
                            <th>Given names</th>
                            <th>Passport number</th>
                            <th>Country of passport</th>
                            <th>Actions </th>
                        </tr>
                    </thead>
                    <tbody>
                        @Code
                            For index = 1 To 4
                        End Code
                        <tr>
                            <td>sample value @index</td>
                            <td>sample value @index</td>
                            <td>sample value @index</td>
                            <td>sample value @index</td>
                        </tr>
                        @Code
                            Next
                        End Code
                    </tbody>
                </table>

                <div class="form-group col-md-2 pull-right">
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addotherpassports" data-title="Add other passports">Add</a><br />
                </div>
            </div>
            <!-- #endregion exp_passport-yes -->
            <!-- #region Grant number -->
            <div class="form-group">
                <h3>Grant number</h3>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline">Does this applicant have expired passports that were previously used to travel to Australia?</label>
                <label class="radio-inline" for="grant_number">
                    <input type="radio" name="grant_number" value="yes" data-target="grant_number-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="grant_number">
                    <input type="radio" name="grant_number" value="no" checked data-target="grant_number-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
                <button data-placement="bottom" title="Australian visa grant number"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_grantnumber"
                        type="button"></button>
            </div>
            <div class="grant_number-yes sr-only">
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-3">Australian visa grant number</label>
                    <div class="col-md-4">
                        <input type="text" class="form-control input-sm" placeholder="Australian visa grant number" />
                    </div>                    
                </div>
            </div>
            <!-- #endregion Grant number -->
            <!-- #region Visa number -->
            <div class="form-group">
                <h3>Visa number</h3>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline">Does this applicant have an Australian visa label in their current or previous passport?</label>
                <label class="radio-inline" for="visa_number">
                    <input type="radio" name="visa_number" value="yes" data-target="visa_number-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="visa_number">
                    <input type="radio" name="visa_number" value="no" checked data-target="visa_number-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
                <button data-placement="bottom" title="Australian visa label number"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_ausvisanumb"
                type="button"></button>
                
            </div>
            <div class="visa_number-yes sr-only">
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-3">Australian visa label number</label>
                    <div class="col-md-4">
                        <input type="text" class="form-control input-sm" placeholder="Australian visa grant number" />
                    </div>
                </div>
            </div>
            <!-- #endregion Visa number -->
        </div>
        <!-- #endregion prev_aus_yes -->
    </div>
</form>
