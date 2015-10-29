@Code
    ViewData("Title") = "step21"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Countries resided / visited"
End Code
<form class="form-horizontal" role="form">
    <div>
        <!--#region Resided -->
        <div class="form-group">
            <h3>Resided</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have any of the applicants lived in a country for more than 12 months cumulatively in the past 10 years?</label>
            <label class="radio-inline" for="resided">
                <input type="radio" name="resided" value="yes" data-target="resided-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="resided">
                <input type="radio" name="resided" value="no" checked data-target="resided-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="resided-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Namee</th>
                        <th>Contry</th>
                        <th>Address</th>
                        <th>Date from</th>
                        <th>Date to</th>
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
        <!--#endregion Resided -->
        <!--#region Visited -->
        <div class="form-group">
            <h3>Visited</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have any of the applicants visited any countries for less than 12 months in the past 10 years?</label>
            <label class="radio-inline" for="visited">
                <input type="radio" name="visited" value="yes" data-target="visited-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="visited">
                <input type="radio" name="visited" value="no" checked data-target="visited-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="visited-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Namee</th>
                        <th>Contry</th>                        
                        <th>Date from</th>
                        <th>Date to</th>
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
        <!--#endregion Visited -->
    </div>
</form>

