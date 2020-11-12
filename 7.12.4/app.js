$(function () {
    $("button").click(function (event) {
        var elem = $(this.parentNode.childNodes[6]);
        var targetChildren = event.target.parentNode.childNodes;
        targetChildren.forEach(
            function (currentValue) {
                console.log(currentValue)
               // if (currentValue.classList[0] == "dropdown-content") {
                 //   elem = currentValue;
                //}
                }
        );
        $(".fa-angle-up").addClass("fa-angle-down");
        $(".fa-angle-up").removeClass("fa-angle-up");
        if (elem.hasClass("active")) {
            $(elem).toggle();
            $(elem).removeClass("active");
            $(this).removeClass("fa-angle-up");
            $(this).addClass("fa-angle-down");
        } else {
            $(".active").toggle();
            $(".active").removeClass("active");

            $(elem).addClass("active");
            $(elem).show();
            $(this).removeClass("fa-angle-down");
            $(this).addClass("fa-angle-up");

        }
    })
});


$(function () {
    if ($(".header-image").length) {
        $(".header-image").insertAfter(".header-container");
    }
})

$('document').ready(function () {
    var end = Math.floor((new Date("09/11/2020")).getTime() / 1000);
    var start = Math.floor((new Date("10/23/2020")).getTime() / 1000);
    var now = Math.floor((new Date).getTime() / 1000);
    $('.countdown').final_countdown({
        'start': start,
        'end': end,
        'now': now

    });
});