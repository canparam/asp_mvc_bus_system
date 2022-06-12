

$(document).ready(function () {

    $('#pickNumber').select2({
        tags: true,
        placeholder: "Select or Input",
    });

    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'OrderInfo':
                Account.OrderInfo(this);
                break;
            case 'CancelOrder':
                Account.CancelOrder(this);
                break;
    

            default:
        }
    });

    $(this).on('change', '*[data-change]', function (e) {
        let func = $(this).data('change');
        switch (func) {
            case 'selectPhone':
                Ticket.selectPhone(this)
                break;


            default:
        }
    });

    $(this).on('keyup', '*[data-keyup]', function (e) {
        let func = $(this).data('keyup');
        switch (func) {
            case 'changeInputNameAuto':

                break;

            default:
        }
    });
});
const Account = {
    config: {

    },
    OrderInfo: function (elem) {
        let _id = $(elem).data("id");
        let modal = $('#infoModal');
        $.ajax({
            type: 'get',
            url: '/user/order/' + _id,
            beforeSend: function () {
                Common.loading.show();
                
            },
            success: function (result) {
                if (result.status == true) {
                    modal.find('.modal-body').empty();
                    modal.find('.modal-body').append(result.data);

                    modal.modal('show')
                } else {
                   
                }
            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        })
    },
    OrderSubmit: function () {
        var formData = $('#bookingForm').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/ticket/order/create',
            data: formData,
            beforeSend: function () {
                Common.loading.show();
                let validate = ['Address', 'Birthday', 'FullName', 'PhoneNumber'];

                validate.forEach((e, indx) => {
                    $(`.error-${e}`).text('');
                });
            },
            success: function (result) {
                if (result.status == true) {
                    notify("success", "Order Success!")
                    setTimeout(function () {
                        window.location.href = "/user/history";
                    }, 300);
                } else {
                    notify("error", result.message)
                }
            },
            error: function (error) {
                error = error.responseJSON;

                $.each(error, function (index, value) {
                    $(`.error-${value.key}`).text(value.message);
                });

            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        })
    },
    CancelOrder: function (elem) {
        let _id = $(elem).data("id");
        $.ajax({
            type: 'get',
            url: '/user/order/cancel/' + _id,
            beforeSend: function () {
                Common.loading.show();
                
            },
            success: function (result) {
                if (result.status == true) {
                    notify("success", result.message)
                    setTimeout(function () {
                        location.reload();
                    }, 400);
                } else {
                    notify("error", result.message)
                }
            },

            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        })
    }

}