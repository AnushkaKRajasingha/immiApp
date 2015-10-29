@Code
    ViewData("Title") = "step15"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Sponsor’s Immediate Family Members"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Does the applicant have any parents, siblings or children including those that are deceased?</label>
            <label class="radio-inline" for="mifm">
                <input type="radio" name="mifm" value="yes"  data-target="mifm-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="mifm">
                <input type="radio" name="mifm" value="no" checked data-target="mifm-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="mifm-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Family name</th>
                        <th>Given names</th>
                        <th>Sex</th>
                        <th>Date of Birth</th>
                        <th>Immigration status </th>
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
                <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addaifm" data-title="Add Sponsor’s Immediate Family Members">Add</a><br />
            </div>
        </div>
        <div class="mifm-yes">
            <div class=" form-group col-xs-12">
                <label class="text-left control-label col-md-4" for="helthexam-det">Give details</label>
                <div class="col-md-5">
                    <textarea name="helthexam-det" class="form-control"></textarea>
                </div>
            </div>
        </div>
    </div>
</form>

