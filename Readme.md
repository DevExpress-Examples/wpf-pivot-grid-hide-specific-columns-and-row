<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/569353530/22.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1129418)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WPF - How to Hide Specific Rows and Columns

The following example demonstrates how handle the [CustomFieldValueCells](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CustomFieldValueCells) event to hide specific rows and columns. In this example, the event handler iterates through all row headers and removes rows that correspond to the "Employee B" field value, and that are not Total Rows.

![Pivot Grid](images/pivotgrid.png)

## Files to Review

* [Data.cs](./CS/WpfApp/Data.cs) (VB: [Data.vb](./VB/WpfApp/Data.vb))
* [MainWindow.xaml](./CS/WpfApp/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApp/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApp/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApp/MainWindow.xaml.vb))

## More Examples 

- [Pivot Grid for WinForms - How to Hide Specific Rows and Columns](https://github.com/DevExpress-Examples/winforms-pivot-grid-hide-specific-columns-and-rows)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-hide-specific-columns-and-row&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-hide-specific-columns-and-row&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
