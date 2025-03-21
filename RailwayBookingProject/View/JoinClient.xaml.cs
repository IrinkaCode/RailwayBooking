using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using javax.crypto;
using sun.security.util;
namespace RailwayBookingProject.View
{
    
    public partial class JoinClient : Window
    {
        public JoinClient()
        {
            InitializeComponent();
        }


             
        
// ...

        

        


        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ClientWindow personalAccountWindow = new ClientWindow();
            bool? result = personalAccountWindow.ShowDialog();
            if(result == true)
            {
                //добавление данных в БД
                this.Close();
            }

            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //GenerateJwtToken(Name, userName, userRole, secretKey);
        }


public string GenerateJwtToken(string userId, string userName, string userRole, string secretKey)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secretKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Name, userName),
            new Claim(ClaimTypes.Role, userRole)
        }),
            Expires = DateTime.UtcNow.AddHours(1), 
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

}
}
