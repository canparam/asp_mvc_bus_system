$(document).ready(function () {
    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'modalEditUser':
                User.modalEditUser(this);
                break;
            case 'updatePartner':
                User.updatePartner(this)
                break;
            case 'deletePartner':
                User.deletePartner(this)
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



const User = {
    config: {

    },
    modalEditUser: function (elem) {
        let id = $(elem).data('id');
        let modal = $('#modal_user_edit');

        let full_name = $('#full_name');
        let username = $('#username');
        let email = $('#email');
        let phonenumber = $('#phonenumber');
        let address = $('#address');
        let status = $('#status');
        let password = $('#password');
        /*Common.loading.show();*/
        $.ajax({
            type: 'POST',
            url: '/admin/partner/detail',
            data: { id: id },
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {

                data = result.data;

                full_name.val(data.fullName);
                email.val(data.email);
                username.val(data.userName);
                phonenumber.val(data.phoneNumber);
                address.val(data.address);
                status.val(data.status);
                modal.find('#btn_update').attr("data-id",id);
                modal.modal('show');
            },
            error: function (error) {

            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        })
    },
    updatePartner: function (elem) {
        let _id = $(elem).data('id');
        let modal = $('#modal_user_edit');
        var formData = $('#form_update').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/admin/partner/update/' + _id,
            data: formData,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    modal.modal('hide');
                    bootbox.alert({
                        message: "Update Success!",
                        centerVertical: true,
                        callback: function (result) {
                            location.reload();
                        }
                    });
                }
            },
            error: function (error) {
                error = error.responseJSON;
                let validate = ['FullName', 'Email', 'PhoneNumber', 'Address', 'Status'];

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
                }, 300);
            },
        })
        
    },
    deletePartner: function (elem) {
        let _id = $(elem).data('id');
        bootbox.confirm({
            title: "Notification",
            message: "Are you sure you want to delete the partner?",
            centerVertical: true,
            buttons: {
                cancel: {
                    label: 'Cancel'
                },
                confirm: {
                    label: ' Confirm'
                }
            },
            callback: function (result) {
                if (result == true) {
                    $.ajax({
                        type: 'DELETE',
                        url: '/admin/partner/del/' + _id,
                        beforeSend: function () {
                            Common.loading.show();
                        },
                        success: function (result) {
                            if (result.status == true) {
                                bootbox.alert({
                                    message: "Delete Success!",
                                    centerVertical: true,
                                    callback: function (result) {
                                        location.reload();
                                    }
                                });
                            }
                        },
                        complete: function () {
                            setTimeout(function () {
                                Common.loading.hide();
                            }, 200);
                        },
                    })
                }
            }
        });
    }
};

