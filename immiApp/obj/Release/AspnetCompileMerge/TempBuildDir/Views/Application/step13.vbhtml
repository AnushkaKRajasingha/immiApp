@Code
    ViewData("Title") = "step13"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Sponsor"
End Code
<form class="form-horizontal" role="form">
    <div>
        <!--#region Personal details-->
        <div class="form-group ">
            <h3 class="col-md-3">
                Personal details
                <button data-placement="bottom" title="Personal details"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="ppd1_title"
                        type="button"></button>
            </h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Family name</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Family Name" />
            </div>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Given names</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Given Names" />
            </div>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4 ">Sex</label>
            <div class="col-md-6">
                <label class="radio-inline">
                    <input type="radio" class="radio" value="male" name="rdbSex" />
                    Male
                </label>
                <label class="radio-inline">
                    <input type="radio" class="radio" value="female" name="rdbSex" />
                    Female
                </label>
                <label class="radio-inline">
                    <input type="radio" class="radio" value="other" name="rdbSex" />
                    Other
                </label>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Date of Birth</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <div class="form-group ">
            <h3 class="col-md-3">
                Passport details
                <button data-placement="bottom" title="Passport details"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="ppd1_title"
                        type="button"></button>
            </h3>
        </div>
        <!--#endregion Personal details-->
        <!-- #region sponser passport details -->
        <div class="form-group">
            <label class="text-left control-label radio-inline">Does this sponsor have a passport?</label>
            <label class="radio-inline" for="has_passport">
                <input type="radio" name="has_passport" value="yes" data-target="has_passport-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="has_passport">
                <input type="radio" name="has_passport" value="no" checked data-target="has_passport-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="has_passport-yes sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Passport number</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="1234567890" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Country of passport</label>
                <div class="col-md-4">
                    <select class="form-control input-sm">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Nationality of passport holder</label>
                <div class="col-md-4">
                    <select class="form-control input-sm">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Date of issue</label>
                <div class="col-md-4">
                    <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Date of expiry</label>
                <div class="col-md-4">
                    <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Place of issue / issuing authority</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="Place of issue" />
                </div>

            </div>
        </div>
        <!-- #endregion sponser passport details -->
        <!-- #region Place of birth -->
        <div class="form-group ">
            <h3 class="col-md-3">
                Country of birth
            </h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Country of birth</label>
            <div class="col-md-4">
                <select class="form-control input-sm">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
            <div class="col-md-2">
                <button data-placement="bottom" title="Country of birth"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_countryofbirth"
                        type="button"></button>
            </div>
        </div>
        <!-- #endregion Place of birth -->
        <!-- #region Relationship status -->
        <div class="form-group row">
            <h3 class="col-md-3">
                Relationship status
            </h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Relationship status</label>
            <div class="col-md-4">
                <select class="form-control input-sm">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
            <div class="col-md-2">
                <button data-placement="bottom" title="Relationship status"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_relshipstatus"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-4">Date of marriage</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <!-- #endregion Relationship status -->
        <!-- #region Other names / spellings -->
        <div class="form-group row">
            <h3 class=form-group">
                Other names / spellings
            </h3>
            <div class="form-group">
                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor currently, or have they ever been known by any other names?</label>
                <label class="radio-inline" for="othername1">
                    <input type="radio" name="othername1" value="yes" checked data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="othername1">
                    <input type="radio" name="othername1" value="no" data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="othername1-yes col-xs-12">
                <table class="form-group">
                    <thead>
                        <tr>
                            <th>Family name</th>
                            <th>Given names</th>
                            <th>Reason</th>
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
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addothernames" data-title="Add other names">Add</a><br />
                </div>
            </div>

        </div>

        <!-- #endregion Other names / spellings -->
        <!-- #region Citizenship -->
        <h3 class="form-group">
            Citizenship
        </h3>        
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor a citizen of any other country?</label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input type="radio" name="citizen1_othercounty" value="yes"  data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input type="radio" name="citizen1_othercounty" value="no" checked data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="citizen1_othercounty-yes sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">List countries</label>
                <div class="col-md-4">
                    <select class="form-control input-sm">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
                <div class="col-md-2">
                    <button data-placement="bottom" title="Other citizenship"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_othercitizenship"
                            type="button"></button>
                </div>
            </div>
        </div>
        <!-- #endregion Citizenship -->
        <!--#region Australian citizenship -->
        <div class="form-group">
            <h3>Australian citizenship</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor an Australian citizen by birth?</label>
            <label class="radio-inline" for="auscitizenship">
                <input type="radio" name="auscitizenship" value="yes" checked data-target="auscitizenship-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="auscitizenship">
                <input type="radio" name="auscitizenship" value="no"  data-target="auscitizenship-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="auscitizenship-no sr-only">
            <div class="form-group">
                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor an Australian citizen by grant?</label>
                <label class="radio-inline" for="citizenbygrant">
                    <input type="radio" name="citizenbygrant" value="yes" checked data-target="citizenbygrant-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="citizenbygrant">
                    <input type="radio" name="citizenbygrant" value="no" data-target="citizenbygrant-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
            <div class="citizenbygrant-no sr-only">
                <div class="form-group">
                    <h3>Eligible New Zealand citizen</h3>
                </div>
                    <div class="form-group">
                        <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor an eligible New Zealand citizen?</label>
                        <label class="radio-inline" for="enz_citizen">
                            <input type="radio" name="enz_citizen" value="yes" checked data-target="enz_citizen-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            Yes
                        </label>
                        <label class="radio-inline" for="enz_citizen">
                            <input type="radio" name="enz_citizen" value="no" data-target="enz_citizen-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            No
                        </label>
                        <button data-placement="bottom" title="Family and given names"
                                data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                                type="button"></button>
                    </div>
                    <div class="enz_citizen-no">
                        <div class="form-group col-xs-12">
                            <label class="text-left control-label col-md-4">Length of residence in Australia</label>
                            <div class="col-md-4">
                                <input type="text" class="form-control input-sm" placeholder="Length of residence in Australia" />
                            </div>
                        </div>
                    </div>
                    <div class="enz_citizen-no">
                        <div class="form-group">
                            <h3>Australian Permanent Residency</h3>
                        </div>
                        <div class="form-group">
                            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this sponsor an Australian Permanent Resident?</label>
                            <label class="radio-inline" for="aus_perm_res">
                                <input type="radio" name="aus_perm_res" value="yes"  data-target="aus_perm_res-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                Yes
                            </label>
                            <label class="radio-inline" for="aus_perm_res">
                                <input type="radio" name="aus_perm_res" value="no" checked data-target="aus_perm_res-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                No
                            </label>
                            <button data-placement="bottom" title="Family and given names"
                                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                                    type="button"></button>
                        </div>
                        <div class="aus_perm_res-no">
                            <label>The sponsor must be an Australian citizen, Australian permanent resident or an eligible New Zealand citizen to sponsor the applicant for this visa. The applicant may wish to review the information on the department's website regarding partner sponsorship eligibility prior to continuing with this application.</label>
                        </div>
                        <div class="aus_perm_res-no sr-only">
                            <div class="form-group">
                                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Was this sponsor in Australia at the time of grant?</label>
                                <label class="radio-inline" for="sptimeofgrant">
                                    <input type="radio" name="sptimeofgrant" value="yes" data-target="sptimeofgrant-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    Yes
                                </label>
                                <label class="radio-inline" for="sptimeofgrant">
                                    <input type="radio" name="sptimeofgrant" value="no" checked data-target="sptimeofgrant-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    No
                                </label>
                                <button data-placement="bottom" title="Family and given names"
                                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                                        type="button"></button>
                            </div>
                        </div>
                    </div>
                

            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4 citizenbygrant-no sptimeofgrant-no">Date of grant</label>
                <label class="text-left control-label col-md-4 citizenbygrant-no sptimeofgrant-no sr-only">Date of arrival</label>
                <div class="col-md-4">
                    <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
                </div>
            </div>
            <div class="form-group">
                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Was this sponsor in Australia at the time of grant?</label>
                <label class="radio-inline" for="obtain_aus_pr">
                    <input type="radio" name="obtain_aus_pr" value="yes" data-target="obtain_aus_pr-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="obtain_aus_pr">
                    <input type="radio" name="obtain_aus_pr" value="no" checked data-target="obtain_aus_pr-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
            <div class="obtain_aus_pr-no sr-only">
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-4">Visa program</label>
                    <div class="col-md-4">
                        <select class="form-control">
                            <option value="demo_value">demo value</option>
                        </select>
                    </div>
                </div>
            </div>
        </div>
        <!--#endregion Australian citizenship -->
        <!-- #region Other passports -->
        <div class="form-group row">
            <h3>
                Other passports
            </h3>
            <div class="form-group">
                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Does this sponsor have other current passports?</label>
                <label class="radio-inline" for="otherpassports">
                    <input type="radio" name="otherpassports" value="yes" checked data-target="otherpassports-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="otherpassports">
                    <input type="radio" name="otherpassports" value="no" data-target="otherpassports-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="otherpassports-yes col-xs-12">
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

        </div>
        <!-- #endregion Other passports -->
        <!-- #region National identity documents -->
        <div class="form-group row">
            <h3>
                National identity documents
            </h3>
            <div class="form-group">
                <label class="text-left control-label radio-inline col-xs-12 col-md-4">Does this sponsor have national identity documents?</label>
                <label class="radio-inline" for="nid">
                    <input type="radio" name="nid" value="yes" checked data-target="nid-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="nid">
                    <input type="radio" name="nid" value="no" data-target="nid-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="nid-yes col-xs-12">
                <table class="form-group">
                    <thead>
                        <tr>
                            <th>Family name</th>
                            <th>Given names</th>
                            <th>Type of document</th>
                            <th>Country of issue</th>
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
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addnid" data-title="Add National identity documents">Add</a><br />
                </div>
            </div>
        </div>
        <!-- #endregion National identity documents -->
        <!--#region Contributory parent category visa-->
        <div class="form-group">
            <h3>Contributory parent category visa</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has this sponsor ever been granted a contributory parent category visa?</label>
            <label class="radio-inline" for="contpcatvisa">
                <input type="radio" name="contpcatvisa" value="yes"  data-target="contpcatvisa-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="contpcatvisa">
                <input type="radio" name="contpcatvisa" value="no" checked data-target="contpcatvisa-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="contpcatvisa-yes sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Date of grant</label>
                <div class="col-md-4">
                    <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
                </div>
                <label class="text-left">Partner visa sponsors may be subject to sponsorship limitations if they were granted a contributory parent category visa in the last 5 years. The applicant may wish to review the information on the department's website regarding partner sponsorship eligibility prior to continuing with this application.</label>
            </div>
        </div>
        <!--#endregion Contributory parent category visa-->
        <!--#region Woman at Risk visa holders-->
        <div class="form-group">
            <h3>Contributory parent category visa</h3>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has this sponsor ever held a Woman at Risk (204) visa?</label>
            <label class="radio-inline" for="womenriskisa">
                <input type="radio" name="womenriskisa" value="yes" data-target="womenriskisa-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="womenriskisa">
                <input type="radio" name="womenriskisa" value="no" checked data-target="womenriskisa-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="womenriskisa-yes sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-4">Date of grant</label>
                <div class="col-md-4">
                    <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
                </div>
                <label class="text-left">Partner visa sponsors may be subject to sponsorship limitations if they hold a Woman at Risk (204) visa (for less than 5 years). The applicant may wish to review the information on the department's website regarding partner sponsorship eligibility prior to continuing with this application.</label>
            </div>
        </div>
        <!--#endregion Woman at Risk visa holders-->
    </div>
</form>
