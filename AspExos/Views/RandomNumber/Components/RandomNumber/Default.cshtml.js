$("random-number-btn").on("click").add($(function () {
    $.ajax({
        type: "GET",
        url: "RandomNumber/GetRandomComponent",
        success: (data) => $("#random-number-container").html = data
    });
})