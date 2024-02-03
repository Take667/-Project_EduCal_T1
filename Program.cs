using System;
using System.Globalization;
using System.Windows;

namespace DesktopCalendar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Attach an event handler to the SelectedDatesChanged event of the Calendar control
            calendar.SelectedDatesChanged += Calendar_SelectedDatesChanged;

            // Set the initial text for the selected date
            UpdateSelectedDateText(calendar.SelectedDate);
        }

        private void Calendar_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle the SelectedDatesChanged event
            DateTime? selectedDate = calendar.SelectedDate;
            UpdateSelectedDateText(selectedDate);
        }

        private void UpdateSelectedDateText(DateTime? selectedDate)
        {
            // Update the TextBlock with the selected date
            if (selectedDate.HasValue)
            {
                selectedDateText.Text = $"Selected Date: {selectedDate:MM/dd/yyyy}";
            }
            else
            {
                selectedDateText.Text = "No Date Selected";
            }
        }
    }
}
