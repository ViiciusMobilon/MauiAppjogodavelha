using System;

namespace MauiJogoVelha
{
    public partial class MainPage : ContentPage
    {
        int ctdr = 0;
        string vez = "O";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {



            Button disparador = (Button)sender;
            disparador.IsEnabled = false;

            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
                ctdr = ctdr + 1;
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
                ctdr = ctdr + 1;
            }

            //x ganha linha 1
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha linha 2
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha linha 3 
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha coluna 1 
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha coluna 2
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha coluna 3
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha diagonal 1
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }
            //x ganha diagonal 2
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
                limpa();
            }

            //o ganha linha 1
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha linha 2
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha linha 3 
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha coluna 1 
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha coluna 2
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha coluna 3
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha diagonal 1
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }
            //o ganha diagonal 2
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
                limpa();
            }


            else if (ctdr == 9)
            {
                DisplayAlert("Deu velha", "Ninguém venceu", "Fechar");
                limpa();
            }

        }//fim btn clicked
        private void limpa()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;

            btn11.Text = "";
            btn11.IsEnabled = true;

            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;

            btn21.Text = "";
            btn21.IsEnabled = true;

            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;

            btn31.Text = "";
            btn31.IsEnabled = true;

            btn32.Text = "";
            btn32.IsEnabled = true;

            ctdr = 0;
        }


    }



}
