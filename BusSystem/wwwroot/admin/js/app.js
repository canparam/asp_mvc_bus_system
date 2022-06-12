

const Common = {
    config: {
        HERE_API_KEY: "yfv8RqwfnTqHjK1hHH_zX1gemwAJ5XDNdvnut2_MjpA"
    },
    loading: {
        show: function () {
            $loading = $('#loading').addClass('d-block');;

        },
        hide: function () {
            $loading = $('#loading').removeClass('d-block');

        },
       
    },
    htmlEncode: function (html) {
        html = $.trim(html);
        // /[&"'\<\>]/g
        return html.replace(/[&"'\<\>]/g, function (c) {
            switch (c) {
                case "&":
                    return "&amp;";
                case "'":
                    return "&#39;";
                case '"':
                    return "&quot;";
                case "<":
                    return "&lt;";
                default:
                    return "&gt;";
            }
        });
    },
};