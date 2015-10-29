<h1 class="StepTitle">@ViewData("StepTitle")</h1>
<div class="controls-container">
    @RenderBody()
</div>
@RenderSection("scripts", required:=False)