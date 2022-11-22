using DevExpress.Xpf.Editors;
using DevExpress.Xpf.PivotGrid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            PivotHelper.FillPivot(PivotGrid);
            PivotGrid.DataSource = PivotHelper.GetDataTable();
            PivotGrid.BestFit();
        }

        // Handles the CustomFieldValueCells event to remove specific rows
        protected void pivotGrid_CustomFieldValueCells(object sender, PivotCustomFieldValueCellsEventArgs e) {
            PivotGridControl pivot = (PivotGridControl)sender;
            if (pivot.DataSource == null) return;
            if (radioListBoxEdit.SelectedIndex == 0) return;

            // Iterates through all row headers.
            for (int i = e.GetCellCount(false) - 1; i >= 0; i--) {
                FieldValueCell cell = e.GetCell(false, i);
                if (cell == null) continue;

                // If the current header corresponds to the "Employee B"
                // field value, and is not the Total Row header,
                // it is removed with all corresponding rows.
                if (object.Equals(cell.Value, "Employee B") &&
                    cell.ValueType != FieldValueType.Total)
                    e.Remove(cell);
            }
        }
        void pivotGrid_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            PivotGridControl pivot = (PivotGridControl)sender;
            if (e.Field == pivot.Fields[PivotHelper.Month]) {
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((int)e.Value);
            }
        }
        private void radioListBoxEdit_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            PivotGrid.LayoutChanged();
        }
    }
}
