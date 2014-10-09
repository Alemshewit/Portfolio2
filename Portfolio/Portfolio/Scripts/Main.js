$(document).ready(function () {

    $('#contactForm').on('click','.btnprimary', function (event) {
        event.preventDefault();
        if ($(this).valid()){
            var urlToPostTo = $(this).data('action');
            
            var dataToSend = $(this).parent().serialize();
            $.post(urlToPostTo, dataToSend, function (data) {
                $('.contactContainer').html(data);
            });
        };
    });
});



