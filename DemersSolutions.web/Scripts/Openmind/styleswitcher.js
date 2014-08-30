
if ($.cookie("color")) {
    $("link[id='default-color']").attr("href", cssPath + $.cookie("color"));
}

if($.cookie("width")) {
    $("link[id='default-width']").attr("href", cssPath + $.cookie("width"));
}

$(document).ready(function() { 
    $("#color-switcher-content .color").click(function () {
        $("link[id='default-style']").attr("href", cssPath + $(this).attr('rel'));
        $.cookie("color",$(this).attr('rel'), {expires: 7, path: '/'});
        return false;
    });

    $("#color-switcher-content .option").click(function () {
        $("link[id='default-width']").attr("href", cssPath + $(this).attr('rel'));
        //console.log('test');
        $.cookie("width",$(this).attr('rel'), {expires: 7, path: '/'});
        return false;
    });
});