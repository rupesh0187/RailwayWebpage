// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    GetSeat();

    $('#price').attr('disabled', true);


    $('#Seat').change(function () {
        $('#price').attr('disabled', false);
        var id = $(this).val();
        $('#price').empty();
        $('price').append('<option>----Select price----</option>');
        $.ajax({
            url: '/Railway/Price?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#price').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }
        });
    });

});

function GetSeat() {
    $.ajax({
        url: '/Railway/Seat',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#Seat').append('<Option value=' + data.id + '>' + data.name + '</Option>');
            });
        }
    });
}