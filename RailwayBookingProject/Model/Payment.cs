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
    public class Payment : INotifyPropertyChanged
    {
        private int оплатаId;
        [JsonPropertyName("оплатаId")]
        public int ОплатаId
        {
            get => оплатаId;
            set
            {
                оплатаId = value;
                OnProperyChanged(nameof(ОплатаId));
            }
        }

        private int билетId;
        [JsonPropertyName("билетId")]
        public int БилетId
        {
            get => билетId;
            set
            {
                билетId = value;
                OnProperyChanged(nameof(БилетId));
            }
        }

        private int idКлиента;
        [JsonPropertyName("idКлиента")]
        public int IdКлиента
        {
            get => idКлиента;
            set
            {
                idКлиента = value;
                OnProperyChanged(nameof(IdКлиента));
            }
        }

        private DateTime датаОплаты;
        [JsonPropertyName("датаОплаты")]
        public DateTime ДатаОплаты
        {
            get => датаОплаты;
            set
            {
                датаОплаты = value;
                OnProperyChanged(nameof(ДатаОплаты));
            }
        }

        private decimal сумма;
        [JsonPropertyName("сумма")]
        public decimal Сумма
        {
            get => сумма;
            set
            {
                сумма = value;
                OnProperyChanged(nameof(Сумма));
            }
        }

        private string? статус;
        [JsonPropertyName("статус")]
        public string Статус
        {
            get => статус!;
            set
            {
                статус = value;
                OnProperyChanged(nameof(Статус));
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
