using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Chess;

namespace ChessOpening
{
    public partial class Default : Page
    {
        private ChessOpeningEntities chessContext;

        protected void Page_Load(object sender, EventArgs e)
        {
            chessContext = new ChessOpeningEntities();
        }       

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxLastName.Text == "" || TextBoxFirstName.Text == "" || TextBoxCountry.Text == "" || TextBoxRating.Text == "" || TextBoxGames.Text == "")
            {
                labelMassage.Text = "Заполните пустые поля!";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            string lastName = textBoxLastName.Text;
            string firstName = TextBoxFirstName.Text;
            string country = TextBoxCountry.Text;
            byte gender = (byte)(ListGender.SelectedIndex + 1);
            byte rankPlayer = (byte)(ListRank.SelectedIndex + 1);
            
            try
            {
                Int16.Parse(TextBoxRating.Text);
            }
            catch(FormatException)
            {
                labelMassage.Text = "В поле \"рейтинг\" введите целое число!";
                labelMassage.ForeColor = Color.Red;
                return;
            }
            catch(OverflowException)
            {
                labelMassage.Text = "Рейтинг должен быть в диапазоне: 0 - 3000";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            short rating = Int16.Parse(TextBoxRating.Text);

            if (rating < 0 || rating >= 3000)
            {
                labelMassage.Text = "Рейтинг должен быть в диапазоне: 0 - 3000";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            try
            {
                Int16.Parse(TextBoxGames.Text);
            }
            catch (FormatException)
            {
                labelMassage.Text = "В поле \"игры\" введите целое число!";
                labelMassage.ForeColor = Color.Red;
                return;
            }
            catch(OverflowException)
            {
                labelMassage.Text = "В поле \"игры\" некорректное значение";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            short numGames = Int16.Parse(TextBoxGames.Text);

            if (numGames < 0)
            {
                labelMassage.Text = "Количество игр не может быть отрицательным";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            try
            {
                Player player = new Player
                {
                    LastName = lastName,
                    FirstName = firstName,
                    Country = country,
                    Gender = gender,
                    RankPlayer = rankPlayer,
                    Rating = rating,
                    NumberGames = numGames
                };

                chessContext.Players.Add(player);
                chessContext.SaveChanges();          
            }
            catch (Exception)
            {
                labelMassage.Text = "Заполните пустые поля!";
                labelMassage.ForeColor = Color.Red;
                return;
            }

            show();

            textBoxLastName.Text = String.Empty;
            TextBoxFirstName.Text = String.Empty;
            TextBoxCountry.Text = String.Empty;
            ListGender.SelectedIndex = 0;
            ListRank.SelectedIndex = 0;
            TextBoxRating.Text = String.Empty;
            TextBoxGames.Text = String.Empty;

            labelMassage.Text = "Игрок добавлен!";
            labelMassage.ForeColor = Color.Green;
        }

        protected void buttonShow_Click(object sender, EventArgs e)
        {
            show();
        }

        void show()
        {
            GridViewPlayers.DataSourceID = "PlayerData";
            labelMassage.Text = String.Empty;
        }

    }
}
    