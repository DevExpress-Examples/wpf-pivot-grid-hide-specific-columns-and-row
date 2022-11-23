Imports System.Globalization
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports Microsoft.VisualBasic

Namespace WpfApp
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			PivotHelper.FillPivot(PivotGrid)
			PivotGrid.DataSource = PivotHelper.GetDataTable()
			PivotGrid.BestFit()
		End Sub

		' Handles the CustomFieldValueCells event to remove specific rows
		Protected Sub pivotGrid_CustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
			Dim pivot As PivotGridControl = CType(sender, PivotGridControl)
			If pivot.DataSource Is Nothing Then
				Return
			End If
			If radioListBoxEdit.SelectedIndex = 0 Then
				Return
			End If

			' Iterates through all row headers.
			For i As Integer = e.GetCellCount(False) - 1 To 0 Step -1
				Dim cell As FieldValueCell = e.GetCell(False, i)
				If cell Is Nothing Then
					Continue For
				End If

				' If the current header corresponds to the "Employee B"
				' field value, and is not the Total Row header,
				' it is removed with all corresponding rows.
				If Object.Equals(cell.Value, "Employee B") AndAlso cell.ValueType <> FieldValueType.Total Then
					e.Remove(cell)
				End If
			Next i
		End Sub
		Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
			Dim pivot As PivotGridControl = CType(sender, PivotGridControl)
            If e.Field Is pivot.Fields(PivotHelper.Month) Then
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(CInt(Fix(e.Value)))
            End If
        End Sub
		Private Sub radioListBoxEdit_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			PivotGrid.LayoutChanged()
		End Sub
	End Class
End Namespace
