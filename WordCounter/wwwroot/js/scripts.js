$(document).ready(function() {
    $("#add").click(function(event) {
        event.preventDefault();
        $(".word-inputs").append("<div class='form-group word-group'>" +
            "<label for='word-input'>Word</label>" +
            "<input type='text' name='word-input' class='form-control'>" +
            "</div>");
    });
});
