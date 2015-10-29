@Code
    ViewData("Title") = "step9"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Supporting witnesses"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label>Give details of two supporting witnesses of the relationship between the applicant and the sponsor.</label>
        </div>
        <div class="form-group">
            <table >
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

