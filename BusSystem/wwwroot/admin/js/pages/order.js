$(document).ready(function () {


    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'GetDetail':
                Order.GetDetail(this);
                break;
            case 'EditOrder':
                Order.EditOrder(this);
                break;

            default:
        }
    });

    $(this).on('change', '*[data-change]', function (e) {
        let func = $(this).data('change');
        switch (func) {
            case 'changeStatusAuto':

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
const Order = {
    config: {

    },
    GetDetail: function (elem) {
        let _id = $(elem).data("id");
        let modal = $('#modalDetail');
        $.ajax({
            type: 'get',
            url: '/admin/order/' + _id,
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
    EditOrder: function (elem) {
        let _id = $(elem).data("id");
    }

}