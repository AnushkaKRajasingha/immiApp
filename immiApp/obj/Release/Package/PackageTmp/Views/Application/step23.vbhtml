@Code
    ViewData("Title") = "step23"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Character declarations"
End Code
<form class="form-horizontal" role="form">
    <div>
            <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been charged with any offence that is currently awaiting legal action?</label>
            <label class="radio-inline" for="cardec1">
                <input type="radio" name="cardec1" value="yes" data-target="cardec1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec1">
                <input type="radio" name="cardec1" value="no" checked data-target="cardec1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec1-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been convicted of an offence in any country (including any conviction which is now removed from official records)?</label>
            <label class="radio-inline" for="cardec2">
                <input type="radio" name="cardec2" value="yes" data-target="cardec2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec2">
                <input type="radio" name="cardec2" value="no" checked data-target="cardec2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec2-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been the subject of an arrest warrant or Interpol notice?</label>
            <label class="radio-inline" for="cardec3">
                <input type="radio" name="cardec3" value="yes" data-target="cardec3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec3">
                <input type="radio" name="cardec3" value="no" checked data-target="cardec3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec3-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been found guilty of a sexually based offence involving a child (including where no conviction was recorded)?</label>
            <label class="radio-inline" for="cardec4">
                <input type="radio" name="cardec4" value="yes" data-target="cardec4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec4">
                <input type="radio" name="cardec4" value="no" checked data-target="cardec4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec4-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been named on a sex offender register?</label>
            <label class="radio-inline" for="cardec5">
                <input type="radio" name="cardec5" value="yes" data-target="cardec5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec5">
                <input type="radio" name="cardec5" value="no" checked data-target="cardec5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec5-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been acquitted of any offence on the grounds of unsoundness of mind or insanity?</label>
            <label class="radio-inline" for="cardec6">
                <input type="radio" name="cardec6" value="yes" data-target="cardec6-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec6">
                <input type="radio" name="cardec6" value="no" checked data-target="cardec6-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec6-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been found by a court not fit to plead?</label>
            <label class="radio-inline" for="cardec7">
                <input type="radio" name="cardec7" value="yes" data-target="cardec7-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec7">
                <input type="radio" name="cardec7" value="no" checked data-target="cardec7-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec7-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been directly or indirectly involved in, or associated with, activities which would represent a risk to national security in Australia or any other country?</label>
            <label class="radio-inline" for="cardec8">
                <input type="radio" name="cardec8" value="yes" data-target="cardec8-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec8">
                <input type="radio" name="cardec8" value="no" checked data-target="cardec8-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec8-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been charged with, or indicted for: genocide, war crimes, crimes against humanity, torture, slavery, or any other crime that is otherwise of a serious international concern?</label>
            <label class="radio-inline" for="cardec9">
                <input type="radio" name="cardec9" value="yes" data-target="cardec9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec9">
                <input type="radio" name="cardec9" value="no" checked data-target="cardec9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec9-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been associated with a person, group or organisation that has been or is involved in criminal conduct?</label>
            <label class="radio-inline" for="cardec10">
                <input type="radio" name="cardec10" value="yes" data-target="cardec10-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec10">
                <input type="radio" name="cardec10" value="no" checked data-target="cardec10-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec10-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been associated with an organisation engaged in violence or engaged in acts of violence (including war, insurgency, freedom fighting, terrorism, protest) either overseas or in Australia?</label>
            <label class="radio-inline" for="cardec11">
                <input type="radio" name="cardec11" value="yes" data-target="cardec11-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec11">
                <input type="radio" name="cardec11" value="no" checked data-target="cardec11-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec11-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever served in a military force, police force, state sponsored / private militia or intelligence agency (including secret police)?</label>
            <label class="radio-inline" for="cardec12">
                <input type="radio" name="cardec12" value="yes" data-target="cardec12-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec12">
                <input type="radio" name="cardec12" value="no" checked data-target="cardec12-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec12-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Namee</th>
                        <th>Contry of service</th>
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

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever undergone any military/paramilitary training, been trained in weapons/explosives or in the manufacture of chemical/biological products?</label>
            <label class="radio-inline" for="cardec13">
                <input type="radio" name="cardec13" value="yes" data-target="cardec13-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec13">
                <input type="radio" name="cardec13" value="no" checked data-target="cardec13-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec13-yes sr-only">
            <table class="form-group">
                <thead>
                    <tr>
                        <th>Namee</th>
                        <th>Contry of service</th>
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
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been involved in people smuggling or people trafficking offences?</label>
            <label class="radio-inline" for="cardec14">
                <input type="radio" name="cardec14" value="yes" data-target="cardec14-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec14">
                <input type="radio" name="cardec14" value="no" checked data-target="cardec14-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec14-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever been removed, deported or excluded from any country (including Australia)?</label>
            <label class="radio-inline" for="cardec15">
                <input type="radio" name="cardec15" value="yes" data-target="cardec9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec15">
                <input type="radio" name="cardec15" value="no" checked data-target="cardec9-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec15-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever overstayed a visa in any country (including Australia)?</label>
            <label class="radio-inline" for="cardec16">
                <input type="radio" name="cardec16" value="yes" data-target="cardec16-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec16">
                <input type="radio" name="cardec16" value="no" checked data-target="cardec16-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec16-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has any applicant ever had any outstanding debts to the Australian Government or any public authority in Australia?</label>
            <label class="radio-inline" for="cardec17">
                <input type="radio" name="cardec17" value="yes" data-target="cardec17-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="cardec17">
                <input type="radio" name="cardec17" value="no" checked data-target="cardec17-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="cardec17-yes sr-only">
            <div class="form-group">
                <label class="text-left control-label col-md-4">Give details</label>
                <div class="col-md-5">
                    <textarea class="form-control"></textarea>
                </div>
            </div>
        </div>
    </div>
</form>

