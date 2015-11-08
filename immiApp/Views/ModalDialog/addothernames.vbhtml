@ModelType immiApp.DialogModels
@Code
    Layout = Nothing
End Code
<form class="form-horizontal" role="form" >
    <input name="_appGuid" type="hidden" value="" />
    <input name="_stepNumber" type="hidden" value="0" />
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Family name</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Family name"   id="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0b0a1a0"  name="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0b0a1a0" title="Family name" maxlength="100" size="50"/>
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Given name</label>
        <div class="col-md-4">
            <input type="text" class="form-control input-sm" placeholder="Given name" id="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0b1a1a0" name="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0b1a1a0" title="Given names" maxlength="100" size="50" />
        </div>
    </div>
    <div class="form-group col-xs-12">
        <label class="text-left control-label col-md-3">Reason for name change</label>
        <div class="col-md-4">
            <select class="form-control input-sm " id="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0c0b0a" name="_2a0b0a0a0a4a0a0c0bc3d-dlg-_0b0bj0a0a0c0b0a" title="Reason for name change" data-toggleclsprefix="othernameRes" data-toggleclass="sr-only" onchange="toggelElementBySelectOption(this);">
                <option value="1" selected="" data-null="1"></option>
                <option value="2">Deed Poll</option>
                <option value="3">Marriage</option>
                <option value="4">Other</option>
            </select>
        </div>
    </div>
    <div class="fothernameRes_1 othernameRes_2 othernameRes_3 sr-only"></div>
    <div class="form-group col-xs-12 othernameRes_4 sr-only">
        <label class="text-left control-label col-md-3">Give details</label>
        <div class="col-md-4">
            <textarea title="Give details" data-maxlength="300" cols="70" rows="5" class="form-control"  id="_2a0b0a0a0a4a0a0c0bh2a1a" name="_2a0b0a0a0a4a0a0c0bh2a1a" ></textarea>
        </div>
    </div>
</form>
