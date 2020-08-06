$(function () {
    $("#showPass").change(function () {
        var checked = $(this).is(":checked");
        if (checked) {
            $("#pass").attr("type", "text");
        } else {
            $("#pass").attr("type", "password");
        }
    });
});