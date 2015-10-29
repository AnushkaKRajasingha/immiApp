@Code
    ViewData("Title") = "step6"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Contact details"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <h3>Country of residence</h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Usual country of residence</label>
            <div class="col-md-4">
                <select class="form-control">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
        </div>
        <div class="form-group">
            <h3>Department office</h3>
           <label>The applicant may be required to attend an Australian Government Office for an interview. Which is the closest office to the applicant’s current location?</label>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-3">Office</label>
            <div class="col-md-4">
                <select class="form-control">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
        </div>
        <!--#region Residential address -->
        <div class="form-group">
            <h3>Residential address</h3>
            <label>Note that a street address is required. A post office address cannot be accepted as a residential address.</label>
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
        <!--#endregion Residential address -->
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
        <!-- #region Postal address-->
        <div class="form-group">
            <h3>Postal address</h3>
        </div>
        <div class="form-group">
            <label class="control-label radio-inline">Is the postal address the same as the residential address?</label>
            <label class="radio-inline" for="insameaddress">
                <input type="radio" name="insameaddress" value="yes" checked data-target="insameaddress-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="insameaddress">
                <input type="radio" name="insameaddress" value="no" data-target="insameaddress-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="insameaddress-no sr-only">
            <div class="form-group col-xs-12">
                <label class="text-left control-label col-md-3">Country</label>
                <div class="col-md-3">
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
        </div>
        <!-- #endregion Postal address-->
        <!-- #region Electronic communication-->
        <div class="form-group">
            <h3>Electronic communication</h3>
            <label>We can communicate about this application more quickly using email and/or fax.</label>
        </div>
        <div class="form-group">
            <label class="control-label radio-inline">Is the postal address the same as the residential address?</label>
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
        <!-- #endregion Electronic communication -->

    </div>
</form>