@Code
    ViewData("Title") = "Contact Us"
End Code

<h2>Modern Concepts Outdoors, LLC</h2>
<div>RR2 Box 150B</div>
<div>Tower Hill, IL 62571</div>
<div>(217) 567-3328</div>
<div><a href="mailto: info@modernconceptsoutdoors.com">info@modernconceptsoutdoors.com</a></div>
<br />
<form id="contactUsForm" data-bind="submit: submit">
    <div class="row">
        <span class="onecol required">Name:</span>
        <input class="fourcol required" type="text" data-bind="value: name, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol">Street:</span>
        <input class="fourcol" type="text" data-bind="value: streetNumber, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol">City:</span>
        <input class="fourcol" type="text" data-bind="value: city, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol">State:</span>
        <input class="fourcol" type="text" data-bind="value: state, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol">Zip:</span>
        <input class="fourcol" type="text" data-bind="value: zip, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol required">Phone:</span>
        <input class="fourcol required" type="text" data-bind="value: phone, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol required">Email:</span>
        <input class="fourcol required" type="text" data-bind="value: email, valueUpdate: 'afterkeydown'" />
    </div>
    <div class="row">
        <span class="onecol">Message:</span>
        <textarea class="fourcol" data-bind="value: message, valueUpdate: 'afterkeydown'" ></textarea>
    </div>

    <div class="row">
        <button type="submit">Contact Us</button>
    </div>

    <div>
        <span data-bind="text: validationMessage"></span>
    </div>
</form>
@Section scripts
    <script type="text/javascript">
        var baseUri = '@ViewBag.ApiUri';
    </script>
    <script src="@Url.Content("~/Scripts/ContactUs.js")"></script>
End Section