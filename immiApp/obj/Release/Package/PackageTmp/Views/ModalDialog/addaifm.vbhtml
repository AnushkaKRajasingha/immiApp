
@Code
    Layout = Nothing
End Code
<form class="form-horizontal" role="form">
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Family name</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Family name" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Given name</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Given name" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3 ">Sex</label>
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
        <label class="text-left control-label col-md-3">Date of Birth</label>
        <div class="col-md-4">
            <input type="date" class="form-control input-sm" placeholder="DD/MM/YYYY" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Immigration status</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Son" />
        </div>
    </div>
</form>
