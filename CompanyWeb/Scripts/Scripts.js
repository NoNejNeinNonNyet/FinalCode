$(function () {

    $("#loaderbody").hide();
    $(document).bind("ajaxStart", function () { $("#loaderbody").show(); })
        .bind("ajaxStop", function () { $("#loaderbody").hide(); })
})

function jQueryAjaxPost(form) {

    $.validator.unobtrusive.parse(form);

    if ($(form).valid()) {
        var ajaxConfig =
        {
            type: "POST",
            url: form.action,
            data: new FormData(form),
            success: function (response) {
                if (response.success) {
                    $("#firstTab").html(response.html);
                    $.notify(response.message, "success");
                    resetAddNewTab($(form).attr("data-restUrl"), true);
                    if (typeof activatejQueryTable !== "undefined" && $.isFunction(activatejQueryTable))
                        activatejQueryTable();

                   
                }
            }
        };

        if ($(form).attr("enctype") == "multipart/form-data") {
            ajaxConfig["contentType"] = false;
            ajaxConfig["processData"] = false;
        }

        $.ajax(ajaxConfig);
    }
    return false;
}

function resetAddNewTab(resetUrl, showViewTab) {
    $.ajax({
        type: "GET",
        url: resetUrl,
        success: function (response) {
            $("#secondTab").html(response);
            $("ul.nav.nav-tabs a:eq(1)").html("Add New");
            if (showViewTab)
                $("ul.nav.nav-tabs a:eq(0)").tab("show");
        }
    })

}

function Delete(url) {

    if (confirm("Do you want to delete this item?") == true) {

        $.ajax({
            type: "POST",
            url: url,
            success: function (response) {
                if (response.success) {
                    $("#firstTab").html(response.html);
                    $.notify(response.message, "success");
                    if (activatejQueryTable !== "undefined" && $.isFunction(activatejQueryTable))
                        activatejQueryTable();
                }
            }
        });
    }


}

function Edit(url) {

    $.ajax({
        type: "GET",
        url: url,
        success: function (response) {
            $("#secondTab").html(response);

            $("ul.nav.nav-tabs a: eq(1)").tab("show");
            $("ul.nav.nav-tabs a: eq(1)").html("Edit");
        }
    });
}