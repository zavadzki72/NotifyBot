$(document).ready(function () {
    $('.sidenav').sidenav();
    $('.parallax').parallax();
    $('.scrollspy').scrollSpy();
    $('.tooltipped').tooltip();

    $('#back-to-top').click(function () {
        $("html, body").animate({
            scrollTop: 0
        }, 700);
    });
});