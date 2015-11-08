@ModelType immiApp.ApplicationModels
@Code
    ViewData("StepTitle") = "Application context"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
End Code

    <div class="form-horizontal">
        <div>
            <div class="form-group">
                <h3>Current location</h3>
            </div>
            <!-- #region currently_outside_Australia -->
            <div class="form-group">
                <label class="control-label radio-inline col-md-5 text-left">Is the applicant currently outside Australia?</label>
                <label class="radio-inline" for="cosa">
                    <input id="_2a0b0a0a0a4a0a0b0b1b1aidm196384040" name="_2a0b0a0a0a4a0a0b0b1b1a" type="radio"  value="1"                               
                                @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 1)), "checked", ""))                                
                                        Data-target = "cosa-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <Label Class="radio-inline" for="cosa">
                    <input id = "_2a0b0a0a0a4a0a0b0b1b1aidm196384256" name="_2a0b0a0a0a4a0a0b0b1b1a" type="radio" value="2" data-target="cosa-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" 
                            @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 2)), "checked", (If(Model Is Nothing, "checked", ""))))
                           />
                    No
                </label>

            </div>
            <div Class="cosa-no @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 1)), "", "sr-only"))">
                <div Class="form-group col-xs-12">
                    <span> Give the current location Of the applicant And their legal status at this location.</span>
                </div>
                    <div Class="form-group col-xs-12">
                        <Label Class="control-label col-md-5 text-left">Current location</label>
                        <div Class="col-md-6">
                            @Html.Partial("~/Views/Shared/CustomControls/custctrlCountries.vbhtml", New CustomCtrlCountry() With {.ClassName = "_2a0b0a0a0a4a0a0b0b3c0b0", .Id = "_2a0b0a0a0a4a0a0b0b3c0b0", .DefaultValue = (If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing), Model.CurrentLocation.Location, 1))})
                        </div>                       
                    </div>
                    <div class="form-group col-xs-12">
                        <label class="control-label col-md-5 text-left">Legal status</label>
                        <div Class="col-md-6">
                            @Html.Partial("~/Views/Shared/CustomControls/custctrlLeagaStatus.vbhtml", New CustomCtrlLeagalStatus() With {.ClassName = "clsLeagalStatus _2a0b0a0a0a4a0a0b0b3d0b0", .Id = "_2a0b0a0a0a4a0a0b0b3d0b0", .DefaultValue = If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing), Model.CurrentLocation.LeagalStatus, 1)})
                        </div>
                    </div>
                    <div class="form-group col-xs-12 clsLeagalStatus-opt @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.LeagalStatus = 1 Or Model.CurrentLocation.LeagalStatus = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))" >
                        <p class="text-left control-label col-xs-12">Give details of why the applicant is at their current location, including the end date of their current visa.</p>
                        <div class="col-md-offset-2 col-md-6">
                            <textarea class="form-control input-sm" id="_2a0b0a0a0a4a0a0b0b3f1b0" name="_2a0b0a0a0a4a0a0b0b3f1b0" title="Give details of why the applicant is at their current location, including the end date of their current visa." data-maxlength="300" cols="70" rows="5">@(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing), Model.CurrentLocation.Reason, ""))</textarea>
                        </div>
                    </div>
            </div>
            <!-- #endregion currently_outside_Australia -->
            <div class="form-group cosa-no @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 1)), (If(Model Is Nothing, "", "sr-only")), ""))">
                <h3>Substantive visa</h3>           
                <label class="control-label radio-inline col-md-5 text-left">Is the applicant currently holding a substantive visa?</label>
                <label class="radio-inline" for="suvi">
                    <input type="radio" id="_2a0b0a0a0a4a0a0b0c1b1a0idm196301672" name="_2a0b0a0a0a4a0a0b0c1b1a0" value="1" 
                            @(If(Not Model Is Nothing AndAlso (Not Model.SubstantiveVisa Is Nothing And (Model.SubstantiveVisa.IsCurrentlyHolding = 1)), "checked", (If(Model Is Nothing, "checked", ""))))                                
                            data-target="suvi-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="suvi">
                    <input type="radio" id="_2a0b0a0a0a4a0a0b0c1b1a0idm196271144" name="_2a0b0a0a0a4a0a0b0c1b1a0" value="2" 
                           @(If(Not Model Is Nothing AndAlso (Not Model.SubstantiveVisa Is Nothing And (Model.SubstantiveVisa.IsCurrentlyHolding = 2)), "checked", ""))
                           data-target="suvi-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>                
                <div class=" form-group suvi-no  
                     @(If(Not Model Is Nothing AndAlso (Not Model.SubstantiveVisa Is Nothing And (Model.SubstantiveVisa.IsCurrentlyHolding = 1)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))
                     col-xs-12">
                    <hr />
                    <label class="control-label text-left">Applicants who have not held a substantive visa in the last 28 days will need to demonstrate compelling reasons exist for the grant of their partner visa. The applicant should ensure they are aware of their visa status before continuing with this application.</label>
                    <textarea class="form-control input-sm" id="_2a0b0a0a0a4a0a0b0c5b1a" name="_2a0b0a0a0a4a0a0b0c5b1a">@(If(Not Model Is Nothing AndAlso (Not Model.SubstantiveVisa Is Nothing), Model.SubstantiveVisa.CompellingReasons, ""))</textarea>
                </div>
            </div>
            <div class="form-group">
                <h3>Current application</h3>
            </div>
            <div class="form-group cosa-no  @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 1)), (If(Model Is Nothing, "", "sr-only")), ""))">
                <label class="control-label radio-inline col-md-5 text-left">Did the applicant arrive in Australia on a Prospective Marriage visa?</label>
                <label class="radio-inline" for="cuap1">
                    <input type="radio"  id="_2a0b0a0a0a4a0a0b0d2b1a0idm213345520" name="_2a0b0a0a0a4a0a0b0d2b1a0" value="1"  
                            @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsArriveinAusOn = 1)), "checked", ""))
                           data-target="cuap1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);"  />
                    Yes
                </label>
                <label class="radio-inline" for="cuap1">
                    <input type="radio" id="_2a0b0a0a0a4a0a0b0d2b1a0idm222851624" name="_2a0b0a0a0a4a0a0b0d2b1a0" value="2"
                            @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsArriveinAusOn = 2)), "checked", (If(Model Is Nothing, "checked", ""))))
                            data-target="cuap1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);"/>
                    No
                </label>
                <div class="cuap1-yes  @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsArriveinAusOn = 2)), "sr-only", (If(Model Is Nothing, "sr-only", "")))) col-xs-12">
                    <div class="form-group">
                        <h3>Related application</h3>
                        <p>Give details of the related application</p>
                    </div>
                    <div class="form-group col-xs-12">
                        <label class="control-label col-md-5 text-left">Reference number type</label>
                        <div class="col-md-6">
                            <select class="form-control input-sm col-md-6 _2a0b0a0a0a4a0a0b0e3a1a" id="_2a0b0a0a0a4a0a0b0e3a1a" name="_2a0b0a0a0a4a0a0b0e3a1a" title="Reference number" data-toggleclsprefix="refnumber" data-toggleclass="sr-only" onchange="toggelElementBySelectOption(this);">
                                <option value="1"
                                        @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 1)), "selected", ""))
                                        data-null="1" ></option>
                                <option value="2"
                                        @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 2)), "selected", ""))
                                        >
                                    Transaction
                                    reference number
                                    (TRN)
                                </option>
                                <option value="3"
                                         @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 3)), "selected", ""))
                                        >
                                    Visa grant
                                    number
                                </option>
                                <option value="4"
                                         @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 4)), "selected", ""))
                                        >
                                    Application ID
                                </option>
                            </select>
                        </div>
                    </div>
                    <div class="form-group col-xs-12 refnumber_1 
                          @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 1)), "", "sr-only"))
                         "></div>
                    <div class="form-group col-xs-12 refnumber_2 
                         @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 2)), "", "sr-only"))
                         ">
                        <label class="control-label col-md-5 text-left">Transaction Reference Number (TRN)</label>
                        <div class="col-md-4"><input type="text" 
                            value="@(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing), Model.ProspectiveMarriageVisa.TransRefNumber, ""))" 
                            id="_2a0b0a0a0a4a0a0b0e4a1a" name="_2a0b0a0a0a4a0a0b0e4a1a" title="Transaction Reference Number (TRN)" maxlength="10" size="10" class="form-control input-sm"></div> 
                    </div>
                    <div class="form-group col-xs-12 refnumber_3 
                         @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 3)), "", "sr-only"))
                         ">
                        <label class="control-label col-md-5 text-left">Australian visa grant number</label>
                        <div class="col-md-4">
                            <input type="text" 
                            value="@(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing), Model.ProspectiveMarriageVisa.AusVisaLblNumber, ""))" 
                            id="_2a0b0a0a0a4a0a0b0e6a1a" name="_2a0b0a0a0a4a0a0b0e6a1a" title="Australian visa grant number" maxlength="13" size="50" class="form-control input-sm">
                        </div> 
                    </div>
                <div class="form-group col-xs-12 refnumber_4 
                     @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.RefNumberType = 4)), "", "sr-only"))
                     ">
                    <label class="control-label col-md-5 text-left">Application ID</label>
                    <div class="col-md-4">
                        <input type="text" 
                               value="@(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing), Model.ProspectiveMarriageVisa.ApplicationId, ""))" 
                               id="_2a0b0a0a0a4a0a0b0e7a1a" name="_2a0b0a0a0a4a0a0b0e7a1a" title="Application ID" maxlength="11" size="20" class="form-control input-sm">
                    </div> 
                    </div>
                </div> 
                <!-- #region Additional relationship details -->
                <div class="cuap1-yes @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsArriveinAusOn = 2)), "sr-only", (If(Model Is Nothing, "sr-only", "")))) col-xs-12">
                    <div class="form-group">
                        <h3>Additional relationship details</h3>
                    </div>
                    <div class="form-group">
                        <label class="control-label radio-inline col-xs-12 col-md-7 text-left">Is the sponsor listed on this application the same as the sponsor for the Prospective Marriage visa?</label>
                        <label class="radio-inline" for="addrel">
                            <input type="radio" id="_2a0b0a0a0a4a0a0b0f1b1a0idm211712320" name="_2a0b0a0a0a4a0a0b0f1b1a0" value="1" 
                                   @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.SameAsTheSponsor = 1))), "checked", (If(Model Is Nothing, "checked", ""))))
                                   data-target="addrel-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            Yes
                        </label>
                        <label class="radio-inline" for="addrel">
                            <input type="radio" id="_2a0b0a0a0a4a0a0b0f1b1a0idm211712104" name="_2a0b0a0a0a4a0a0b0f1b1a0" value="2" 
                                    @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.SameAsTheSponsor = 2))), "checked", ""))
                                           Data-target = "addrel-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                            No
                        </label>
                    </div>
                    <div Class="addrel-yes col-xs-12 @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing And (Model.ProspectiveMarriageVisa.Relationship.SameAsTheSponsor = 1))), "", (If(Model Is Nothing, "", "sr-only"))))">
                        <div class="form-group">
                            <label class="control-label radio-inline col-xs-12 col-md-7 text-left">Did the applicant marry the sponsor before the Prospective Marriage visa ceased?</label>
                            <label class="radio-inline" for="addre2">
                                <input type="radio"  id="_2a0b0a0a0a4a0a0b0f2b1a0idm211708144" name="_2a0b0a0a0a4a0a0b0f2b1a0" value="1" 
                                       @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.MarriedSB4VisaCeased = 1))), "checked", ""))
                                       data-target="addre2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                Yes
                            </label>
                            <label class="radio-inline" for="addre2">
                                <input type="radio" id="_2a0b0a0a0a4a0a0b0f2b1a0idm211707928" name="_2a0b0a0a0a4a0a0b0f2b1a0" value="2"
                                       @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.MarriedSB4VisaCeased = 2))), "checked", (If(Model Is Nothing, "checked", ""))))
                                        data-target="addre2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                No
                            </label>
                        </div>
                        <div class="addre2-yes  
                             @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.MarriedSB4VisaCeased = 2))), "sr-only", (If(Model Is Nothing, "sr-only", ""))))
                             col-xs-12">
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-7 text-left">Did the applicant marry the sponsor after the applicant's first arrival in Australia as the holder of a Prospective Marriage visa?</label>
                                <label class="radio-inline" for="addre3">
                                    <input type="radio" id="_2a0b0a0a0a4a0a0b0f3b1a0idm211703968" name="_2a0b0a0a0a4a0a0b0f3b1a0" value="1" 
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.MarriedAfter1StArrinAus = 1))), "checked", (If(Model Is Nothing, "checked", ""))))
                                             />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre3">
                                    <input type="radio" id="_2a0b0a0a0a4a0a0b0f3b1a0idm211703752" name="_2a0b0a0a0a4a0a0b0f3b1a0" value="2"  
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.MarriedAfter1StArrinAus = 2))), "checked", ""))
                                           />
                                    No
                                </label>
                            </div>
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-7 text-left">Has the applicant's Prospective Marriage visa ceased?</label>
                                <label class="radio-inline" for="addre4">
                                    <input id="_2a0b0a0a0a4a0a0b0f4b1a0idm212490976" name="_2a0b0a0a0a4a0a0b0f4b1a0" type="radio" value="1" 
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Model.ProspectiveMarriageVisa.HasCeased = 1)), "checked", (If(Model Is Nothing, "checked", ""))))
                                             />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre4">
                                    <input id="_2a0b0a0a0a4a0a0b0f4b1a0idm212490760" name="_2a0b0a0a0a4a0a0b0f4b1a0" type="radio" value="2" 
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Model.ProspectiveMarriageVisa.HasCeased = 2)), "checked", ""))
                                           />
                                    No
                                </label>
                            </div>
                            <div class="form-group">
                                <label class="control-label radio-inline col-xs-12 col-md-7 text-left ">Is the applicant still in a relationship with the sponsor?</label>
                                <label class="radio-inline" for="addre5">
                                    <input id="_2a0b0a0a0a4a0a0b0f5b1a0idm212486512" name="_2a0b0a0a0a4a0a0b0f5b1a0" type="radio" value="1" 
                                            @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.StillInRelationship = 1))), "checked", (If(Model Is Nothing, "checked", ""))))
                                            data-target="addre5-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    Yes
                                </label>
                                <label class="radio-inline" for="addre5">
                                    <input id="_2a0b0a0a0a4a0a0b0f5b1a0idm212486296" name="_2a0b0a0a0a4a0a0b0f5b1a0" type="radio" value="2" 
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.StillInRelationship = 2))), "checked", ""))
                                           data-target="addre5-no" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                                    No
                                </label>
                            </div>
                            <div class="addre5-no 
                                 @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.StillInRelationship = 1))), "sr-only", (If(Model Is Nothing, "sr-only", ""))))
                                 col-xs-12">
                                <div class="form-group">
                                    <label class="control-label col-md-3 text-left">Date relationship ended</label>
                                    <div class="col-md-9">
                                        @Code
                                            Dim _default_2a0b0a0a0a4a0a0b0f6a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                                            If (Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing))) Then
                                                _default_2a0b0a0a0a4a0a0b0f6a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.ProspectiveMarriageVisa.Relationship.EndDate.Day, .month = Model.ProspectiveMarriageVisa.Relationship.EndDate.Month, .year = Model.ProspectiveMarriageVisa.Relationship.EndDate.Year}
                                            End If
                                        End Code
                                        @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0b0f6a1a", .Id = "_2a0b0a0a0a4a0a0b0f6a1a", .DefaultValue = _default_2a0b0a0a0a4a0a0b0f6a1a})
                                        <p class="panel-info">In the following circumstances the applicant may still be able to continue with this application. Select any that apply.</p>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label checkbox-inline">
                                    <input type="checkbox" id="_2a0b0a0a0a4a0a0b0f8a1a" name="_2a0b0a0a0a4a0a0b0f8a1a" title="Applicant suffered family violence by the sponsor" 
                                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.ViolenceBySpon = "True"))), "Checked", ""))
                                           value="@(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.ViolenceBySpon = "True"))), "True", "False"))"
                                           onchange="checkboxvaluesetter(this);"
                                           />Applicant suffered family violence by the sponsor</label>
                                </div>
                                <div class="form-group">
                                    <label class="control-label checkbox-inline"><input type="checkbox" id="_2a0b0a0a0a4a0a0b0f9a1a" name="_2a0b0a0a0a4a0a0b0f9a1a" title="Sponsor is deceased"
                                                                                         @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.SponIsDeceased = "True"))), "Checked", ""))
                                           value="@(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa.Relationship Is Nothing AndAlso (Model.ProspectiveMarriageVisa.Relationship.SponIsDeceased = "True"))), "True", "False"))"
                                                                                        onchange="checkboxvaluesetter(this);"
                                                                                        />Sponsor is deceased</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- #endregion Additional relationship details -->
            </div>
            <div class="form-group cosa-no @(If(Not Model Is Nothing AndAlso (Not Model.CurrentLocation Is Nothing And (Model.CurrentLocation.OutSideAus = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))">
                <label class="control-label radio-inline col-md-5 text-left">Is the applicant applying for a Prospective Marriage visa? </label>
                <label class="radio-inline" for="cuap2">
                    <input type="radio" value="1" id="_2a0b0a0a0a4a0a0b0d1b1a0idm196255808" name="_2a0b0a0a0a4a0a0b0d1b1a0" 
                           @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsApplyingForaVisa = 1)), "checked", ""))                                
                           />
                    Yes
                </label>
                <label class="radio-inline" for="cuap2">
                    <input type="radio" value="2" id="_2a0b0a0a0a4a0a0b0d1b1a0idm196255232" name="_2a0b0a0a0a4a0a0b0d1b1a0"
                            @(If(Not Model Is Nothing AndAlso (Not Model.ProspectiveMarriageVisa Is Nothing And (Model.ProspectiveMarriageVisa.IsApplyingForaVisa = 2)), "checked", (If(Model Is Nothing, "checked", ""))))                                
                           />
                    No
                </label>
            </div>
        </div>
    </div>


