using SearchHandlerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerDemo.SearchHandlers
{
    public class StudentSearchHandler : SearchHandler
    {
        public IList<StudentModel> Students { get; set; }
        public string NavigationRoute { get; set; }
        public Type NavigationType { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Students.Where(student => student.Name.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            var navParam = new Dictionary<string, object>
                {
                    {"StudentDetailObj",item }
                };
            if (!string.IsNullOrWhiteSpace(NavigationRoute))
            {
                await Shell.Current.GoToAsync(NavigationRoute, navParam);
            }
            else if (NavigationType != null)
            {
                await Shell.Current.GoToAsync(GetNavigationPageName(), navParam);
            }
        }

        string GetNavigationPageName()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(NavigationType)).Key;
        }
    }
}
