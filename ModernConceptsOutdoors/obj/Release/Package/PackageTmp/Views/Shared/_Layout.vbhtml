<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <header>
        <section>
            <article class="inline">
                <div id="logoDiv"></div>
@*                <div id="titleDiv">
                    Modern Concepts Outdoors LLC
                    <br />
                    (217)567-3328
                </div>
                <div id="mainImageDiv"></div>*@
            </article>
        </section>
        <section id="menuListSection">
            <ul id="menuList">
                <li>@Html.ActionLink("Home", "Index", "Home")</li>
@*                <li>@Html.ActionLink("Blog", "Blog", "Home")</li>*@
                <li>@Html.ActionLink("The Original Spirit Lift", "OriginalSpiritLift", "Home")</li>
                <li>@Html.ActionLink("Spirit Lift 2.0", "SpiritLift2", "Home")</li>
                <li>@Html.ActionLink("Photos & Videos", "PhotosAndVideos", "Home")</li>
                <li>@Html.ActionLink("Contact Us", "ContactUs", "Home")</li>
            </ul>
        </section>
    </header>
    <section>
        @RenderBody()
    </section>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/knockout")
    @RenderSection("scripts", required:=False)
</body>
</html>
