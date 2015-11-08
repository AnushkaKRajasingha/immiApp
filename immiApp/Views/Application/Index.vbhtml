@ModelType immiApp.ApplicationModels
@Code
    Dim _appGuid As String = ""
    ViewData("Title") = "Application"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
@section scripts
<script type="text/javascript">
    (function ($) {
        var $_smartWizard = null;
        var cachedData = Array();

    $(document).ready(function () {
        $_smartWizard = $('#wizard').smartWizard({
            contentURL: '@Url.Action("GetformSteps", "Application")',
            contentCache: true,
            onShowStep: wizard_onStepChanged,
            labelFinish: 'Save',
            onShowStep: wisard_onShowStep,
            contentLoadComplete: wizrad_contentLoadComplete,
            enableFinishButton: true,
            onFinish: onFinishCallback,
            onLeaveStep: onLeaveStepCallback,
            ajaxDataToSubmit: { _appGuid: $('[name=_appGuid]').val() },
            oninitComplete: oninitCompleteCallback,
            keyNavigation : false
        });
        $('.buttonNext').addClass('buttonDisabled');

        function oninitCompleteCallback() {
            $('.actionBar').prepend(
                '<a href="@Url.Action("ListApps", "Application")" class="button btn btn-primary btn-sm pull-left">My Applications</a>' +
                '<a href="#" onclick="javascript : $(\'#wizard\').smartWizard(\'reloadCurrentStep\');" title="Refresh" class="button btn btn-primary btn-sm pull-right"><i class="fa fa-small fa-refresh"></i></a>'
                );
        }

        function setwizardMessage(msg) {
            $('#wizard').smartWizard('showMessage', msg);
            setTimeout(function () { $('#wizard').smartWizard('hideMessage'); }, 2000);
        }

        function onLeaveStepCallback() {
            if (this.curStepIdx == '0' && !$('[name=_2a0b0a0a0a4a0a0a0g0b0]').is(':checked')) {
                this.msgBox.html('You must agreed to the terms and conditions');
                this.msgBox.show();
                var hidemsg = this.msgBox;
                setTimeout(function () { $(hidemsg).fadeOut('normal'); }, 2000);
                return false;
            }
            if (this.curStepIdx == '3' && $('[name=_2a0b0a0a0a4a0a0d0j0b0]:checked').val() == 2) {
                this.msgBox.html('Please correct your information to proceed.');
                this.msgBox.show();
                var hidemsg = this.msgBox;
                setTimeout(function () { $(hidemsg).fadeOut('normal'); }, 2000);
                return false;
            }

            var x = 1;
            return true;
        }
        function onFinishCallback() {
            $('[name=_stepNumber]').val(arguments[1].fromStep);

            $_formpost = $.post(
                '@Url.Action("save", "Application")',
                $('#mainForm').serialize()
              )
             .error(function () { console.log('error'); })
             .done(function () { console.log('Done') })
            .success(function (response) {
                $('[name=_appGuid]').val(response);
                setwizardMessage('Successfully Saved. :)');
                $_smartWizard.smartWizard('setAjaxSubmitData', { _appGuid: response});
            });
        }
        function wizrad_contentLoadComplete() {
            $('.popover').popover({
                content : tooltipajaxcall,
                html: true,
                container: 'body',
            });

            
        }

        function tooltipajaxcall() {
            var id = $(this).data('popoverid');
            var _link = '@Url.Action("Index", "Popover", New With {.popoverid = "__popoverid"})';
            _link = _link.replace("__popoverid", id);

            if (id in cachedData) {
                return cachedData[id];
            }

            var localData = "error";

            $.ajax(_link, {
                async: false,
                success: function (data) {
                    localData = data;
                }
            });

            cachedData[id] = localData;

            return localData;
        }

        function adjustActionBar() {
            window.scrollTo(0, 0);
          /*  $('.actionBar').css({
                'position': 'inherit',
                'top': 'inherit' // $('.navbar').height()+$('.panel > h1').height()+$('.stepContainer').height() + 10 + 'px'
            });*/
            $('.actionBar').css({
                'position': 'absolute',
                'top': $('.actionBar').prev().height() + 5 + 'px'
            });
            console.log('adjustActionBar');
        }

        function wisard_onShowStep() {
            console.log('wisard_onShowStep');
            // $('.buttonNext').addClass('buttonDisabled');
            if ($_smartWizard.smartWizard('currentStep') == 4 && $('[name=_2a0b0a0a0a4a0a0d0j0b0]:checked').val() == 2) {
                jQuery('.buttonNext').addClass('buttonDisabled')
            }
            adjustActionBar();
        }

        function wizard_onStepChanged(event, currentIndex, priorIndex) {
           // adjustActionBar();
        }
        //$_smartWizard.smartWizard('fixHeight');

        $("div.modal").on("show.bs.modal", function (e) {
            var _modal = $(this);
            var link = $(e.relatedTarget);
            $(this).find(".modal-header h4.modal-title").html($(link).data("title"));
            var _modelid = $(link).data('modelid');
            var _guid = $(link).data('guid');
            var _link = '@Url.Action("LoadModal", "ModalDialog", New With {.guid = "__guid", .modalid = "__modelid", .actionname = "__actionname", .controllername = "__controllername"})';
            _link = _link.replace(/&amp;/g, '&')
            _link = _link.replace("__guid", _guid);
            _link = _link.replace("__modelid", _modelid);
            _link = _link.replace("__actionname", $(link).data('actionname'));
            _link = _link.replace("__controllername", $(link).data('controllername'));
            $(this).find(".modal-body").load(_link, function () {
                onFinishCallback({}, { fromStep: 3 });
            });

            $(this).find('.modal-footer .btn-action').unbind('click');
            $(this).find('.modal-footer .btn-action').click(function () {
                console.log('Modal hide')
                _modal.modal('hide');
                var ajaxurl = '@Url.Action("actionname", "controllername", New With {.id = "_itemGuid"})';
                ajaxurl = ajaxurl.replace(/&amp;/g, '&')
                ajaxurl = ajaxurl.replace("actionname", $(link).data('actionname'));
                ajaxurl = ajaxurl.replace("controllername", $(link).data('controllername'));
                if ($(link).data('guid') != undefined)
                    ajaxurl = ajaxurl.replace("_itemGuid", $(link).data('guid'));
                    var ajax_args = {
                        url: ajaxurl,
                        type:   'POST',
                        data: $('div#modalAppSaveCancel .modal-body form').serialize(),
                        dataType:   "text",
                        beforeSend: function () {
                                console.log('b4 save send');
                            },
                        error: function () {
                                console.log('if error on save');
                            },
                        success: window[$(link).data('successcallback')]
                    };
                    $state = $.ajax(ajax_args);

                    $state.complete(function () {
                        console.log('save ajax call complete');
                       /* $_smartWizard.smartWizard('reloadStep');
                        var top = $(link).position().top;
                        $(window).scrollTop(top);*/
                    });

            });
        });

    });
    })(jQuery);
