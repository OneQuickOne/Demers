$(document).ready(function () {
    var url = window.location.pathname;
    var substr = url.split('/');
    var urlaspx = substr[substr.length - 1];
    $('#top-nav').find('.active').removeClass('active');

    if (urlaspx) {
        $('.dropdown-menu li a').each(function () {
            if (this.href.indexOf(urlaspx) >= 0) {
                $('#top-nav').find('.active').removeClass('active');
                $(this).parent().addClass('active');
                $(this).closest('.dropdown').addClass('active');
                return;
            }
        });
    } else {
        $('#top-nav > .dropdown').first().addClass('active');
        $('#top-nav > .dropdown > .dropdown-menu > li').first().addClass('active');
    }
});
