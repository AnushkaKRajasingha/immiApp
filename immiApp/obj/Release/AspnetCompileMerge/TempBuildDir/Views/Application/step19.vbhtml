@Code
    ViewData("Title") = "step9"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Sponsor's previous relationships"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has the sponsor been in any previous relationships with persons other than the applicant?</label>
            <label class="radio-inline" for="otherthanapp">
                <input type="radio" name="otherthanapp" value="yes"  data-target="otherthanapp-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="otherthanapp">
                <input type="radio" name="otherthanapp" value="no" checked data-target="otherthanapp-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="otherthanapp-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Family name</th>
                        <th>Given names</th>
                        <th>Date of Birth</th>
                        <th>Date ended</th>
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
                        <td>sample value @index</td>
                    </tr>
                    @Code
                        Next
                    End Code
                </tbody>
            </table>

            <div class="form-group col-md-2 pull-right">
                <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addmifm" data-title="Add other names">Add</a><br />
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has this sponsor previously sponsored/nominated a spouse, de facto, prospective spouse or interdependent partner?</label>
            <label class="radio-inline" for="indpartner">
                <input type="radio" name="indpartner" value="yes" data-target="indpartner-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="indpartner">
                <input type="radio" name="indpartner" value="no" checked data-target="indpartner-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="indpartner-yes sr-only">
            <div class="form-group">
                <p>Partner visas sponsors may be subject to sponsorship limitations if they:</p><p>- previously sponsored another partner applicant in the last five years</p><p>- previously sponsored two (or more) partners  in their lifetime</p><p>- were granted a partner visa in the past five years</p><p>The applicant may wish to review the information on the department's website regarding partner sponsorship eligibility prior to continuing with this application.</p>
            </div>
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Number of times?</label>
                <div class="col-md-3">
                    <input type="text" placeholder="0" class="form-control  input-sm" />
                </div>
            </div>
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Family name</th>
                        <th>Given names</th>
                        <th>Date of Birth</th>
                        <th>Date ended</th>
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
                        <td>sample value @index</td>
                    </tr>
                    @Code
                        Next
                    End Code
                </tbody>
            </table>

            <div class="form-group col-md-2 pull-right">
                <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addmifm" data-title="Add other names">Add</a><br />
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has this sponsor been sponsored/nominated to Australia as a spouse, de facto partner, prospective spouse or interdependent partner?</label>
            <label class="radio-inline" for="indpartner2">
                <input type="radio" name="indpartner2" value="yes" data-target="indpartner2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="indpartner2">
                <input type="radio" name="indpartner2" value="no" checked data-target="indpartner2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="indpartner2-yes sr-only">
            <div class="form-group" ><p>Partner visas sponsors may be subject to sponsorship limitations if they:</p><p>- previously sponsored another partner applicant in the last five years</p><p>- previously sponsored two (or more) partners  in their lifetime</p><p>- were granted a partner visa in the past five years</p><p>The applicant may wish to review the information on the department's website regarding partner sponsorship eligibility prior to continuing with this application.</p></div>
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Date of sponsorship/nomination</label>
                <div class="col-md-3">
                    <input type="date" placeholder="DD/MM/YYYY" class="form-control  input-sm" />
                </div>
            </div>
            <div class="form-group">
                <label class="text-left control-label col-md-4">Location where sponsorship or nomination was lodged</label>
                <div class="col-md-3">
                    <select class="form-control input-sm">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
            </div>
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Date relationship ended</label>
                <div class="col-md-3">
                    <input type="date" placeholder="DD/MM/YYYY" class="form-control  input-sm" />
                </div>
            </div>
            <div class="form-group">
                <label class="text-left control-label col-md-4">How did the relationship end?</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>
    </div>
</form>

