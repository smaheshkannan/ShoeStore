; $(function () {
    Helper = new function(){
        var self = this;
        self.ServiceHelper = new function () {
            var self = this;
            self.LoadPartialView = function (url, parent, parameters) {
                $.ajax({
                    type: "get",
                    url: url,
                    success: function (view) {
                        $(parent).html(view);
                    }
                });
            };

            self.GetMessage = function (url, messageContainer, parameters) {
                $.ajax({
                    type: "get",
                    url: url,
                    success: function (data) {
                        if (data && data.result == true) {
                            $(messageContainer).removeClass().addClass('flash flash_success').text(data.message).show().delay(5000).hide(0);
                        }
                        else {
                            $(messageContainer).removeClass().addClass('flash alert_danger').text(data.message).show().delay(5000).hide(0);
                        }
                    }
                });
            };
        };
    };
});