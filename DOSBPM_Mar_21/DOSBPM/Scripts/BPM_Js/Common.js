
//$('input[type="checkbox"]').on('change', function () {
//    $('input[type="checkbox"]').not(this).prop('checked', false);
//});
//$('input[type="radio"]').on('change', function () {
//    $('input[type="radio"]').not(this).prop('checked', false);
//});
//required field validaion

var common = (function () {
    var publicMethods = {};

    publicMethods.validate = function (pageId) {
        var isValid = true;
        var page = $("#" + pageId);
        var controls = page.find("[IsRequired=TRUE]");
		var allControls = controls.filter("[type='text'],[type='checkbox'],select");
		var allCheckBoxs = controls.filter(" [type='checkbox']");
        $.each(allControls, function () {
            if ($.trim($(this).val()) === "") {
                isValid = false;
                $(this).addClass("ValidationError");
                $(this).blur(function () {
                    if ($.trim($(this).val()) !== "") {
                        $(this).removeClass("ValidationError");
                    } else {
                        $(this).addClass("ValidationError");
                    }
                });
            } else {
                $(this).removeClass("ValidationError");
            }
		});

		$.each(allCheckBoxs, function () {

		});

        return isValid;
    }

    return publicMethods;
})();