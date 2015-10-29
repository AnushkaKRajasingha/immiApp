@Code
    ViewData("Title") = "step8"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Authorised recipient"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <p>This authorises the department to send the authorised person all written correspondence that would otherwise be sent directly to the applicant.</p>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline">Does the applicant authorise another person to receive written correspondence on their behalf? <br /></label>
            <label class="radio-inline" for="auth_recipient">
                <input type="radio" name="auth_recipient" value="no" checked data-target="auth_recipient-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <label class="radio-inline" for="auth_recipient">
                <input type="radio" name="auth_recipient" value="yes" data-target="auth_recipient-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes, a migration agent
            </label>
            <label class="radio-inline" for="auth_recipient">
                <input type="radio" name="auth_recipient" value="yes2" data-target="auth_recipient-yes2" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes, another person
            </label>
        </div>
        <div class="form-group">
            <p>This person is referred to as the 'authorised recipient'.</p>
        </div>
        
        <!-- #region Migration agent contact details -->
        <div class="auth_recipient-yes sr-only">
            <div class="form-group">
                <h3>Migration agent</h3>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">MARN</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="MARN" />
                </div>
                <div class="col-md-2">
                    <button data-placement="bottom" title="Family and given names"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                            type="button"></button>
                </div>
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
                <label class="text-left control-label col-md-3">Organisation</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="Organisation Name" />
                </div>
                <div class="col-md-2">
                    <button data-placement="bottom" title="Family and given names"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                            type="button"></button>
                </div>
            </div>
            <!-- #region Postal Address -->
            <div class="form-group">
                <h3>Postal address</h3>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Country</label>
                <div class="col-md-4">
                    <select class="form-control">
                        <option value="demo_value">demo value</option>
                    </select>
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Address</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="street 1" />
                </div>
                <div class="col-md-2">
                    <button data-placement="bottom" title="Family and given names"
                            data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                            type="button"></button>
                </div>
            </div>
            <div class="form-group col-xs-12">
                <div class="col-md-offset-3 col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="street 2" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Suburb / Town</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="Suburb / Town" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">State or Province</label>
                <div class="col-md-4">
                    <input type="text" class="form-control input-sm" placeholder="State or Province" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Postal code</label>
                <div class="col-md-3">
                    <input type="text" class="form-control input-sm" placeholder="00000" />
                </div>
            </div>
            <!-- #region Postal Address -->
            <!-- #region Contact telephone numbers-->
            <div class="form-group">
                <h3 class="col-md-3">Contact telephone numbers</h3><button data-placement="bottom" title="Family and given names"
                                                                           data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                                                                           type="button"></button>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Home phone</label>
                <div class="col-md-3">
                    <input type="text" class="form-control input-sm" placeholder="+00-000-000-0000" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Business phone</label>
                <div class="col-md-3">
                    <input type="text" class="form-control input-sm" placeholder="+00-000-000-0000" />
                </div>
            </div>
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Mobile / Cell phone</label>
                <div class="col-md-3">
                    <input type="text" class="form-control input-sm" placeholder="+00-000-000-0000" />
                </div>
            </div>
            <!-- #endregion Contact telephone numbers-->
            <!-- #region Electronic communication-->
            <div class="form-group">
                <h3>Electronic communication</h3>
                <label>We can communicate about this application more quickly using email and/or fax.</label>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline col-md-6"> Does the authorised recipient agree to this department communicating via email and/or fax? This may include receiving notification of the outcome of the application.</label>
                <label class="radio-inline" for="elect_communi">
                    <input type="radio" name="elect_communi" value="yes" checked data-target="insameaddress-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="elect_communi">
                    <input type="radio" name="elect_communi" value="no" data-target="insameaddress-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="insameaddress-yes">
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-3">Email Address</label>
                    <div class="col-md-4">
                        <input type="email" class="form-control input-sm" placeholder="youremail@doainname.com" />
                    </div>
                </div>
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-3">Fax Number</label>
                    <div class="col-md-3">
                        <input type="text" class="form-control input-sm" placeholder="+00-000-000-0000" />
                    </div>
                </div>
            </div>
            <div class="form-group">
                <h3>Authorisation of health and character information</h3>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline col-md-6"> Do all applicants agree that information regarding their health and character may be sent to the authorised person? This may include requests for, or results of, medical examinations and the results of criminal history checks.</label>
                <label class="radio-inline" for="ahci">
                    <input type="radio" name="ahci" value="yes" checked data-target="ahci-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="ahci">
                    <input type="radio" name="ahci" value="no" data-target="ahci-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="ahci-no sr-only">
                <label>Note that health and character information will be sent directly to the applicant at the residential address provided if 'No' is selected.</label>
            </div>
            <!-- #endregion Electronic communication -->
        </div>
        <!-- #endregion Migration agent contact details -->

    </div>
</form>

