function toggelElemDisplay(_this) {
  /*  if (_this.length != undefined) {
        $.each(_this, function () {
            toggelElemDisplay($(this)[0]);
        });
        return;
    }*/
    var _target = $(_this).data('target');
    var _toggleclass = $(_this).data('toggleclass');
    if (_target != undefined && _toggleclass != undefined) {
        $('.' + _target).toggleClass(_toggleclass);
       // toggelElemDisplay($('.' + _target));
        $('.actionBar').css({
            'position': 'absolute',
            'top': $(_this).closest('.content').height() + 10 + 'px'
        });
    }
}
$(document).ready(function () {
    $('.tooltips').tooltip();
});

