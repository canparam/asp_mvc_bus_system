

const Common = {
    config: {
        HERE_API_KEY: "yfv8RqwfnTqHjK1hHH_zX1gemwAJ5XDNdvnut2_MjpA"
    },
    loading: {
        show: function () {
            $loading = $('.preloader').css("display", "block");

        },
        hide: function () {
            $loading = $('.preloader').css("display", "none");

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