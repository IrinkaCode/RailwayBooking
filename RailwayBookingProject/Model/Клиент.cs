using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RailwayBookingProject.Model
{
    public class Клиент : INotifyPropertyChanged
    {
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

        private string? имя;
        [JsonPropertyName("имя")]
        public string Имя
        {
            get => имя!;
            set
            {
                имя = value;
                OnProperyChanged(nameof(Имя));
            }
        }

        private string? фамилия;
        [JsonPropertyName("фамилия")]
        public string Фамилия
        {
            get => фамилия!;
            set
            {
                фамилия = value;
                OnProperyChanged(nameof(Фамилия));
            }
        }
        private string? email;
        [JsonPropertyName("email")]
        public string Email
        {
            get => email!;
            set
            {
                email = value;
                OnProperyChanged(nameof(Email));
            }
        }
        private string? passwordHash;
        [JsonPropertyName("passwordHash")]
        public string PasswordHash
        {
            get => passwordHash!;
            set
            {
                passwordHash = value;
                OnProperyChanged(nameof(PasswordHash));
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

        private ActionCommand registerCommand;
        public ICommand RegisterCommand => registerCommand ??= new ActionCommand(Register);

        private void Register()
        {
        }
    }

}