</script>
End Section
<!-- #region modalDialogs -->
@section modalDialogs
    <!-- Modal modalApp -->
    <div id="modalApp" class="modal width-50" role="dialog">
        <div class="modal-dialog" >

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Title Template</h4>
                </div>
                <div class="modal-body">
                      Please wait..
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
    <!-- Modal modalAppSaveCancel -->
<div id="modalAppSaveCancel" class="modal width-50" role="dialog">
    <div class="modal-dialog">

        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Title Template</h4>
            </div>
            <div class="modal-body">
                Please wait..
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default btn-action" id="btnSaveDialogContents" >Save</button>
                <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
            </div>
        </div>

    </div>
</div>

        <!-- Modal modalAppSaveCancel -->
<div id="modalConfirmDialog" class="modal width-25" role="dialog">
    <div class="modal-dialog">

        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Title Template</h4>
            </div>
            <div class="modal-body">
                Do you want to delete the record ?
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default btn-action" id="btnConfirmDialog">Confirm</button>
                <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
            </div>
        </div>

    </div>
</div>
End Section
<!-- #endregion modalDialogs -->
<!-- #region Main Form -->
<form id="mainForm">
   
    @If Model IsNot Nothing Then
        _appGuid = Model.Guid.ToString()
    End If
   
    <input name = "_appGuid" type="hidden" value="@_appGuid" />
    <input name = "_stepNumber" type="hidden" value="0" />
    <div Class="panel">
        <h1> Application For migration To Australia by a partner</h1>
        <div id = "wizard" Class="swMain">
            <ul>
                @Code
                    For index = 1 To 27
                End Code
                <li><a href="#step-type-@index"> <span class="stepNumber">@index</span> <span class="stepDesc"> Type<br /> <small>step @index</small> </span> </a></li>
                @Code
                    Next
                End Code
            </ul>
            @Code
                For index2 = 1 To 27
            End Code
            <div id="step-type-@index2">
                <h2 class="StepTitle">Step @index2</h2>
                <div class="controls-container">
                </div>
            </div>
            @Code
                Next
            End Code
        </div>
    </div>
</form>
<!-- #endregion Main Form -->
