function toggelElemDisplay(_this) {    
    var _target = $(_this).data('target');
    var _toggleclass = $(_this).data('toggleclass');
    if (_target != undefined && _toggleclass != undefined) {

    if(arguments.length > 1){
        var _vlaues = arguments[1].split(",");
        if (($('.' + _target).hasClass(_toggleclass) && $.inArray($(_this).val(), _vlaues) > -1) ||(!$('.' + _target).hasClass(_toggleclass) && $.inArray($(_this).val(), _vlaues) <= -1))  return false;
    }
    $('.' + _target).toggleClass(_toggleclass);
    setDynamicHeight(_this);
    }
}

function toggelElementBySelectOption(_this) {
    var $_value = $(_this).find('option:selected').val();
    var $_targetDiv = $('.' + $(_this).data('toggleclsprefix') + '_' + $_value);
    var _toggleclass = $(_this).data('toggleclass');
    
    $_targetDiv.slideDown().removeClass(_toggleclass);
    $_targetDiv.siblings('[class*=' + $(_this).data('toggleclsprefix') + '_' + ']').slideUp(function () { $(this).addClass(_toggleclass); });
    setDynamicHeight(_this);
}

function setDynamicHeight(_that) {
    $('.actionBar').css({
        'position': 'absolute',
        'top': $(_that).closest('.content').height() + 15 + 'px'
    });
}

function addCountry(_this) {
    var _selector = $(_this).parent().prev('select');
    var _curElmId = _selector[0].id + '_' + _selector.val();
    var _target = $('#' + $(_this).data('target'));
    if (_target.children('#' + _curElmId).length > 0) { alert('The country already exists'); return false;}
    var $_container = $('<div/>').addClass('col-md-4 input-group col-md-offset-6').attr({ id: _curElmId });;
    var _clone = _selector.clone().attr({ id: '' });
    $(_clone).attr({
        name: $(_this).data('ctrlname')
    }).val(_selector.val());
    $_container.append(_clone);
    $btncnt = $('<span/>').addClass('input-group-btn');
    $btn = $('<button/>').addClass('btn btn-secondary btn-sm').attr({
        type: 'button',
        'data-target' :  $(_this).data('target'),
        onclick : "removecountry(this,'"+_curElmId+"')"
    }).append('<i class="fa fa-minus-square"></i>');
    $btncnt.append($btn);
    $_container.append($btncnt);
    _target.append($_container);
}

function removecountry(_this, _curElmId) {
    var _target = $('#' + $(_this).data('target'));
    _target.children('#' + _curElmId).remove();
}

function checkboxvaluesetter(_this) {
    if ($(_this).is(':checked')) {
        $(_this).val('True');
    }
    else {
        $(_this).val('False');
    }
}

$(document).ready(function () {
    $('.tooltips').tooltip();
    
});


/* Model dialog related ajax functions */
function validateResponse(res){
    $_response = JSON.parse(res);
    if($_response.error != undefined){console.log('Error occered : '+$_response.error ); return false;}return $_response;
}

/* add other name dialog */ 
function addothernames_successcallback(res) {
    $response = validateResponse(res);
    if(!$response) return false;
    $row = $('<tr/>').attr({ 'data-guid': $response.Guid, 'class': $response.Guid });
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell familyname',            
        })
        .html($response.FamilyName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell givenname',
        })
        .html($response.GivenName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell reason',
        })
        .html($response.strReason)
        );
    $row.append(
       $('<td/>').attr({
           'class': 'tbl-cell tbl-cell-action',
       })
       .append(
        $('<a/>').attr({
            'data-toggle':"modal" ,'data-target':"#modalAppSaveCancel",'data-modelid':"addothernames" 
                       ,'data-successcallback':"addothernames_successcallback_edit"
                       , 'data-controllername': "OtherName", 'data-actionname': "Edit", 'data-title': "Edit other names"
            , 'data-guid': $response.Guid,'class':'edit','title':'Edit'
        })
       )
       .append(
        $('<a/>').attr({
            'data-toggle': "modal", 'data-target': "#modalConfirmDialog", 'data-modelid': "addothernames"
                       , 'data-successcallback': "addothernames_successcallback_delete"
                       , 'data-controllername': "OtherName", 'data-actionname': "Delete", 'data-title': "Delete other names"
            , 'data-guid': $response.Guid, 'class': 'delete', 'title': 'Delete'
        })
       )
       );
    $('table#tbl_othernames > tbody').append($row);
}

function addothernames_successcallback_delete(res) {
    try {
        $response = validateResponse(res);
        $('tr[data-guid="' + $response.Guid + '"]').remove()
    } catch (e) {
        console.log(e.message);
    }
}

