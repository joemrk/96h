$(function () {

    let communication = '.communications-wrap';
    let company = '.company-wrap';
    let valid = false;
    let loadFlag = true;

    $('#search_text').on('input', function (e) {
        let $this = $(this);

        if ($this.val().match(/\d{8}/) !== null) {
            $this.css('box-shadow', ' 0px 3px 0px 0px rgba(60,207,89,1)');
            valid = true;
        } else {
            $this.css('box-shadow', ' 0px 3px 0px 0px rgba(222,80,80,1)');
            valid = false;
        }
    });
    //$('#search_text').on('blur', function () { $(this).css('box-shadow', 'none'); });

    $('#communications_search_btn').on('click', function () {
        if (loadFlag && valid) {
            loadFlag = false;
            let searchString = $('#search_text').val();
            getCommunication('/communications/', searchString, communication);
        }
    });
    $('#company_search_btn').on('click', function () {
        if (loadFlag && valid) {
            loadFlag = false;
            let searchString = $('#search_text').val();
            getCommunication('/company/', searchString, company);
        }
    });

    $('.communications-wrap').on('click', '.child-linc', function () {
        let edrpou = $(this).data('edrpou');
        getCommunication('/communications/', edrpou, communication);
    });

    function getCommunication(method, edrpou, selector) {
        $.get(method + edrpou, function (data) {
            $(selector).html($(data).find(selector));
            loadFlag = true;
        });
    }
});