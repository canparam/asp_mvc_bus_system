$(document).ready(function () {

    $('#pickNumber').select2({
        tags: true,
        placeholder: "Select or Input",
    });

    $(this).on('click', '*[data-click]', function (e) {
        let func = $(this).data('click');

        switch (func) {
            case 'StepOrderOne':
                Ticket.StepOrderOne(this);
                break;
            case 'OrderSubmit':
                Ticket.OrderSubmit(this);
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
            case 'changeBirtday':
                Ticket.changeBirtday(this)
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
const Ticket = {
    config: {

    },
    selectPhone: function (elem) {
        let phone = $(elem).val();
        let _form = $("#bookingForm");
        $.ajax({
            type: 'GET',
            url: '/ticket/custom-detail/' + phone,
            beforeSend: function () {
                Common.loading.show();
            },
            success: function (result) {
                if (result.status == true) {
                    $("#app_discount").empty();
                    if (result.data != null) {
                        let birth = moment(result.data.birthday).format('YYYY-MM-DD');
                        let age = moment().diff(birth, 'years', false);

                        if (age <= 5) {
                            $("#app_discount").append(
                                `<span class="list-group-item d-flex justify-content-between">Under 5 years old <span> - 100% </span></span>`
                            );
                            let amount = price - (price * (100 * 0.01));
                            $('#amount').text(` ${amount} USD`)


                        } else if (age > 5 && age <= 12) {
                            $("#app_discount").append(
                                `<span class="list-group-item d-flex justify-content-between">Under 12 years old <span> - 50% </span></span>`
                            );
                            let amount = price - (price * (50 * 0.01));
                            $('#amount').text(` ${amount} USD`)

                        } else if (age >= 50) {
                            $("#app_discount").append(
                                `<span class="list-group-item d-flex justify-content-between">Over 50 years old <span> - 30% </span></span>`
                            );
                            let amount = price - (price * (30 * 0.01));
                            $('#amount').text(` ${amount} USD`)

                        } else {
                            $('#amount').text(` ${price} USD`)

                        }
                        
                        _form.find(`input[name="FullName"]`).val(result.data.fullName)
                        _form.find(`input[name="Address"]`).val(result.data.address)
                        _form.find(`input[name="Email"]`).val(result.data.email)
                        _form.find(`input[name="Birthday"]`).val(birth)
                    } else {
                        _form.find(`input[name="FullName"]`).val('')
                        _form.find(`input[name="Address"]`).val('')
                        _form.find(`input[name="Email"]`).val('')
                        _form.find(`input[name="Birthday"]`).val('')
                    }
                }
            },
            complete: function () {
                setTimeout(function () {
                    Common.loading.hide();
                }, 200);
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
                    },300);
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
    changeBirtday: function (elem) {
        let br = $(elem).val();
        Common.loading.show();

        let birth = moment(br).format('YYYY-MM-DD');
        let age = moment().diff(birth, 'years', false);
        $("#app_discount").empty();

        if (age <= 5) {
            $("#app_discount").append(
                `<span class="list-group-item d-flex justify-content-between">Under 5 years old <span> - 100% </span></span>`
            );
            let amount = price - (price * (100 * 0.01));
            $('#amount').text(` ${amount} USD`)

        } else if (age > 5 && age <= 12) {
            $("#app_discount").append(
                `<span class="list-group-item d-flex justify-content-between">Under 12 years old <span> - 50% </span></span>`
            );
            let amount = price - (price * (50 * 0.01));
            $('#amount').text(` ${amount} USD`)
        } else if (age >= 50) {
            $("#app_discount").append(
                `<span class="list-group-item d-flex justify-content-between">Over 50 years old <span> - 30% </span></span>`
            );
            let amount = price - (price * (30 * 0.01));
            $('#amount').text(` ${amount} USD`)
        } else {
            $('#amount').text(` ${price} USD`)
        }
        setTimeout(function () {
            Common.loading.hide();
        },200)

    }


}