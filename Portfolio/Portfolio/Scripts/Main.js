$(document).ready(function () {
  
    $('#content').on('mouseenter', function () {
        var activeSlide = $('.content.active');
        var nextSlide = activeSlide.next();
        if (!nextSlide.hasClass('content')) {
            nextSlide = $('.content').first();
        }
        activeSlide.removeClass('active').addClass('hide');
   
        nextSlide.removeClass('hide').addClass('active');
    });
});





