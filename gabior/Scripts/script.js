$(document).ready(function() {
    $('body').scrollspy({ target: '#navbar-gabior', offset: 80 });
})

/*----------------------------------------------
            M E N U   A N C H O R S
------------------------------------------------*/
$('.menu-item a[href*="#"], .navbar-brand').click(function () {
    if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '') && location.hostname === this.hostname) {
        var $target = $(this.hash);
        $target = $target.length && $target || $('[name=' + this.hash.slice(1) + ']');
        if ($target.length) {
            var targetOffset = $target.offset().top;
            if ($('body').hasClass('admin-bar'))
                $('html,body').animate({ scrollTop: targetOffset - 72 }, 1000);
            else
                $('html,body').animate({ scrollTop: targetOffset - 42 }, 1000);

            // collapse nav
            $('.navbar-collapse.in').removeClass('in').addClass('collapse');

            return false;
        }
    }
});

/*----------------------------------------------
            M E N U   F I X E D
------------------------------------------------*/
$(function () {
    $(window).bind("scroll", function () {
        if ($('body.overflowed').length < 1) {
            if ($(window).scrollTop() >= 85) {
                $('#jHeader').addClass('overflow');
            } else {
                $('#jHeader').removeClass('overflow');
            }
        }
        if ($(window).scrollTop() >= ($('#home').height() / 2)) {
            $('#jHeader').addClass('fixed');
        } else {
            $('#jHeader').removeClass('fixed');
        }
    });
});