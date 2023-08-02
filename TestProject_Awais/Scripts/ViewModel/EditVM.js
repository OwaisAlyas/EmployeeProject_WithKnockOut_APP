$(function () {
    var initialData = '@Html.Raw(ViewBag.InitialData)';

    ko.applyBindings(EditVM);
    EditVM.getDepartment();
    EditVM.getLocation();
    debugger
    //var parsedJSON = $.parseJSON(initialData); //parse the json client side
    debugger
});

//
var EditVM = {
    Department: ko.observableArray([]),
    Location: ko.observableArray([]),
    //EmployeeNo: ko.observable(),
    //FullName: ko.observable(),
    //LocationName: ko.observable(),
    //DepartmentName: ko.observable(),
    //DepartmentID: ko.observable(),
    UpdateEmployee: function (data) {
        debugger
        var employee = {};
        var employeeNo = $('#employeeNo').val();
        if (employeeNo == null || employeeNo == "" || employeeNo == undefined) {
            alert("employeeNo Required");
            return null;
        }
        var fullName = $('#fullName').val();
        if (fullName == null || fullName == "" || fullName == undefined) {
            alert("Full Name Required");
            return null;
        }
        var Department = $('#DepartmentList').val();
        if (Department == null || Department == "" || Department == undefined) {
            alert("Department Required");
            return null;
        }
        var location = $('#LocationList').val();
        if (location == null || location == "" || location == undefined) {
            alert("location Required");
            return null;
        }

        employee.locationId = $('#LocationList').val();
        employee.departmentId = $('#DepartmentList').val();
        employee.employeeNo = $('#employeeNo').val();
        employee.fullName = $('#fullName').val();
        employee.id = $('#employeeId').val();

        debugger
        $.ajax({
            type: "post",
            url: "/Employee/UpdateEmployee",
            data: employee,
            datatype: "json",
            cache: false,
            success: function (data) {
                alert("Data Updated Successfully");
                window.location.href = '/Employee/Index/'
            },
            error: function (xhr) {
                debugger
                alert('No Valid Data');
            }
        });
    },
    getDepartment: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: '/Department/GetDepartment',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Department(data); //Put the response in ObservableArray  
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    },
    getLocation: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: '/Location/GetLocation',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Location(data); //Put the response in ObservableArray  
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    },
};
