$(document).ready(function () {
    GetCountry();
    
    $('#To').attr('disabled', true);
    $('#Trainno').attr('disabled', true);
    $('#class').attr('disabled', true);
    $('#price').attr('disabled', true);


    $('#From').change(function () {
        $('#To').attr('disabled', false);
        var id = $(this).val();
        $('#To').empty();
        $('To').append('<Option>---Select source station--</Option>');
        $.ajax({
            url: '/Railway/To?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#To').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }
        });
    });
    $('#To').change(function () {
        $('#Trainno').attr('disabled', false);
        var id = $(this).val();
        $('#Trainno').empty();
        $('Trainno').append('<Option>---Select train no--</Option>');
        $.ajax({
            url: '/Railway/TrainName?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#Trainno').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }
        });
    });
    $('#Trainno').change(function () {
        $('#class').attr('disabled', false);
        var id = $(this).val();
        $('#class').empty();
        $('class').append('<Option>---Select class no--</Option>');
        $.ajax({
            url: '/Railway/TClass?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#class').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }
        });
    });
    $('#class').change(function () {
        $('#price').attr('disabled', false);
        var id = $(this).val();
        $('#price').empty();
        $('price').append('<Option>---Select price no--</Option>');
        $.ajax({
            url: '/Railway/TPrice?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#price').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }
        });
    });

});

function GetCountry() {
    $.ajax({
        url: '/Railway/From',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#From').append('<Option value=' + data.id + '>' + data.name + '</Option');
            });
        }
    });
}

