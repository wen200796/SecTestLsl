$.getScript('@Url.Content("~/lib/jquery-validation/dist/jquery.validate.min.js")');
$.getScript('@Url.Content("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js")');
var form = $('form');
form.removeData('validator');
form.removeData('unobtrusiveValidation');
$.validator.unobtrusive.parse(form);