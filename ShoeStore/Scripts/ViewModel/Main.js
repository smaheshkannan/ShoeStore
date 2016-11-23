; $(function () {
    Model = new function () {
        var self = this;
        self.Main = new function () {
            var self = this;
            self.GetIssues = function () {
                var url = window.baseUrl + "Issue/Index";
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };
            self.ReportIssue = function () {
                var url = window.baseUrl + "Issue/ReportIssue";
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };
            self.GetAllShoes = function () {
                var url = window.baseUrl + "Home/AllShoes";
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };
            self.GetMonthShoes = function (month) {
                var url = window.baseUrl + "Home/MonthShoe/" + month;
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };
            self.GetBrandShoes = function (brand) {
                var url = window.baseUrl + "Home/BrandShoe/" + brand;
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };
            self.GetProblemDefinition = function () {
                var url = window.baseUrl + "Home/ProblemDefinition";
                Helper.ServiceHelper.LoadPartialView(url, "#MainContainer", {});
            };

            self.ApplyPromoCode = function () {
                var url = window.baseUrl + "Home/PromoCode/" + $('#promo_code_input').val();
                Helper.ServiceHelper.GetMessage(url, "#flash", {});
            };

            self.Subscribe = function () {
                var url = window.baseUrl + "Home/Subscribe/" + encodeURIComponent($('#remind_email_input').val()) + "/";
                Helper.ServiceHelper.GetMessage(url, "#flash", {});
            };
            self.Home = function () {
                window.location = window.baseUrl;
            };
        };
    };
});