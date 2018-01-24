$(document).ready(function () {
    $("#btnRegister").click(function () {
        RegisterCustomer();
    });

    $("#btnLogin").click(function () {
        LoginCustomer();
    });
});

function RegisterCustomer() {
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var email = $("#email").val();
    var phoneNumber = $("#phoneNumber").val();
    var password = $("#password").val();
    var confirmPassword = $("#confirmPassword");

    $.ajax({
        method: "POST",
        url: "../Home/RegisterCustomer",
        data: {
            firstName: firstName,
            lastName: lastName,
            email: email,
            phoneNumber: phoneNumber,
            password: password
        }
    })
        .done(function (response) {
            alert(response);
            if (response === "success")
            alert("Login Successful");
        else
            alert("Login Failed: " + response);
    });
}

function LoginCustomer() {
    var userName = $("#userName").val();
    var loginPassword = $("#loginPassword").val();

    $.ajax({
        method: "POST",
        url: "../Home/LoginCustomer",
        data: {
            userName: userName,
            loginPassword: loginPassword
        }
    })
        .done(function (response) {
            alert(response);
    });
}