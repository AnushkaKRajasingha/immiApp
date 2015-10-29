@Code
    ViewData("StepTitle") = "Application context"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
End Code

    <form class="form-horizontal" role="form">
        <div>
            <div class="form-group">
                <h3>Current location</h3>
            </div>
            <div class="form-group">
                <label class="control-label radio-inline">Is the applicant currently outside Australia?</label>
                <label class="radio-inline" for="cosa">
                    <input type="radio" name="cosa" value="yes" checked data-target="cosa-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="cosa">
                    <input type="radio" name="cosa" value="no" data-target="cosa-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>

            </div>
            <div class="form-group cosa-no">
                <div class="form-group col-xs-12">
                    <span>Give the current location of the applicant and their legal status at this location.</span>
                </div>
                    <div class="form-group col-xs-12">
                        <label class="control-label col-md-2">Current location</label>
                        <div class="col-md-6">
                            <select class="form-control col-md-6">
                                <option value="demo_value">demo value</option>
                            </select>
                        </div>
                    </div>
                    <div class="form-group col-xs-12">
                        <label class="control-label col-md-2">Legal status</label>
                        <div class="col-md-6">
                            <select class="form-control">
                                <option value="demo_value">demo value</option>
                            </select>
                        </div>
                    </div>
                </div>
            <div class="form-group cosa-no sr-only">
                <h3>Substantive visa</h3>           
                <label class="control-label radio-inline">Is the applicant currently holding a substantive visa?</label>
                <label class="radio-inline" for="suvi">
                    <input type="radio" name="suvi" value="yes" checked data-target="suvi-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="suvi">
                    <input type="radio" name="suvi" value="no" data-target="suvi-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>                
                <div class=" form-group suvi-no sr-only col-xs-12">
                    <hr />
                    <label class="text-left control-label">Applicants who have not held a substantive visa in the last 28 days will need to demonstrate compelling reasons exist for the grant of their partner visa. The applicant should ensure they are aware of their visa status before continuing with this application.</label>
                    <textarea class="form-control"></textarea>
                </div>
            </div>
            <div class="form-group">
                <h3>Current application</h3>
            </div>
            <div class="form-group cosa-no sr-only">
                <label class="control-label radio-inline">Did the applicant arrive in Australia on a Prospective Marriage visa?</label>
                <label class="radio-inline" for="cuap1">
                    <input type="radio" name="cuap1" value="yes" checked data-target="cuap1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);"  />
                    Yes
                </label>
                <label class="radio-inline" for="cuap1">
                    <input type="radio" name="cuap1" value="no" checked data-target="cuap1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);"/>
                    No
                </label>
                <div class="cuap1-yes sr-only col-xs-12">
                    <div class="form-group">
                        <h3>Related application</h3>
                        <p>Give details of the related application</p>
                    </div>
                    <div class="form-group col-xs-12">
                        <label class="control-label col-md-2">Reference number type</label>
                        <div class="col-md-6">
                            <select class="form-control col-md-6">
                                <option value="demo_value">demo value</option>
                            </select>
                        </div>
                    </div>
                </div> 
                <div class="cuap1-yes sr-only col-xs-12">
                    <div class="form-group">
                        <h3>Additional relationship details</h3>
                    </div>
                    <div class="form-group">
                        <label class="control-label radio-inline col-xs-12 col-md-6">Is the sponsor listed on this application the same as the sponsor for the Prospective Marriage visa?</label>
                        <label class="radio-inline" for="addrel">
                            <input type="radio" name="addrel" value="yes" checked data-target="addrel-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            Yes
                        </label>
                        <label class="radio-inline" for="addrel">
                            <input type="radio" name="addrel" value="no" data-target="addrel-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            No
                        </label>
                    </div>
                    <div class="addrel-yes sr-only col-xs-12">
                        <div class="form-group">
                            <label class="control-label radio-inline col-xs-12 col-md-6">Did the applicant marry the sponsor before the Prospective Marriage visa ceased?</label>
                            <label class="radio-inline" for="addre2">
                                <input type="radio" name="addre2" value="yes" data-target="addre2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                Yes
                            </label>
                            <label class="radio-inline" for="addre2">
                                <input type="radio" name="addre2" value="no" checked data-target="addre2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                No
                            </label>
                        </div>
                        <div class="addre2-yes sr-only col-xs-12">
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-6">Did the applicant marry the sponsor after the applicant's first arrival in Australia as the holder of a Prospective Marriage visa?</label>
                                <label class="radio-inline" for="addre3">
                                    <input type="radio" name="addre3" value="yes" checked  />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre3">
                                    <input type="radio" name="addre3" value="no"  />
                                    No
                                </label>
                            </div>
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-6">Did the applicant marry the sponsor before the Prospective Marriage visa ceased?</label>
                                <label class="radio-inline" for="addre4">
                                    <input type="radio" name="addre4" value="yes" checked  />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre4">
                                    <input type="radio" name="addre4" value="no" />
                                    No
                                </label>
                            </div>
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-6">Has the applicant's Prospective Marriage visa ceased?</label>
                                <label class="radio-inline" for="addre5">
                                    <input type="radio" name="addre5" value="yes" checked data-target="addre5-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre5">
                                    <input type="radio" name="addre5" value="no" data-target="addre5-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    No
                                </label>
                            </div>
                            <div class="addre5-no sr-only col-xs-12">
                                <div class="form-group">
                                    <label class="control-label col-md-6">Date relationship ended</label>
                                    <div class="col-md-6">
                                        <input type="date" class="form-control" />
                                        <p>In the following circumstances the applicant may still be able to continue with this application. Select any that apply.</p>
                                    </div>                                    
                                </div>

                                <div class="form-group">
                                    <label class="control-label checkbox-inline"><input type="checkbox" />Applicant suffered family violence by the sponsor</label>
                                </div>
                                <div class="form-group">
                                    <label class="control-label checkbox-inline"><input type="checkbox" />Sponsor is deceased</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="form-group cosa-no">
                <label class="control-label radio-inline">Is the applicant applying for a Prospective Marriage visa?</label>
                <label class="radio-inline" for="cuap2">
                    <input type="radio" name="cuap2" value="yes" />
                    Yes
                </label>
                <label class="radio-inline" for="cuap2">
                    <input type="radio" name="cuap2" value="no" checked />
                    No
                </label>
            </div>
        </div>
    </form>


