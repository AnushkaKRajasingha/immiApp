@ModelType immiApp.ApplicationModels
@Code
    ViewData("Title") = "step3"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Primary applicant"
End Code
<div class="form-horizontal">
    <div>        
        <p class="text-info form-group">
            information: Entering names incorrectly may result in denial of permission to board an aircraft to Australia, or result in delays in border processing on arrival in Australia, even if the applicant has been granted a visa.
        </p>  
        <!-- #region Passport details -->      
        <div class="form-group row">
            <h3 class="col-md-3">Passport details</h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Family name </label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Family Name" id="_2a0b0a0a0a4a0a0c0g0a0b0a" name="_2a0b0a0a0a4a0a0c0g0a0b0a" title="Family name" maxlength="100" size="50"
                      value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing), Model.PrimaryApplicent.FamilyName, ""))" 
                        />                
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Given names</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Given Names" id="_2a0b0a0a0a4a0a0c0g0b0b0a" name="_2a0b0a0a0a4a0a0c0g0b0b0a" title="Given names" maxlength="100" size="50" 
                        value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing), Model.PrimaryApplicent.GivenName, ""))" 
                       />               
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5 ">Sex</label>
            <div class="col-md-6">
                <label class="radio-inline">
                <input class="radio" id="_2a0b0a0a0a4a0a0c0g1a1aidm209915992" name="_2a0b0a0a0a4a0a0c0g1a1a" type="radio" value="1"
                        @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Model.PrimaryApplicent.Sex = 1)), "checked", ""))
                       />
                Male</label>
                <label class="radio-inline">
                    <input  class="radio" id="_2a0b0a0a0a4a0a0c0g1a1aidm209915704" name="_2a0b0a0a0a4a0a0c0g1a1a" type="radio" value="2"
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Model.PrimaryApplicent.Sex = 2)), "checked", ""))
                           />
                    Female
                </label>
                <label class="radio-inline">
                    <input class="radio" id="_2a0b0a0a0a4a0a0c0g1a1aidm209915488" name="_2a0b0a0a0a4a0a0c0g1a1a" type="radio" value="3"
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Model.PrimaryApplicent.Sex = 3)), "checked", (If(Model Is Nothing, "checked", ""))))
                           />
                    Other
                </label>
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Date of Birth</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing)) Then
                        _defaultdate = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.Dateofbirth.Day, .month = Model.PrimaryApplicent.Dateofbirth.Month, .year = Model.PrimaryApplicent.Dateofbirth.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0g2a1a", .Id = "_2a0b0a0a0a4a0a0c0g2a1a", .DefaultValue = _defaultdate})
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Passport number</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Passport number" id="_2a0b0a0a0a4a0a0c0h0a1a" name="_2a0b0a0a0a4a0a0c0h0a1a" title="Passport number" maxlength="14" size="14" 
                        value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.Passport Is Nothing), Model.PrimaryApplicent.Passport.PassportNumber, ""))" 
                       />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Country of passport</label>
            <div class="col-md-4">
                @Html.Partial("~/Views/Shared/CustomControls/custctrlPassportCountry.vbhtml", New CustomCtrlPassportCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0h1a1a", .Id = "_2a0b0a0a0a4a0a0c0h1a1a", .DefaultValue = (If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.Passport Is Nothing), Model.PrimaryApplicent.Passport.Country, 1))})
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Nationality of passport holder</label>
            <div class="col-md-4">
                @Html.Partial("~/Views/Shared/CustomControls/custctrlPassportCountry.vbhtml", New CustomCtrlPassportCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0h2a1a", .Id = "_2a0b0a0a0a4a0a0c0h2a1a", .DefaultValue = (If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.Passport Is Nothing), Model.PrimaryApplicent.Passport.Nationality, 1))})
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Date of issue</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate_2a0b0a0a0a4a0a0c0h3a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Not Model.PrimaryApplicent.Passport Is Nothing))) Then
                        _defaultdate_2a0b0a0a0a4a0a0c0h3a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.Passport.DateofIssue.Day, .month = Model.PrimaryApplicent.Passport.DateofIssue.Month, .year = Model.PrimaryApplicent.Passport.DateofIssue.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0h3a1a", .Id = "_2a0b0a0a0a4a0a0c0h3a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0h3a1a})
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Date of expiry</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate_2a0b0a0a0a4a0a0c0h4a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing)) Then
                        _defaultdate_2a0b0a0a0a4a0a0c0h4a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.Passport.DateofExpiry.Day, .month = Model.PrimaryApplicent.Passport.DateofExpiry.Month, .year = Model.PrimaryApplicent.Passport.DateofExpiry.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0h4a1a", .Id = "_2a0b0a0a0a4a0a0c0h4a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0h4a1a})
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Place of issue / issuing authority</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Place of issue" id="_2a0b0a0a0a4a0a0c0h5a1a" name="_2a0b0a0a0a4a0a0c0h5a1a" title="Place of issue / issuing authority" maxlength="60" size="50" 
                       value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.Passport Is Nothing), Model.PrimaryApplicent.Passport.PlaceofIssue, ""))" 
                       />
            </div>
            
        </div>
        <p class="text-info form-group">It is strongly recommended that the passport be valid for at least six months</p>
        <!-- #endregion  Passport details --> 
        <!-- #region Place of birth -->
        <div class="form-group row">
            <h3 class="col-md-3">Place of birth</h3>            
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Town / City</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="Town / City" id="_2a0b0a0a0a4a0a0c0j1a1a" name="_2a0b0a0a0a4a0a0c0j1a1a" title="Town / City" maxlength="50" size="50"
                       value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.PlaceofBirth Is Nothing), Model.PrimaryApplicent.PlaceofBirth.TownCity, ""))" 
                        />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">State / Province</label>
            <div class="col-md-4">
                <input type="text" class="form-control input-sm" placeholder="State / Province" id="_2a0b0a0a0a4a0a0c0j2a1a" name="_2a0b0a0a0a4a0a0c0j2a1a" title="State / Province" maxlength="50" size="50"
                        value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.PlaceofBirth Is Nothing), Model.PrimaryApplicent.PlaceofBirth.StateProvince, ""))" 
                       />
            </div>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Country of birth</label>
            <div class="col-md-4">
                @Html.Partial("~/Views/Shared/CustomControls/custctrlCountries.vbhtml", New CustomCtrlCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0j3a1a0", .Id = "_2a0b0a0a0a4a0a0c0j3a1a0", .DefaultValue = (If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.PlaceofBirth Is Nothing), Model.PrimaryApplicent.PlaceofBirth.Country, 1))})
            </div>            
        </div>
        <!-- #endregion Place of birth -->
        <!-- #region Relationship status -->
        <div class="form-group row">
            <h3 class="col-md-3">
                Relationship status</h3>
        </div>
        <div class="form-group col-xs-12">
            <label class="text-left control-label col-md-5">Relationship status</label>
            <div class="col-md-4">

                 @Html.Partial("~/Views/Shared/CustomControls/custctrlRelationshipStatus.vbhtml", New CustomCtrlRelationshipStatus() With {.ClassName = "_2a0b0a0a0a4a0a0c0bb1a1a0", .Id = "_2a0b0a0a0a4a0a0c0bb1a1a0", .DefaultValue = (If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.RelationsipStatus Is Nothing), Model.PrimaryApplicent.RelationsipStatus.RelationshipStatus, 1)), .DataToggleClass = "sr-only", .DataTogglePrefix = "_2a0b0a0a0a4a0a0c0bb1a1a0"})
            </div>
        </div>
        <div class="form-group _2a0b0a0a0a4a0a0c0bb1a1a0_1 
             @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.RelationsipStatus Is Nothing And (Model.PrimaryApplicent.RelationsipStatus.RelationshipStatus = 1)), "", "sr-only"))
             "></div>
        <div class="form-group _2a0b0a0a0a4a0a0c0bb1a1a0_2 
             @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.RelationsipStatus Is Nothing And (Model.PrimaryApplicent.RelationsipStatus.RelationshipStatus = 2)), "", "sr-only"))
             ">
            <label class="text-left control-label col-md-5">Date of marriage</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate_2a0b0a0a0a4a0a0c0ba2a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing)) Then
                        _defaultdate_2a0b0a0a0a4a0a0c0ba2a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.RelationsipStatus.DateofMarriage.Day, .month = Model.PrimaryApplicent.RelationsipStatus.DateofMarriage.Month, .year = Model.PrimaryApplicent.RelationsipStatus.DateofMarriage.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0ba2a1a", .Id = "_2a0b0a0a0a4a0a0c0ba2a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0ba2a1a})
            </div>
        </div>
        <div class="form-group _2a0b0a0a0a4a0a0c0bb1a1a0_3 
             @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.RelationsipStatus Is Nothing And (Model.PrimaryApplicent.RelationsipStatus.RelationshipStatus = 3)), "", "sr-only"))
             ">
            <label class="text-left control-label col-md-5">Date of intended marriage</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate_2a0b0a0a0a4a0a0c0ba3a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing)) Then
                        _defaultdate_2a0b0a0a0a4a0a0c0ba3a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.RelationsipStatus.DateofIntMarriage.Day, .month = Model.PrimaryApplicent.RelationsipStatus.DateofIntMarriage.Month, .year = Model.PrimaryApplicent.RelationsipStatus.DateofIntMarriage.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0ba3a1a", .Id = "_2a0b0a0a0a4a0a0c0ba3a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0ba3a1a})
            </div>
        </div>
        <div class="form-group _2a0b0a0a0a4a0a0c0bb1a1a0_4 
             @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.RelationsipStatus Is Nothing And (Model.PrimaryApplicent.RelationsipStatus.RelationshipStatus = 4)), "", "sr-only"))
             ">
            <label class="text-left control-label col-md-5">Date relationship began</label>
            <div class="col-md-4">
                @Code
                    Dim _defaultdate_2a0b0a0a0a4a0a0c0ba4a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = 1, .month = 1, .year = DateTime.Now.AddYears(-10).Year}
                    If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing)) Then
                        _defaultdate_2a0b0a0a0a4a0a0c0ba4a1a = New CustomDateCtrlModels.DefaulDateValue() With {.day = Model.PrimaryApplicent.RelationsipStatus.DateRelBegan.Day, .month = Model.PrimaryApplicent.RelationsipStatus.DateRelBegan.Month, .year = Model.PrimaryApplicent.RelationsipStatus.DateRelBegan.Year}
                    End If
                End Code
                @Html.Partial("~/Views/Shared/CustomControls/custctrlDate.vbhtml", New CustomDateCtrlModels() With {.ClassName = "_2a0b0a0a0a4a0a0c0ba4a1a", .Id = "_2a0b0a0a0a4a0a0c0ba4a1a", .DefaultValue = _defaultdate_2a0b0a0a0a4a0a0c0ba4a1a})
            </div>
        </div>
        
        <!-- #endregion Relationship status -->
        <!-- #region Other names / spellings -->
        <div class="form-group row">
            <h3 class="">
                Other names / spellings
            </h3>
            <div class="form-group">
                <label class="control-label col-xs-12 col-md-6 text-left">Is this applicant currently, or have they ever been known by any other names?</label>
                <label class="radio-inline" for="othername1">
                    <input  id="_2a0b0a0a0a4a0a0c0bc1b1a0idm192440472" name="_2a0b0a0a0a4a0a0c0bc1b1a0" type="radio" value="1" 
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasAnyOtherNames = 1)), "checked", ""))
                            data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="othername1">
                    <input id="_2a0b0a0a0a4a0a0c0bc1b1a0idm192440184" name="_2a0b0a0a0a4a0a0c0bc1b1a0" type="radio" value="2" 
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasAnyOtherNames = 2)), "checked", (If(Model Is Nothing, "checked", ""))))
                            data-target="othername1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="othername1-yes col-xs-12 
                  @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasAnyOtherNames = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))
                 ">
                <table class="form-group collection-table table-responsive table-striped" id="tbl_othernames" >
                    <thead>
                        <tr>
                            <th>Family name</th>
                            <th>Given names</th>
                            <th>Reason</th>
                            <th>Actions </th>
                        </tr>
                    </thead>
                    <tbody>
                       @If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.OtherNames.Count > 0))) Then
                           @For Each othername As OtherName In Model.PrimaryApplicent.OtherNames
                                @<tr data-guid="@othername.Guid.ToString()">
                                <td Class="tbl-cell">@othername.FamilyName</td>
                                <td Class="tbl-cell">@othername.GivenName</td>
                                <td Class="tbl-cell">@othername.strReason</td>                                
                                <td Class="tbl-cell tbl-cell-action"><a title="Edit" class="edit" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addothernames" data-successcallback="addothernames_successcallback_edit" data-controllername="OtherName" data-actionname="Edit" data-title="Edit other names" data-guid="@othername.Guid.ToString()"></a>
                                <a title="Delete" class="delete" data-toggle="modal" data-target="#modalConfirmDialog" data-modelid="addothernames" data-successcallback="addothernames_successcallback_delete" data-controllername="OtherName" data-actionname="Delete" data-title="Delete other names" data-guid="@othername.Guid.ToString()"></a></td>
                                </tr>
                           Next
                       End If
                    </tbody>
                </table> 

                <div class="form-group col-md-2 pull-right">                    
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" 
                       data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addothernames" 
                       data-successcallback="addothernames_successcallback"
                       data-controllername="OtherName" data-actionname="Add" data-title="Add other names"
                       >Add</a><br />
                </div>               
            </div>
            
        </div>

        <!-- #endregion Other names / spellings -->
        <!-- #region Citizenship -->
        <h3 class="form-group">
            Citizenship
        </h3>
        <div class="form-group">
            <label class="control-label col-xs-12 col-md-6 text-left">Is this applicant a citizen of the country of passport?</label>
            <label class="radio-inline" for="citizen1">
                <input  id="_2a0b0a0a0a4a0a0c0bd1b1aidm192423192" name="_2a0b0a0a0a4a0a0c0bd1b1a" type="radio" value="1"  
                       @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.Citizenship.IsCitizenofCountryofPp = 1)), "checked", (If(Model Is Nothing, "checked", ""))))
                         />
                Yes
            </label>
            <label class="radio-inline" for="citizen1">
                <input id="_2a0b0a0a0a4a0a0c0bd1b1aidm192422976" name="_2a0b0a0a0a4a0a0c0bd1b1a" type="radio" value="2"  
                        @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.Citizenship.IsCitizenofCountryofPp = 2)), "checked", ""))
                        />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="control-label col-xs-12 col-md-6 text-left">Is this applicant a citizen of any other country?</label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input id="_2a0b0a0a0a4a0a0c0bd2b1aidm192420456" name="_2a0b0a0a0a4a0a0c0bd2b1a" type="radio" value="1"  
                       @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.Citizenship.IsCitizenofAny = 1)), "checked", ""))  
                       data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="citizen1_othercounty">
                <input id="_2a0b0a0a0a4a0a0c0bd2b1aidm192420168" name="_2a0b0a0a0a4a0a0c0bd2b1a" type="radio" value="2" 
                        @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.Citizenship.IsCitizenofAny = 2)), "checked", (If(Model Is Nothing, "checked", ""))))  
                       data-target="citizen1_othercounty-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group citizen1_othercounty-yes 
             @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.Citizenship.IsCitizenofAny = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))  
             ">
            
                <label class="text-left control-label col-md-6">List countries</label>
                <div class="col-md-4 input-group">
                   @Html.Partial("~/Views/Shared/CustomControls/custctrlCountries.vbhtml", New CustomCtrlCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0bd5a1a0_ctrl", .Id = "_2a0b0a0a0a4a0a0c0bd5a1a0_ctrl", .DefaultValue = 1})  
                    <span class="input-group-btn">
                        <button class="btn btn-secondary btn-sm" type="button" onclick="addCountry(this);" data-target="_2a0b0a0a0a4a0a0c0bd5a1a0_list" data-ctrlname="_2a0b0a0a0a4a0a0c0bd5a1a0"><i class="fa fa-plus-square"></i></button>
                    </span>
                </div>
        </div>
        <div class="form-group" id="_2a0b0a0a0a4a0a0c0bd5a1a0_list">
            @Code
                If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Not Model.PrimaryApplicent.Citizenship Is Nothing AndAlso (Not Model.PrimaryApplicent.Citizenship.Countries Is Nothing AndAlso Model.PrimaryApplicent.Citizenship.Countries.Count > 0)))) Then
                    For Each __country As Integer In Model.PrimaryApplicent.Citizenship.Countries
                        End Code
                        <div class="col-md-4 input-group col-md-offset-6" id="_2a0b0a0a0a4a0a0c0bd5a1a0_ctrl_@__country">
                            @Html.Partial("~/Views/Shared/CustomControls/custctrlCountries.vbhtml", New CustomCtrlCountry() With {.ClassName = "_2a0b0a0a0a4a0a0c0bd5a1a0_ctrl", .Id = "_2a0b0a0a0a4a0a0c0bd5a1a0", .DefaultValue = __country})
                            <span class="input-group-btn">
                            <button class="btn btn-secondary btn-sm" type="button" data-target="_2a0b0a0a0a4a0a0c0bd5a1a0_list" onclick="removecountry(this,'_2a0b0a0a0a4a0a0c0bd5a1a0_ctrl_@__country')"><i class="fa fa-minus-square"></i></button>
                            </span>
                         </div>
                        @Code
                                Next
                            End If
            End Code
        </div>
        <!-- #endregion Citizenship -->
        <!-- #region Other passports -->
        <div class="form-group row">
            <h3>
                Other passports
            </h3>
            <div class="form-group">
                <label class="control-label col-xs-12 col-md-6 text-left">Does this applicant have other current passports?</label>
                <label class="radio-inline" for="otherpassports">
                    <input id="_2a0b0a0a0a4a0a0c0be1b1aidm198308256" name="_2a0b0a0a0a4a0a0c0be1b1a" type="radio" value="1"  
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasOtherPassports = 1)), "checked", "")) 
                           data-target="otherpassports-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="otherpassports">
                    <input id="_2a0b0a0a0a4a0a0c0be1b1aidm198307968" name="_2a0b0a0a0a4a0a0c0be1b1a" type="radio" value="2" 
                            @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasOtherPassports = 2)), "checked", (If(Model Is Nothing, "checked", ""))))  
                           data-target="otherpassports-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="otherpassports-yes col-xs-12 
                  @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.hasOtherPassports = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))  
                 ">
                <table class="form-group collection-table table-responsive table-striped" id="tbl_otherpassports">
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
                        @If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Not Model.PrimaryApplicent.OtherPassports Is Nothing AndAlso (Model.PrimaryApplicent.OtherPassports.Count > 0)))) Then
                            @For Each otherpassport As PassportModels In Model.PrimaryApplicent.OtherPassports
                                @<tr data-guid="@otherpassport.Guid.ToString()">
                                    <td Class="tbl-cell">@otherpassport.FamilyName</td>
                                    <td Class="tbl-cell">@otherpassport.GivenName</td>
                                    <td Class="tbl-cell">@otherpassport.PassportNumber</td>
                                     <td Class="tbl-cell">@otherpassport.GetCountryName</td>
                                    <td Class="tbl-cell tbl-cell-action">
                                        <a title="Edit" class="edit" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addothernames" data-successcallback="addotherpp_successcallback_edit" data-controllername="OtherPassport" data-actionname="Edit" data-title="Edit other Passport" data-guid="@otherpassport.Guid.ToString()"></a>
                                        <a title="Delete" class="delete" data-toggle="modal" data-target="#modalConfirmDialog" data-modelid="addothernames" data-successcallback="addotherpp_successcallback_delete" data-controllername="OtherPassport" data-actionname="Delete" data-title="Delete other Passport" data-guid="@otherpassport.Guid.ToString()"></a>
                                    </td>
                                </tr>
                            Next
                       End If
                    </tbody>
                </table>

                <div class="form-group col-md-2 pull-right">
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" 
                       data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addotherpassports" 
                       data-successcallback="addotherpp_successcallback"
                       data-controllername="OtherPassport" data-actionname="Add"
                       data-title="Add other passports">Add</a><br />
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
                <label class="control-label col-xs-12 col-md-6 text-left">Does this applicant have national identity documents?</label>
                <label class="radio-inline" for="nid">
                    <input id="_2a0b0a0a0a4a0a0c0bf1b1a0idm198283128" name="_2a0b0a0a0a4a0a0c0bf1b1a0" type="radio" value="1"  
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyNIDs = 1)), "checked", "")) 
                           data-target="nid-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="nid">
                    <input id="_2a0b0a0a0a4a0a0c0bf1b1a0idm198282840" name="_2a0b0a0a0a4a0a0c0bf1b1a0" type="radio" value="2" 
                            @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyNIDs = 2)), "checked", (If(Model Is Nothing, "checked", ""))))   
                           data-target="nid-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="nid-yes col-xs-12 
                  @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyNIDs = 2)), "sr-only", (If(Model Is Nothing, "sr-only", ""))))
                 ">
                <table class="form-group  collection-table table-responsive table-striped" id="tbl_nids">
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
                        @If (Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing AndAlso (Not Model.PrimaryApplicent.NationalIDs Is Nothing AndAlso (Model.PrimaryApplicent.NationalIDs.Count > 0)))) Then
                            @For Each _nid As NationalIDs In Model.PrimaryApplicent.NationalIDs
                                @<tr data-guid="@_nid.Guid.ToString()">
                                    <td Class="tbl-cell">@_nid.FamilyName</td>
                                    <td Class="tbl-cell">@_nid.GivenName</td>
                                    <td Class="tbl-cell">@_nid.strTypeOfDocument</td>
                                     <td Class="tbl-cell">@_nid.strCountryName</td>
                                    <td Class="tbl-cell tbl-cell-action">
                                        <a title="Edit" class="edit" data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addothernames" data-successcallback="addniddoc_successcallback_edit" data-controllername="NationalId" data-actionname="Edit" data-title="Edit national identity document" data-guid="@_nid.Guid.ToString()"></a>
                                        <a title="Delete" class="delete" data-toggle="modal" data-target="#modalConfirmDialog" data-modelid="addothernames" data-successcallback="addniddoc_successcallback_delete" data-controllername="NationalId" data-actionname="Delete" data-title="Delete national identity document" data-guid="@_nid.Guid.ToString()"></a>
                                    </td>
                                </tr>
                            Next
                       End If
                    </tbody>
                </table>

                <div class="form-group col-md-2 pull-right">
                    <a class="form-control btn btn-sm btn-primary col-xs-12" href="#" 
                       data-toggle="modal" data-target="#modalAppSaveCancel" data-modelid="addnid"
                        data-successcallback="addniddoc_successcallback"
                       data-controllername="NationalId" data-actionname="Add" 
                       data-title="Add National identity documents">Add</a><br />
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
                <label class="control-label col-xs-12 col-md-6 text-left">Has this applicant undertaken a health examination for an Australian visa in the last 12 months?</label>
                <label class="radio-inline" for="helthexam">
                    <input id="_2a0b0a0a0a4a0a0c0bh1b1a0idm196064776" name="_2a0b0a0a0a4a0a0c0bh1b1a0" type="radio" value="1"  
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyHealthExamination = 1)), "checked", "")) 
                           data-target="helthexam-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="nid">
                    <input id="_2a0b0a0a0a4a0a0c0bh1b1a0idm196064560" name="_2a0b0a0a0a4a0a0c0bh1b1a0" type="radio" value="2" 
                           @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyHealthExamination = 2)), "checked", (If(Model Is Nothing, "checked", "")))) 
                            data-target="helthexam-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
            <div class="helthexam-yes col-xs-12 
                 @(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent Is Nothing And (Model.PrimaryApplicent.IsAnyHealthExamination = 2)), "sr-only", (If(Model Is Nothing, "sr-only", "")))) 
                 ">
                <div class=" form-group col-xs-12">
                    <label class="text-left control-label col-md-5" for="helthexam-det">Give details</label>
                    <textarea id="_2a0b0a0a0a4a0a0c0bh2a1a" name="_2a0b0a0a0a4a0a0c0bh2a1a" title="Give details" data-maxlength="300" cols="70" rows="5" class="form-control col-md-4">@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.HealthExamination Is Nothing), Model.PrimaryApplicent.HealthExamination.Details, ""))</textarea>
                </div>
                <div class="form-group col-xs-12">
                    <label class="text-left control-label col-md-5">HAP ID (If available)</label>
                    <div class="col-md-4">
                        <input type="text" class="form-control input-sm" placeholder="HAP ID (If available)" id="_2a0b0a0a0a4a0a0c0bh3a1a0" name="_2a0b0a0a0a4a0a0c0bh3a1a0" title="HAP ID (If available)" maxlength="21" size="50"
                               value="@(If(Not Model Is Nothing AndAlso (Not Model.PrimaryApplicent.HealthExamination Is Nothing), Model.PrimaryApplicent.HealthExamination.HAPID, ""))"
                                />
                    </div>
                </div>
            </div>
        </div>
        <!-- #endregion Health examination -->
    </div>
</div>


