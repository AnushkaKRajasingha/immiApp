@Code
    ViewData("Title") = "step3"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Primary applicant"
End Code
<form class="form-horizontal" role="form">
    <div>        
        <p class="text-info form-group">
            nformation: Entering names incorrectly may result in denial of permission to board an aircraft to Australia, or result in delays in border processing on arrival in Australia, even if the applicant has been granted a visa.
        </p>  
        <!-- #region Passport details -->      
        <div class="form-group row">
            <h3 class="col-md-3">Passport details
                <button data-placement="bottom" title="Passport details"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="ppd1_title"
                        type="button"></button>
            </h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Family name</label>
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
            <label class="text-left control-label col-md-3">Given names</label>
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
            <label class="text-left control-label col-md-3 ">Sex</label>
            <div class="col-md-6">
                <label class="radio-inline">
                <input type="radio" class="radio" value="male"  name="rdbSex"/>
                Male</label>
                <label class="radio-inline">
                    <input type="radio" class="radio" value="female" name="rdbSex"/>
                    Female
                </label>
                <label class="radio-inline">
                    <input type="radio" class="radio" value="other" name="rdbSex"/>
                    Other
                </label>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Date of Birth</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Passport number</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="1234567890" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Country of passport</label>
            <div class="col-md-4">
                <select class="form-control input-sm">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Nationality of passport holder</label>
            <div class="col-md-4">
                <select class="form-control input-sm">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Date of issue</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Date of expiry</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Place of issue / issuing authority</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Place of issue" />
            </div>
            
        </div>
        <p class="text-info form-group">It is strongly recommended that the passport be valid for at least six months</p>
        <!-- #endregion  Passport details --> 
        <!-- #region Place of birth -->
        <div class="form-group row">
            <h3 class="col-md-3">
                Place of birth
                <button data-placement="top" title="Place of birth"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="pob1_title" 
                        type="button"></button>
            </h3>            
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Town / City</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Town / City" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">State / Province</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="State / Province" />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Country of birth</label>
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
                Relationship status</h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Relationship status</label>
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
            <label class="text-left control-label col-md-3">Date of marriage</label>
            <div class="col-md-4">
                <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
            </div>
        </div>
        <!-- #endregion Relationship status -->
        <!-- #region Other names / spellings -->
        <div class="form-group row">
            <h3 class="col-md-3">
                Other names / spellings
            </h3>
            <div class="form-group">
                <label class="control-label radio-inline col-xs-12 col-md-6">Is this applicant currently, or have they ever been known by any other names?</label>
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
                <table class="form-group" >
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
            <label class="control-label radio-inline col-xs-12 col-md-6">Is this applicant a citizen of the country of passport?</label>
            <label class="radio-inline" for="citizen1">
                <input type="radio" name="citizen1" value="yes" checked  />
                Yes
            </label>
            <label class="radio-inline" for="citizen1">
                <input type="radio" name="citizen1" value="no"   />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="control-label radio-inline col-xs-12 col-md-6">Is this applicant currently, or have they ever been known by any other names?</label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input type="radio" name="citizen1_othercounty" value="yes" checked data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input type="radio" name="citizen1_othercounty" value="no" data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="citizen1_othercounty-yes sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">List countries</label>
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
        <!-- #region Other passports -->
        <div class="form-group row">
            <h3>
                Other passports
            </h3>
            <div class="form-group">
                <label class="control-label radio-inline col-xs-12 col-md-6">Does this applicant have other current passports?</label>
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
                <label class="control-label radio-inline col-xs-12 col-md-6">Does this applicant have national identity documents?</label>
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
        <!-- #region Health examination -->
        <div class="form-group row">
            <h3>
                Health examination
            </h3>
            <div class="form-group">
                <label class="control-label radio-inline col-xs-12 col-md-6">Has this applicant undertaken a health examination for an Australian visa in the last 12 months?</label>
                <label class="radio-inline" for="helthexam">
                    <input type="radio" name="helthexam" value="yes" checked data-target="helthexam-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="nid">
                    <input type="radio" name="helthexam" value="no" data-target="helthexam-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="helthexam-yes col-xs-12">
                <div class=" form-group col-xs-12">
                    <label class="text-left control-label col-md-3" for="helthexam-det">Give details</label>
                    <textarea name="helthexam-det" class="form-control col-md-4"></textarea>
                </div>
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-3">HAP ID (If available)</label>
                    <div class="col-md-4">
                        <input type="text" class="form-control input-sm" placeholder="HAP ID (If available)" />
                    </div>
                    <div class="col-md-2">
                        <button data-placement="bottom" title="HAP ID"
                                data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_heltext_hapid"
                                type="button"></button>
                    </div>
                </div>
            </div>
        </div>
        <!-- #endregion Health examination -->
    </div>
</form>


