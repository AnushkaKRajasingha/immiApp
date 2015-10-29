@Code
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
            labelFinish: 'Submit',
            onShowStep: wisard_onShowStep,
            contentLoadComplete: wizrad_contentLoadComplete
        });
        $('.buttonNext').addClass('buttonDisabled');

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
            adjustActionBar();
        }

        function wizard_onStepChanged(event, currentIndex, priorIndex) {
           // adjustActionBar();
        }
        //$_smartWizard.smartWizard('fixHeight');

        $("div.modal").on("show.bs.modal", function (e) {
            var link = $(e.relatedTarget);
            $(this).find(".modal-header h4.modal-title").html($(link).data("title"));
            var _modelid = $(link).data('modelid');
            var _link = '@Url.Action("LoadModal", "ModalDialog", New With {.modalid = "__modelid"})';
            _link = _link.replace("__modelid",_modelid);
            $(this).find(".modal-body").load(_link);
            
        });
       
    });
    })(jQuery);
</script>
End Section
<!-- #region modalDialogs -->
@section modalDialogs
    <!-- Modal modalApp -->
    <div id="modalApp" class="modal width-75" role="dialog">
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
<div id="modalAppSaveCancel" class="modal width-75" role="dialog">
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
                <button type="button" class="btn btn-default" >Save</button>
                <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
            </div>
        </div>

    </div>
</div>

End Section
<!-- #endregion modalDialogs -->
<div class="panel">
    <h1>Application for migration to Australia by a partner</h1>
    <div id="wizard" class="swMain">
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
