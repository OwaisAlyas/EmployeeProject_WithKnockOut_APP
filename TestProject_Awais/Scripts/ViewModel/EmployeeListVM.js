var urlPath = window.location.pathname;
$(function () {
    var myObservableArray = ko.observableArray();
    ko.applyBindings(EmployeeListVM);
    EmployeeListVM.getemployees();
    var myObservableArray = ko.observableArray();    // Initially an empty array
    myObservableArray.push('Some value'); 
    debugger
});
//View Model  
var EmployeeListVM = {
    Employees: ko.observableArray([]),
    getemployees: function () {
        debugger
        var self = this;
        $.ajax({
            type: "GET",
            url: '/Employee/GetEmployees',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Employees(data); //Put the response in ObservableArray  
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    },
};
self.editEmployee = function (employee) {
    debugger
    window.location.href = '/Employee/EditEmployee/' + employee.Id;
};
self.deleteEmployee = function (employee) {
    window.location.href = '/Employee/DeleteEmployee/' + employee.Id;
};
//Model  
function Employees(data) {
    this.Id = ko.observable(data.Id);
    this.EmployeeNo = ko.observable(data.EmployeeNo);
    this.FullName = ko.observable(data.FullName);
    this.LocationId = ko.observable(data.LocationId);
    this.LocationName = ko.observable(data.Location.LocationName);
    this.DepartmentId = ko.observable(data.DepartmentId);
    this.DepartmentName = ko.observable(data.Department.DepartmentName);
} 