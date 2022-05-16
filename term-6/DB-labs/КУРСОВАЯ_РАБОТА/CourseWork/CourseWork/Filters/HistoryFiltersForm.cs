using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetShop.Models.Entities;
using SweetShop.Models.Filters;

namespace CourseWork.Filters
{
    public partial class HistoryFiltersForm : Form
    {
        public HistoryFilter Filter { get; }
        public List<Warehouse> Stores { get; }
        public List<HistoryType> HistoryTypes { get; }

        public HistoryFiltersForm()
        {
            InitializeComponent();
        }

        public HistoryFiltersForm(
            HistoryFilter filter,
            List<Warehouse> stores,
            List<HistoryType> historyTypes
            )
            :this()
        {
            Filter = filter;
            Stores = stores;
            HistoryTypes = historyTypes;
        }
        private void HistoryFilters_Load(object sender, EventArgs e)
        {
            InitPresenter();
            UpdatePresenter();
        }

        private void InitPresenter()
        {
            from_dateTimePicker.MinDate = DateTime.MinValue;
            from_dateTimePicker.MaxDate = DateTime.MaxValue;
            to_dateTimePicker.MinDate = DateTime.MinValue;
            to_dateTimePicker.MaxDate = DateTime.MaxValue;
            from_dateTimePicker.Value = DateTime.Parse("2002-05-14 00:00:00.000");
            to_dateTimePicker.Value = DateTime.UtcNow;
            orderBy_comboBox.SelectedIndex = 0;

            stores_checkedListBox.DataSource = Stores;
            types_checkedListBox.DataSource = HistoryTypes;
            stores_checkedListBox.DisplayMember = "Name";
            stores_checkedListBox.ValueMember = "Id";
            types_checkedListBox.DisplayMember = "Name";
            types_checkedListBox.ValueMember = "Id";
            for (int i = 0; i < types_checkedListBox.Items.Count; i++)
            {
                types_checkedListBox.SetItemChecked(i, false);
            }
            for (int i = 0; i < stores_checkedListBox.Items.Count; i++)
            {
                stores_checkedListBox.SetItemChecked(i, false);
            }
            //foreach (var checkedItem in stores_checkedListBox.CheckedItems)
        }

        private void UpdatePresenter()
        {
            if(Filter.FromDate.HasValue)  
                from_dateTimePicker.Value = Filter.FromDate.Value;
            if(Filter.ToDate.HasValue)  
                to_dateTimePicker.Value = Filter.ToDate.Value;
            orderBy_comboBox.SelectedIndex = Filter.IsDescending ? 0 : 1;
            if (Filter.SelectedStores.Any())
                for (int i = 0; i < stores_checkedListBox.Items.Count; i++)
                if(Filter.SelectedStores.Contains(((Warehouse)stores_checkedListBox.Items[i]).Id))
                    stores_checkedListBox.SetItemChecked(i, true);
            if (Filter.SelectedTypes.Any())
                for (int i = 0; i < types_checkedListBox.Items.Count; i++)
                    if (Filter.SelectedTypes.Contains(((HistoryType)types_checkedListBox.Items[i]).Id))
                        types_checkedListBox.SetItemChecked(i, true);
        }

        private void UpdateSource()
        {
            Filter.FromDate = from_dateTimePicker.Value;
            Filter.ToDate = to_dateTimePicker.Value;
            Filter.IsDescending = orderBy_comboBox.SelectedIndex == 0;
            Filter.SelectedTypes.Clear();
            Filter.SelectedStores.Clear();
            for (int i = 0; i < types_checkedListBox.CheckedItems.Count; i++)
            {
                var historyType = (HistoryType) types_checkedListBox.CheckedItems[i];
                Filter.SelectedTypes.Add(historyType.Id);
            }
            for (int i = 0; i < stores_checkedListBox.CheckedItems.Count; i++)
            {
                Filter.SelectedStores.Add(((Warehouse)stores_checkedListBox.CheckedItems[i]).Id);
            }
            Filter.SelectedTypes = Filter.SelectedTypes.ToHashSet().ToList();
            Filter.SelectedStores = Filter.SelectedStores.ToHashSet().ToList();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            InitPresenter();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            UpdateSource();
            this.Close();
        }
    }
}
