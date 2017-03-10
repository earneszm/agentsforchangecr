//var didScroll;
//var lastScrollTop = 0;
//var delta = 5;
//var navbarHeight = $('header').outerHeight();

//$(window).scroll(function () {
//    didScroll = true;
//    if ($(document).scrollTop() > 50) {
//        $('.navbar').addClass('shrink');
//    } else {
//        $('.navbar').removeClass('shrink');
//    }

//    function elementScrolled(elem) {
//        var docViewTop = $(window).scrollTop();
//        var docViewBottom = docViewTop + $(window).height();
//        var elemTop = $(elem).offset().top;
//        return ((elemTop <= docViewBottom) && (elemTop >= docViewTop));
//    }

//    // This is where we use the function to detect if ".box2" is scrolled into view, and when it is add the class ".animated" to the <p> child element
//    if (elementScrolled('.gaugeContainer')) {

//        // 180 degress = 100%
//        var value = (72 / 100) * 180;
//        $('#rotationGauge').css('transform', 'rotate(' + value +'deg)');
//        // Your function here

//    }
//});

//function hasScrolled() {
//    var st = $(this).scrollTop();
    
//    // Make sure they scroll more than delta
//    if(Math.abs(lastScrollTop - st) <= delta)
//        return;
    
//    // If they scrolled down and are past the navbar, add class .nav-up.
//    // This is necessary so you never see what is "behind" the navbar.
//    if (st > lastScrollTop && st > navbarHeight){
//        // Scroll Down
//        $('header').removeClass('nav-down').addClass('nav-up');
//    } else {
//        // Scroll Up
//        if(st + $(window).height() < $(document).height()) {
//            $('header').removeClass('nav-up').addClass('nav-down');
//        }
//    }
    
//    lastScrollTop = st;
//}




window.onload = function () {
        $('.afc-textbox-required').change(function () {
            $(this).removeClass("afc-validation-failed");
        });
}


















//originally from http://stackoverflow.com/questions/149055/how-can-i-format-numbers-as-money-in-javascript
function formatCurrency(n, c, d, t) {
    "use strict";

    var s, i, j;

    c = isNaN(c = Math.abs(c)) ? 2 : c;
    d = d === undefined ? "." : d;
    t = t === undefined ? "," : t;

    s = n < 0 ? "-" : "";
    i = parseInt(n = Math.abs(+n || 0).toFixed(c), 10) + "";
    j = (j = i.length) > 3 ? j % 3 : 0;

    return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
}

/**
 * Thermometer Progress meter.
 * This function will update the progress element in the "thermometer"
 * to the updated percentage.
 * If no parameters are passed in it will read them from the DOM
 *
 * @param {Number} goalAmount The Goal amount, this represents the 100% mark
 * @param {Number} progressAmount The progress amount is the current amount
 * @param {Boolean} animate Whether to animate the height or not
 *
 */
function thermometer(goalAmount, progressAmount, animate) {
    "use strict";

    var $thermo = $(".thermometer"),
        $progress = $(".progress", $thermo),
        $goal = $(".goal", $thermo),
        percentageAmount;

    goalAmount = goalAmount || parseFloat($goal.text()),
    progressAmount = progressAmount || parseFloat($progress.text()),
    percentageAmount = Math.min(Math.round(progressAmount / goalAmount * 1000) / 10, 100); //make sure we have 1 decimal point

    //let's format the numbers and put them back in the DOM
    $goal.find(".amount").text("$" + formatCurrency(goalAmount));
    $progress.find(".amount").text("$" + formatCurrency(progressAmount));

    var textProgressAmount = $('.textProgressAmount');
    var textGoalHeader = $('#goalProgress')
    textProgressAmount.text("$" + formatCurrency(progressAmount));

    textGoalHeader.html(percentageAmount + '%');



    //let's set the progress indicator
    $progress.find(".amount").show();
    if (animate !== false) {
        $progress.animate({
            "height": percentageAmount + "%"
        }, 1200, function () {
            var test = $(this).find(".amount");
            $(this).find(".amount").fadeIn("slow");
        });
    }
    else {
        $progress.css({
            "height": percentageAmount + "%"
        });
        $progress.find(".amount").fadeIn(500);
    }
}

$(document).ready(function () {

    //call without the parameters to have it read from the DOM
    thermometer(1000, 500, true);
    // or with parameters if you want to update it using JavaScript.
    // you can update it live, and choose whether to show the animation
    // (which you might not if the updates are relatively small)
    //thermometer( 1000000, 425610, false );

});
