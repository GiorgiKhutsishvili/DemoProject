//$(document).ready(function () {
//            $(".btn").click(function () {
//            var text = $('#Professions :selected').text();
//            $.ajax({
//                type: 'POST',
//                url: '/Account/Register',
//                data: {
//                    SelectedProfession: text,
//                    //"__RequestVerificationToken": $('input[name=__RequestVerificationToken]').val()
//                },
//                success: function (data) {
//                    alert("success");
//                }
//            });
//        });
//});








//$(document).ready(function () {
//    $(".btn").click(function () {
//        var text = $('#Professions :selected').text();
//        $.ajax({
//            method: "POST",
//            url: "/Account/Register",
//            data: {
//                SelectedProfession: text,
//                "__RequestVerificationToken": $('input[name=__RequestVerificationToken]').val()
//            },
//            success: function (data) {
//                alert("success");
//            }
//        });
//    });
//});

//$(function () {
//    //$("form").submit(function () {
//    //    var text = $('#Professions :selected').text();
//    //    $.ajax({
//    //        method: "POST",
//    //        url: "/Account/Register",
//    //        data: {
//    //            SelectedProfession: text,
//    //            "__RequestVerificationToken": $('input[name=__RequestVerificationToken]').val()
//    //        },
//    //        success: function (data) {
//    //            alert("success");
//    //        }
//    //    });
//    //});

//    //$(".btn").click(function () {
//    //    var text = $('#Professions :selected').text();
//    //    $.ajax({
//    //        method: "POST",
//    //        url: "/Account/Register",
//    //        data: {
//    //            SelectedProfession: text,
//    //            "__RequestVerificationToken": $('input[name=__RequestVerificationToken]').val()
//    //        },
//    //        success: function (data) {
//    //            $("#Professions").submit();
//    //        }
//    //    });
//    //});
//});

//$(function () {
//    $(".btn").click(function () {
//        var formData = $('#Professions :selected').text();

//        $.post("/Account/Register", { SelectedProfession: formData }, function (data) {
//            alert(data.toString());
//        }, "text");
//    });
//});