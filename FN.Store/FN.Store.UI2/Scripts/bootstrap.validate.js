$.validator.setDefaults({

    highlight: function (element) {
        $(element)
            .closest('.form-group')
            .find('input, label, select, testarea, span')
            .addClass('is-invalid')
    },

    unhighlight: function (element) {
        $(element)
            .closest('.form-group')
            .find('input, label, select, testarea, span')
            .removeClass('is-invalid')
    },
})