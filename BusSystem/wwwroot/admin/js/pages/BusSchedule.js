$(document).ready(function () {
    $('.js-scheduletime-create').select2({
        placeholder: "Select",
        allowClear: true,

    });

    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'createBusSche':
                BusSchedule.createBusSche()
                break;
            case 'edit':
                BusSchedule.edit(this);
                break;
            case 'submitUpdate':
                BusSchedule.submitUpdate(this);
                break;
            default:
        }
    });

    $(this).on('change', '*[data-change]', function (e) {
        let func = $(this).data('change');
        switch (func) {
            case 'selectSchedule':
                BusSchedule.selectSchedule(this)
                break;
            case 'modal_Sch':
                BusSchedule.modal_Sch(this)
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
function toggleSelect2() {
    $('.js-scheduletime-modal').select2({
        placeholder: "Select",
        allowClear: true,
        dropdownParent: "#modal_busche",
    });
}
const BusSchedule = {
    config: {

    },
    modal_Sch: function (elem) {
        let _id = $(elem).val();
        let modal = $("#modal_busche");
        $.ajax({
            type: 'POST',
            url: '/admin/busschedule/list-time',
            data: {
                id: _id
            },
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    let html = '<option value = "" selected>-- Select --</option >';
                    $.each(result.data, function (index, value) {
                        html += `<option value="${value.id}">${moment(value.startTime).format('YYYY-MM-DD, h:mm:ss a')}</option>`
                    });
                    modal.find("#schedule_time").empty();
                    modal.find("#schedule_time").append(html);

                }
            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 200);
            },
        })
    },
    selectSchedule: function (elem) {
        let _id = $(elem).val();
        let time = $("#schedule_time");
        $.ajax({
            type: 'POST',
            url: '/admin/busschedule/list-time',
            data: {
                id: _id
            },
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    let html = '<option value = "" selected>-- Select --</option >';
                    $.each(result.data, function (index, value) {
                        html += `<option value="${value.id}">${moment(value.startTime).format('YYYY-MM-DD, h:mm:ss a')}</option>`
                    });
                    time.find('select').html(html);
                    
                    time.show();
                }
            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 200);
            },
        })
    },
    createBusSche: function () {
        var formData = $('#form_bussche').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});

        $.ajax({
            type: 'POST',
            url: '/admin/busschedule/create',
            data: formData,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
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
                let validate = ['BusId', 'Price', 'ScheduleId','ScheduleTimeId'];

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
    edit: function (elem) {
        let _id = $(elem).data("id");
        let modal = $("#modal_busche");
        $.ajax({
            type: 'GET',
            url: '/admin/busschedule/detail/' + _id,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    modal.find('.modal-body').empty();
                    modal.find('.modal-body').append(result.data);
                    modal.find("#btn_update").attr("data-id", _id);
                    modal.modal("show")
                }
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
    submitUpdate: function (elem) {
        let modal = $("#modal_busche");
        var formData = modal.find('#form_update').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});
        let _id = $(elem).data("id");

        $.ajax({
            type: 'POST',
            url: '/admin/busschedule/update/' + _id,
            data: formData,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    modal.modal("hide")
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
                let validate = ['BusId', 'Price', 'ScheduleId', 'ScheduleTimeId'];

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