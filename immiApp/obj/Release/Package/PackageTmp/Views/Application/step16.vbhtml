@Code
    ViewData("Title") = "step16"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Relationship"
End Code
<form class="form-horizontal" role="form">
    <div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Relationship status</label>
            <div class="col-md-3">
                <select class="form-control input-sm">
                    <option value="demo_value">demo value</option>
                </select>
            </div>
            <div class="col-md-2">
                <button data-placement="bottom" title="Family and given names"
                        data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space" data-trigger="focus" data-popoverid="fld_familyname"
                        type="button"></button>
            </div>
        </div>
        <div class="form-group ">
            <label class="text-left control-label col-md-4">Date of marriage</label>
            <div class="col-md-3">
                <input type="date" placeholder="DD/MM/YYYY" class="form-control  input-sm" />
            </div>            
        </div>
        <div class="form-group ">
            <label class="text-left control-label col-md-4">Place of marriage</label>
            <div class="col-md-3">
                <input type="text" placeholder="Location" class="form-control  input-sm" />
            </div>
        </div>
        <div class="form-group ">
            <label class="text-left control-label col-md-4">Celebrant Officiant name</label>
            <div class="col-md-3">
                <input type="text" placeholder="Celebrant Officiant name" class="form-control  input-sm" />
            </div>
        </div>
        <div class="form-group ">
            <label class="text-left control-label col-md-4">Celebrant ID number</label>
            <div class="col-md-3">
                <input type="text" placeholder="Celebrant Officiant name" class="form-control  input-sm" />
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this applicant related to the sponsor by blood, marriage or adoption?</label>
            <label class="radio-inline" for="sbmoadopt">
                <input type="radio" name="sbmoadopt" value="yes"  data-target="sbmoadopt-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="sbmoadopt">
                <input type="radio" name="sbmoadopt" value="no" checked  data-target="sbmoadopt-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="form-group sbmoadopt-yes sr-only">
            <label class="text-left control-label col-md-4">Give details</label>
            <div class="col-md-5">
               <textarea   class="form-control" ></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Have the applicant and the sponsor met in person (if met on the internet only, select No)?</label>
            <label class="radio-inline" for="sponmetinperson">
                <input type="radio" name="sponmetinperson" value="yes" data-target="sponmetinperson-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="sponmetinperson">
                <input type="radio" name="sponmetinperson" value="no" checked data-target="sponmetinperson-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="sponmetinperson-yes sr-only">
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Date applicant and sponsor first met</label>
                <div class="col-md-3">
                    <input type="date" placeholder="DD/MM/YYYY" class="form-control  input-sm" />
                </div>
            </div>
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Location of first meeting</label>
                <div class="col-md-3">
                    <input type="text" placeholder="Location" class="form-control  input-sm" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is the relationship between the applicant and the sponsor genuine and continuing?</label>
            <label class="radio-inline" for="genuineandcontinue">
                <input type="radio" name="genuineandcontinue" value="yes"  />
                Yes
            </label>
            <label class="radio-inline" for="genuineandcontinue">
                <input type="radio" name="genuineandcontinue" value="no" checked  />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Do the applicant and the sponsor have a mutual commitment to a shared life as husband and wife, or as de facto partners to the exclusion of all others?</label>
            <label class="radio-inline" for="exclutionallother">
                <input type="radio" name="exclutionallother" value="yes" data-target="exclutionallother-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="exclutionallother">
                <input type="radio" name="exclutionallother" value="no" checked data-target="exclutionallother-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="exclutionallother-yes sr-only">
            <div class="form-group ">
                <label class="text-left control-label col-md-4">Date applicant and sponsor committed to a shared life together to the exclusion of all others</label>
                <div class="col-md-3">
                    <input type="date" placeholder="DD/MM/YYYY" class="form-control  input-sm" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Is this applicant related to the sponsor by blood, marriage or adoption?</label>
            <label class="radio-inline" for="livedseparatly">
                <input type="radio" name="livedseparatly" value="yes" data-target="livedseparatly-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="livedseparatly">
                <input type="radio" name="livedseparatly" value="no" checked data-target="livedseparatly-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="form-group livedseparatly-yes sr-only">
            <label class="text-left control-label col-md-4">Give details</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Has the applicant entered into the relationship with the sponsor freely without force or coercion?</label>
            <label class="radio-inline" for="withoutforce">
                <input type="radio" name="withoutforce" value="yes" checked data-target="withoutforce-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="withoutforce">
                <input type="radio" name="withoutforce" value="no"  data-target="withoutforce-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
            <button data-placement="bottom" title="Family and given names"
                    data-toggle="popover" class="popover fa fa-question-circle vcenter pull-right-with-space list-inline" data-trigger="focus" data-popoverid="fld_familyname"
                    type="button"></button>
        </div>
        <div class="form-group withoutforce-yes sr-only">
            <label class="text-left control-label col-md-4">Give details</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <h3>Relationship details</h3>
            <label class="">
                In the following questions, details of the relationship between the applicant and sponsor must be provided and should form the basis of the applicant's claim that their relationship with their sponsor is genuine and continuing. The information provided also needs to be supported by relevant evidence. This evidence may be such things as photographs, receipts, bills, legal documents or anything else to demonstrate the nature of the relationship the applicant has with their sponsor. This evidence can be uploaded after the submission of this application.
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Give details of the financial aspects of the relationship.</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Give details of the nature of the household.</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Give details of the social aspects of the relationship.</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Give details of the nature of the commitment the applicant and the sponsor have to each other.</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label col-md-4">Give details of the development of the relationship between the applicant and the sponsor.</label>
            <div class="col-md-5">
                <textarea class="form-control"></textarea>
            </div>
        </div>
        <div class="form-group">
            <label>Family violence is an unacceptable occurrence that has a tragic impact on the lives of victims, the community and the economy. The Australian Government is committed to achieving a reduction in family and sexual violence, particularly against women and their children. As part of this commitment, all successful applicants will be provided with a link in their visa grant letter to information about family and sexual violence, forced marriage and Australian law, and the services and support available within Australia.</label>
        </div>
    </div>
</form>

