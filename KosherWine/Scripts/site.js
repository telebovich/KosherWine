$(document).ready(function () {
    $("#email").data("default", $("#email").val());
});
$("#email").focus(function () {
    
    $(this).css("color", "Black");
    if ($(this).val() == $(this).data("default") || "") {
        $(this).val("");
    }
})
.blur(function () {
    if ($(this).val() == "") {
        $(this).val($(this).data("default"));
    }
});
$("#agree").click(function () {
    $("#contacts").submit();
});