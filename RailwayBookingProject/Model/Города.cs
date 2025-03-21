using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RailwayBookingProject.Model
{
    public class Города : INotifyPropertyChanged
    {
        private int idГорода;
        [JsonPropertyName("idГорода")]
        public int IdГорода
        {
            get => idГорода;
            set
            {
                idГорода = value;
                OnProperyChanged(nameof(IdГорода));
            }
        }

        private string? названиеГорода;

        [JsonPropertyName("названиеГорода")]
        public string НазваниеГорода
        {
            get => названиеГорода!;
            set
            {
                названиеГорода = value;
                OnProperyChanged(nameof(НазваниеГорода));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
