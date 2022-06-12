$(document).ready(function () {


    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'createBus':
                Bus.createBus(this);
                break;
            case 'deleteBus':
                Bus.deleteBus(this)
                break;
            case 'editBus':
                Bus.editBus(this)
                break;
            case 'updateBus':
                Bus.updateBus(this)
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
const Bus = {
    config: {

    },
    createBus: function () {
        var formData = $('#form_bus').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/admin/bus/create',
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
                let validate = ['Quantity', 'Status', 'Name'];

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
    deleteBus: function (elem) {
        let _id = $(elem).data("id");
        bootbox.confirm({
            title: "Notification",
            message: "Are you sure you want to delete the Bus?",
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
    },
    editBus: function (elem) {
        let modal = $("#modal_editBus");
        let _id = $(elem).data("id");
        $.ajax({
            type: 'GET',
            url: '/admin/bus/' + _id,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    modal.find("#full_name").val(result.data.name);
                    modal.find("#modal_quantity").val(result.data.quantity);
                    modal.find("#status").val(result.data.status);
                    modal.find("#btn_update").attr("data-id", result.data.id);
                    modal.modal("show")
                }
            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 200);
            },
        })
        
    },
    updateBus: function (elem) {
        let modal = $("#modal_editBus");

        let _id = $(elem).data("id");
        var formData = modal.find('#form_update').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/admin/bus/update/' + _id,
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
                let validate = ['Name', 'Quantity', 'Status'];

                validate.forEach((e, indx) => {
                    modal.find(`.error-${e}`).text('');
                });
                $.each(error, function (index, value) {
                    modal.find(`.error-${value.key}`).text(value.message);
                });

            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 300);
            },
        })
    }

}