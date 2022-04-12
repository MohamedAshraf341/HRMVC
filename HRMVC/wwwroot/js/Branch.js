$(document).ready(function () {

    $('table .delete ').on('click', function () {
        var id = $(this).data("id");

        $.ajax({
            type: 'POST',
            url: 'Branch/Detail/',
            data: { "id": id },
            success: function (att) {
                $('#Delete #id').val(att.id);


            }
        })
    });

});