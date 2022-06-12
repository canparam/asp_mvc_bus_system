$(document).ready(function () {
    $('.js-example-basic-multiple').select2({
        placeholder: "Select",
        allowClear: true,
        ajax: {
            url: '/admin/transaction/partner-active',
            dataType: 'json',
            type: "POST",
            data: function (term) {

                return {
                    username: term.term
                };
            },
            processResults: function (data) {
                return {
                    results: $.map(data, function (item) {
                        return {
                            text: item.username + ` (Amount: ${item.amount})`,
                            id: item.id,
                        }
                    })
                };
            }

        }
    });

    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'sendCredit':
                Transactions.sendCredit(this);
                break;
            case 'rollBackCredit':
                Transactions.rollBackCredit(this)
                break;
            case 'updateRollback':
                Transactions.updateRollback(this)
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
const Transactions = {
    config: {

    },
    sendCredit: function () {
        var formData = $('#form_credit').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/admin/transaction/transfer',
            data: formData,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    bootbox.alert({
                        message: "Send Success!",
                        centerVertical: true,
                        callback: function (result) {
                            location.reload();
                        }
                    });
                }
            },
            error: function (error) {
                error = error.responseJSON;
                let validate = ['UserId', 'Credit'];

                validate.forEach((e, indx) => {
                    $(`.error-${e}`).text('');
                });
                $.each(error, function (index, value) {
                    $(`.error-${value.key}`).text(value.message);
                });

            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                },300);
            },
        })
    },
    rollBackCredit: function (elem) {
        let _id = $(elem).data("id");
        let modal = $('#modal_rollback');
        modal.find("#btn_rollback").attr("data-id",_id)
        modal.modal('show')
    },
    updateRollback: function (elem) {
        let _id = $(elem).data("id");
        let reason = $("#reason").val();
        $.ajax({
            type: 'POST',
            url: '/admin/transaction/rollback',
            data: {
                id: _id,
                message: reason
            },
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {


            },
            error: function (error) {

            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        });
    }
}