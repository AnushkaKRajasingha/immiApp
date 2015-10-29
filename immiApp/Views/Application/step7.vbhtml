@Code
    ViewData("Title") = "step7"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Contact details for second stage permanent visa"
End Code
<form class="form-horizontal" role="form">
    <div>
        <!-- #region Postal address-->
        <div class="form-group">
            <h3>Postal address</h3>
        </div>
        
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
        
        <!-- #endregion Postal address-->
        <!-- #region Electronic communication-->
        <div class="form-group">
            <h3>Electronic communication</h3>
            <label>We can communicate about this application more quickly using email and/or fax.</label>
        </div>
        
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
        
        <!-- #endregion Electronic communication -->
    </div>
</form>
