@Code
    ViewData("Title") = "step9"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Previous relationships"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="control-label radio-inline col-xs-12 col-md-6">Has the applicant been in any previous relationships with persons other than the sponsor?</label>
            <label class="radio-inline" for="prevrelationship">
                <input type="radio" name="prevrelationship" value="yes"  data-target="prevrelationship-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="prevrelationship">
                <input type="radio" name="prevrelationship" value="no" checked data-target="prevrelationship-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="prevrelationship-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Family name</th>
                        <th>Given names</th>
                        <th>Date of Birth</th>
                        <th>Relationship </th>
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

    </div>
</form>

