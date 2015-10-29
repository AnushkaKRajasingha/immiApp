@Code
    ViewData("Title") = "step24"
    Layout = "~/Views/Shared/_StepLayout.vbhtml"
    ViewData("StepTitle") = "Partner visa declarations"
End Code
<form class="form-horizontal" role="form">
    <div>
    <div class="form-group">
        <label class="control-label">The applicants declare that they:</label>
    </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12 col-md-4">Will inform the Department of Immigration and Border Protection if the relationship between the applicant and sponsor breaks down or ends in divorce.</label>
            <label class="radio-inline" for="pvdec1">
                <input type="radio" name="pvdec1" value="yes" checked data-target="pvdec1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                Yes
            </label>
            <label class="radio-inline" for="pvdec1">
                <input type="radio" name="pvdec1" value="no" data-target="pvdec1-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                No
            </label>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12">Authorise the Australian Government to make enquiries necessary to determine their eligibility for permanent stay in Australia, and to use any information collected for that purpose. Information may be obtained from the following</label>
            <div class="col-xs-12 control-labe"><ul class="listLayout stacked left dot"><li>Federal, state or territory government agencies</li><li>Federal, state or territory law enforcement agencies</li><li>State or territory housing authorities (including private landlords)</li><li>Local government authorities</li><li>Financial institutions</li><li>Educational institutions</li><li>Private business (including telecommunication and internet service providers, insurance companies)</li><li>Any other relevant business or agencies</li></ul></div>
            <div class="col-md-offset-4">
                <label class="radio-inline" for="pvdec2">
                    <input type="radio" name="pvdec2" value="yes" checked data-target="pvdec2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="pvdec2">
                    <input type="radio" name="pvdec2" value="no" data-target="pvdec2-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
        </div>
        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12">Understand that, if required to provide their fingerprints and facial image, the applicant's fingerprints and facial image and biographical information held by the Department of Immigration and Border Protection may be given to Australian law enforcement agencies to help identify the applicant and determine eligibility for grant of the visa being applied for, and for law enforcement purposes.</label>
            
            <div class="col-md-offset-4">
                <label class="radio-inline" for="pvdec3">
                    <input type="radio" name="pvdec3" value="yes" checked data-target="pvdec3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="pvdec3">
                    <input type="radio" name="pvdec3" value="no" data-target="pvdec3-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12">Consent to:</label>
            <div class="col-xs-12 control-labe"><ul class="listLayout stacked left dot"><li>Australian law enforcement agencies disclosing the applicant’s biometric, biographical and criminal record information to the Department of Immigration and Border Protection for any of the purposes outlined above; and</li><li>The Department of Immigration and Border Protection using the information obtained for the purposes of the Migration Act 1958 or the Citizenship Act 2007.</li></ul></div>
            <div class="col-md-offset-4">
                <label class="radio-inline" for="pvdec4">
                    <input type="radio" name="pvdec4" value="yes" checked data-target="pvdec4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="pvdec4">
                    <input type="radio" name="pvdec4" value="no" data-target="pvdec4-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
        </div>

        <div class="form-group">
            <label class="text-left control-label radio-inline col-xs-12">Understand that, if granted the visa:</label>
            <div class="col-xs-12 control-labe"><ul class="listLayout stacked left dot"><li>there is a two-year wait for social security payments, including unemployment benefits, for most newly arrived migrants</li><li>the applicants will need to have enough money, even if unemployed, to support themselves for the first two years and if they run out of money or fail to get a job in that period, that would not be sufficient reason to make them eligible for social security income support payments</li><li>the cost of living in Australia, compared to many other countries, is high</li><li>approval to migrate does not guarantee employment in Australia and that it is entirely their own responsibility to secure employment after arrival, including investigating their prospects before arrival in Australia</li><li>work availability varies significantly from time to time in different parts of Australia and that for many jobs in Australia, applicants must be eligible for membership of a professional or industry organisation and/or be able to be registered or licensed with an Australian state authority before working in a particular occupation.</li></ul></div>
            <div class="col-md-offset-4">
                <label class="radio-inline" for="pvdec5">
                    <input type="radio" name="pvdec5" value="yes" checked data-target="pvdec5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    Yes
                </label>
                <label class="radio-inline" for="pvdec5">
                    <input type="radio" name="pvdec5" value="no" data-target="pvdec5-yes" data-toggleclass="sr-only" onchange="toggelElemDisplay(this);" />
                    No
                </label>
            </div>
        </div>
    </div>
</form>

