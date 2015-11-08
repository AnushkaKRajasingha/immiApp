<h1 class="StepTitle">@ViewData("StepTitle")<span class="pull-right" id="lbl_step"><span class="small">@(If(Not Model Is Nothing, "Ref. No: " + CType(Model, immiApp.ApplicationModels).UniqueID, ""))</span> &nbsp; @Request.Form("step_number")/26</span></h1>
<div class="controls-container">
    @RenderBody()
</div>
@RenderSection("scripts", required:=False)