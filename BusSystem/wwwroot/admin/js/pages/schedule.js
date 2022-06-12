$(document).ready(function () {

    $('.js-from-create').select2({
        placeholder: "Select",
        allowClear: true,
        ajax: {
            url: function (term) {
                let param = term.term || "Hà Nội";
                return `https://places.ls.hereapi.com/places/v1/autosuggest?at=21.02889,105.85464&q=${param}&lang=vn&apiKey=${Common.config.HERE_API_KEY}`;
            },
            dataType: 'json',
            type: "GET",

            processResults: function (data) {
                return {
                    results: $.map(data.results, function (item) {
                        return {
                            text: item.title ,
                            id: item.title ,
                        }
                    })
                };
            }

        },
    });
    $('.js-to-create').select2({
        placeholder: "Select",
        allowClear: true,
        ajax: {
            url: function (term) {
                let param = term.term || "Hà Nội";
                return `https://places.ls.hereapi.com/places/v1/autosuggest?at=21.02889,105.85464&q=${param}&lang=vn&apiKey=${Common.config.HERE_API_KEY}`;
            },
            dataType: 'json',
            type: "GET",

            processResults: function (data) {
                return {
                    results: $.map(data.results, function (item) {
                        return {
                            text: item.title ,
                            id: item.title,
                        }
                    })
                };
            }

        },
    });
   
    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'createSch':
                Schedule.createSch(this);
                break;
            case 'modalEdit':
                Schedule.modalEdit(this);
                break;
            case 'updateSchedule':
                Schedule.updateSchedule(this)
                break;
            case 'createSchTime':
                Schedule.createSchTime();
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
    flatpickr("#StartTime", {
        enableTime: true,
        dateFormat: "Y-m-d H:i",
    });

});
function removeBr(value) {
    return value.replace("<br/>", " ");
}
function loadEdit() {
    $('.js-to-modal').select2({
        placeholder: "Select",
        allowClear: true,
        dropdownParent: "#modal_editSchedule",
        ajax: {
            url: function (term) {
                let param = term.term || "Hà Nội";
                return `https://places.ls.hereapi.com/places/v1/autosuggest?at=21.02889,105.85464&q=${param}&lang=vn&apiKey=${Common.config.HERE_API_KEY}`;
            },
            dataType: 'json',
            type: "GET",

            processResults: function (data) {
                return {
                    results: $.map(data.results, function (item) {
                        return {
                            text: item.title,
                            id: item.title ,
                        }
                    })
                };
            }

        },
    });
    $('.js-from-modal').select2({
        placeholder: "Select",
        allowClear: true,
        dropdownParent: "#modal_editSchedule",
        ajax: {
            url: function (term) {
                let param = term.term || "Hà Nội";
                return `https://places.ls.hereapi.com/places/v1/autosuggest?at=21.02889,105.85464&q=${param}&lang=vn&apiKey=${Common.config.HERE_API_KEY}`;
            },
            dataType: 'json',
            type: "GET",

            processResults: function (data) {
                return {
                    results: $.map(data.results, function (item) {
                        return {
                            text: item.title + " - " + removeBr(item.vicinity),
                            id: item.title + " - " + removeBr(item.vicinity),
                        }
                    })
                };
            }

        },
    });
}
const Schedule = {
    config: {

    },
    createSch: function (elem) {
        var formData = $('#form_schedule').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});
        $.ajax({
            type: 'POST',
            url: '/admin/schedule',
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
                let validate = ['From', 'To','Status'];

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
    modalEdit: function (elem) {
        let _id = $(elem).data("id");
        let modal = $("#modal_editSchedule");
        $.ajax({
            type: 'GET',
            url: '/admin/schedule/' + _id,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {

                    $('.js-from-modal').append(` <option value="${result.data.from}" selected>${result.data.from}</option>`);
                    $('.js-to-modal').append(` <option value="${result.data.to}"selected>${result.data.to}</option>`);
                    modal.find("#inputState").val(result.data.status);
                    modal.find("#btn_update").attr("data-id", result.data.id);
                    loadEdit();
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
    updateSchedule: function (elem) {
        let _id = $(elem).data("id");
        let modal = $("#modal_editSchedule");
        var formData = modal.find('#form_update').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});
 
        $.ajax({
            type: 'PUT',
            url: '/admin/schedule/' + _id,
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
                let validate = ['From', 'To', 'Status'];

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
    },
    createSchTime: function () {
        var formData = $('#form_schedule_time').serializeArray().reduce(function (obj, item) {
            obj[item.name] = item.value;
            return obj;
        }, {});
        $.ajax({
            type: 'POST',
            url: '/admin/schedule/time/create',
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
                let validate = ['StartTime', 'Status', 'ScheduleId'];

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
    }

}