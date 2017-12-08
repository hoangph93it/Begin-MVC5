﻿/// <reference path="../jquery-3.2.1.js" />
/// <reference path="../jquery.toast.js" />
$(document).ready(function () {
    loadEmployees();
})
//loal list employees
function loadEmployees() {
    $.ajax({
        url: "/Employees/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function myfunction(key, item) {
                html += '<tr>';
                html += '<td>' + item.EmployeeID + '</td>';
                html += '<td>' + item.Name + '</td>';
                html += '<td>' + item.DOB + '</td>';
                html += '<td>' + item.Gender + '</td>';
                html += '<td>' + item.StartDate + '</td>';
                html += '<td>' + item.EndDate + '</td>';
                html += '<td>' + item.DepartmentID + '</td>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            $.toast({
                heading: 'Thông báo',
                text: 'Có lỗi xảy ra trong quá trình xử lý!',
                showHideTransition: 'fade',
                icon: 'error',
                position: 'top-right'
            })
        }
    })
}
//Add employees
function insertEmployees() {
    var res = validate();
    if (res == false) {
        return false;
    }
    debugger
    var empObj = {
        EmployeeID: $('#EmployeeID').val(),
        Name: $('#Name').val(),
        DOB: $('#DOB').val(),
        Gender: $('#Gender').val(),
        StartDate: $('#StartDate').val(),
        EndDate: $('#EndDate').val(),
        DepartmentID: $('#DepartmentID').val()
    };
    debugger
    $.ajax({
        url: '/Employees/Add',
        data: JSON.stringify(empObj),
        type: 'POST',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadEmployees();
            $('#modal_employees').modal('hide');
            $.toast({
                heading: 'Thông báo',
                text: 'Thêm mới nhân viên thành công!',
                showHideTransition: 'fade',
                icon: 'success',
                position: 'top-right'
            })
        },
        error: function (errormessage) {
            $.toast({
                heading: 'Thông báo',
                text: 'Có lỗi xảy ra trong quá trình xử lý!',
                showHideTransition: 'fade',
                icon: 'error',
                position: 'top-right'
            })
        }
    })
}
//Valdidation using jquery
function validate() {
    var isValid = true;
    if ($('#EmployeeID').val() == "") {
        $('#EmployeeID').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#EmployeeID').css('border-color', 'lightgrey');
    }
    if ($('#Name').val() == "" ) {
        $('#Name').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Name').css('border-color', 'lightgrey');
    }
    if ($('#DOB').val() ==  "") {
        $('#DOB').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#DOB').css('border-color', 'lightgrey');
    }
    if ($('#Gender').val() == "" ) {
        $('#Gender').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Gender').css('border-color', 'lightgrey');
    }
    if ($('#StartDate').val() ==  "") {
        $('#StartDate').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#StartDate').css('border-color', 'lightgrey');
    }
    if ($('#EndDate').val() =="" ) {
        $('#EndDate').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#EndDate').css('border-color', 'lightgrey');
    }
    if ($('#DepartmentID').val() == "" ) {
        $('#DepartmentID').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#DepartmentID').css('border-color', 'lightgrey');
    }
    return isValid;
}