function contactViewModel() {
    var self = this;

    self.name = ko.observable('');
    self.streetNumber = ko.observable('');
    self.city = ko.observable('');
    self.state = ko.observable('');
    self.zip = ko.observable('');
    self.phone = ko.observable('');
    self.email = ko.observable('');
    self.message = ko.observable('');

    self.validationMessage = ko.observable();

    self.submit = function () {
        if (!isValid()) {
            return;
        }
        $.ajax({
            type: "POST",
            url: baseUri,
            data: ko.toJSON(self),
            contentType: 'application/json',
            success: function (result) {
                if (!result.Success) {
                    var errorMessages = '';
                    for (var i = 0; i < result.Errors.length; i++) {
                        errorMessages += result.Errors[i];
                    }
                    alert(errorMessages);
                } else {
                    alert(result.Model);
                    clearFormFields();
                }
            },
            error: function (ex) {
                alert(ex.message);
            }
        });
    };
    function isValid() {
        var returnValue = true;
        var validationMessage = '';

        if (!self.name()) {
            validationMessage += 'Name is required. ';
        }
        if (!self.message()) {
            validationMessage += 'Message is required. ';
        }
        if (!self.email() && !self.phone()) {
            validationMessage += 'Either an email address or a phone is required. ';
        }

        self.validationMessage(validationMessage);
        if (validationMessage) {
            returnValue = false;
        }
        return returnValue;
    }
    function clearFormFields() {
        self.name('');
        self.streetNumber('');
        self.city('');
        self.state('');
        self.zip('');
        self.phone('');
        self.email('');
        self.message('');
    }
}

ko.applyBindings(new contactViewModel(), $('#contactUsForm')[0]);