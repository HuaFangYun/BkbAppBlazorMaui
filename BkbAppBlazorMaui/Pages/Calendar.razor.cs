namespace BkbAppBlazorMaui.Pages
{
    public partial class Calendar
    {
        public DateTime Date { get; set; }

        public int Days { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateTime SelectedDate { get; set; }

        protected override void OnInitialized()
        {
            SelectedDate = DateTime.Today;

            Days = DateTime.DaysInMonth(SelectedDate.Year, SelectedDate.Month);

            Month = SelectedDate.Month;
            Year = SelectedDate.Year;
        }

        protected void PrevMonth()
        {
            Month = Month - 1;

            if (Month == 0)
            {
                Month = 12;
                Year = Year - 1;
            }

            Days = DateTime.DaysInMonth(Year, Month);
        }

        protected void NextMonth()
        {
            Month = Month + 1;

            if (Month == 13)
            {
                Month = 1;
                Year = Year + 1;
            }

            Days = DateTime.DaysInMonth(Year, Month);
        }
    }
}
