@modeltype Movetec_BulkSMS_API.API_Parameters_Model
@Code
    ViewData("Title") = "Home Page"

End Code

<div class="jumbotron">
    <h1>Send SMS Example using Movetec API</h1>
    <p class="lead">Sample application to send an SMS to any mobile carrier in Kenya using the Movetec SMS API.</p>
    <p><a target="_blank" href="https://github.com/dasiema" class="btn btn-primary btn-lg">Visit My Github</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Getting started</h2>
        <p>
            In this project I briefly demonstrate how to send an SMS to any obile carier in Kenya using the Movetec SMS API.
        </p>
        @code
            Html.RenderPartial("_ActionNotifications")
        End Code
        <form method="post">
            @Html.HiddenFor(Function(model) model.id)
            <div>
                <label class="col-sm-3 control-label">Base Url</label>
                @Html.TextBoxFor(Function(model) model.base_url, New With {Key .id = "base_url", .type = "text", .class = "form-control", .placeholder = "https://sms.movesms.co.ke/api/compose", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.base_url)</small>
            </div>

            <div>
                <label class="col-sm-3 control-label">Username</label>
                @Html.TextBoxFor(Function(model) model.username, New With {Key .id = "username", .type = "text", .class = "form-control", .placeholder = "Your Move SMS username", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.username)</small>
            </div>

            <div>
                <label class="col-sm-3 control-label">API Key</label>
                @Html.TextBoxFor(Function(model) model.key, New With {Key .id = "key", .type = "text", .class = "form-control", .placeholder = "Your API Key", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.key)</small>
            </div>

            <div>
                <label class="col-sm-3 control-label">Sender</label>
                @Html.TextBoxFor(Function(model) model.sender, New With {Key .id = "sender", .type = "text", .class = "form-control", .placeholder = "SMARTLINK", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.sender)</small>
            </div>
            <div>
                <label class="col-sm-3 control-label">Message Type</label>
                @Html.TextBoxFor(Function(model) model.msgtype, New With {Key .id = "number", .type = "text", .class = "form-control", .placeholder = "5", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.msgtype)</small>
            </div>
            <div>
                <label class="col-sm-3 control-label">API Parameter (dlr)</label>
                @Html.TextBoxFor(Function(model) model.dlr, New With {Key .id = "dlr", .type = "number", .class = "form-control", .placeholder = "1", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.dlr)</small>
            </div>

            <div>
                <label class="col-sm-3 control-label">Phone Number</label>
                @Html.TextBoxFor(Function(model) model.phone, New With {Key .id = "phone", .type = "text", .class = "form-control", .placeholder = "07...", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.phone)</small>
            </div>

            <div>
                <label class="col-sm-3 control-label">Message</label>
                @Html.TextAreaFor(Function(model) model.message, New With {Key .id = "message", .type = "text", .Class = "form-control", .placeholder = "Your Message Here:", .required = "required"})
                <small style="color:orangered">@Html.ValidationMessageFor(Function(m) m.message)</small>
            </div>

            <button type="submit" class="btn btn-primary btn-lg"> Send SMS</button>
        </form>


    </div>

</div>


<script type="text/javascript">

        $(document).ready(function () {
            $('#phone').inputmask("0799 999 999");

        });
</script>