function addothernames_successcallback_edit(res) {
    try {
        addothernames_successcallback_delete(res);
        addothernames_successcallback(res);
    } catch (e) {
        console.log(e.message);
    }
}

/* end add other name dialog */

/* add other passport dialog */
function addotherpp_successcallback(res) {
    $response = validateResponse(res);
    if (!$response) return false;
    $row = $('<tr/>').attr({ 'data-guid': $response.Guid, 'class': $response.Guid });
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell familyname',
        })
        .html($response.FamilyName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell givenname',
        })
        .html($response.GivenName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell passportnumber',
        })
        .html($response.PassportNumber)
        );
    $row.append(
       $('<td/>').attr({
           'class': 'tbl-cell cofpassport',
       })
       .html($response.CountryName)
       );
    $row.append(
       $('<td/>').attr({
           'class': 'tbl-cell tbl-cell-action',
       })
       .append(
        $('<a/>').attr({
            'data-toggle': "modal", 'data-target': "#modalAppSaveCancel", 'data-modelid': "addothernames"
                       , 'data-successcallback': "addotherpp_successcallback_edit"
                       , 'data-controllername': "OtherPassport", 'data-actionname': "Edit", 'data-title': "Edit other names"
            , 'data-guid': $response.Guid, 'class': 'edit', 'title': 'Edit'
        })
       )
       .append(
        $('<a/>').attr({
            'data-toggle': "modal", 'data-target': "#modalConfirmDialog", 'data-modelid': "addothernames"
                       , 'data-successcallback': "addotherpp_successcallback_delete"
                       , 'data-controllername': "OtherPassport", 'data-actionname': "Delete", 'data-title': "Delete other names"
            , 'data-guid': $response.Guid, 'class': 'delete', 'title': 'Delete'
        })
       )
       );
    $('table#tbl_otherpassports > tbody').append($row);
}

function addotherpp_successcallback_edit(res) {
    try {
        addotherpp_successcallback_delete(res);
        addotherpp_successcallback(res);
    } catch (e) {
        console.log(e.message);
    }
}

function addotherpp_successcallback_delete(res) {
    try {
        $response = validateResponse(res);
        $('tr[data-guid="' + $response.Guid + '"]').remove()
    } catch (e) {
        console.log(e.message);
    }
}
/* add other passport dialog */

/* add NationaIDs */
function addniddoc_successcallback(res) {
    $response = validateResponse(res);
    if (!$response) return false;
    $row = $('<tr/>').attr({ 'data-guid': $response.Guid, 'class': $response.Guid });
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell familyname',
        })
        .html($response.FamilyName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell givenname',
        })
        .html($response.GivenName)
        );
    $row.append(
        $('<td/>').attr({
            'class': 'tbl-cell typeofdocument',
        })
        .html($response.strTypeOfDocument)
        );
    $row.append(
       $('<td/>').attr({
           'class': 'tbl-cell countryofissue',
       })
       .html($response.strCountryName)
       );
    $row.append(
       $('<td/>').attr({
           'class': 'tbl-cell tbl-cell-action',
       })
       .append(
        $('<a/>').attr({
            'data-toggle': "modal", 'data-target': "#modalAppSaveCancel", 'data-modelid': "addothernames"
                       , 'data-successcallback': "addniddoc_successcallback_edit"
                       , 'data-controllername': "NationalId", 'data-actionname': "Edit", 'data-title': "Edit other names"
            , 'data-guid': $response.Guid, 'class': 'edit', 'title': 'Edit'
        })
       )
       .append(
        $('<a/>').attr({
            'data-toggle': "modal", 'data-target': "#modalConfirmDialog", 'data-modelid': "addothernames"
                       , 'data-successcallback': "addniddoc_successcallback_delete"
                       , 'data-controllername': "NationalId", 'data-actionname': "Delete", 'data-title': "Delete other names"
            , 'data-guid': $response.Guid, 'class': 'delete', 'title': 'Delete'
        })
       )
       );
    $('table#tbl_nids > tbody').append($row);
}

function addniddoc_successcallback_edit(res) {
    try {
        addniddoc_successcallback_delete(res);
        addniddoc_successcallback(res);
    } catch (e) {
        console.log(e.message);
    }
}

function addniddoc_successcallback_delete(res) {
    try {
        $response = validateResponse(res);
        $('tr[data-guid="' + $response.Guid + '"]').remove()
    } catch (e) {
        console.log(e.message);
    }
}
/* add NationaIDs */