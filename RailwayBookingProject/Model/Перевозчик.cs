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
    public class Перевозчик : INotifyPropertyChanged
    {
        private int idПеревозчика;

        [JsonPropertyName("idПеревозчика")]
        public int IdПеревозчика
        {
            get => idПеревозчика;
            set
            {
                idПеревозчика = value;
                OnProperyChanged(nameof(IdПеревозчика));
            }
        }

        private string? названиеПеревозчика;

        [JsonPropertyName("названиеПеревозчика")]
        public string НазваниеПеревозчика
        {
            get => названиеПеревозчика!;
            set
            {
                названиеПеревозчика = value;
                OnProperyChanged(nameof(НазваниеПеревозчика));
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
