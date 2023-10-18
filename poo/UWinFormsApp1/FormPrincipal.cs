using poo;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace UWinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        Carro carro;
        public FormPrincipal()
        {
            InitializeComponent();
             carro = new Carro(" Chevrolet", " Seddan", " Branco", 1984, " Ka-187", 50, 100, 160);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carro.Frear(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pneucs pneu = null;

                switch (comboBoxPneu.SelectedIndex)

                {

                    case 0:
                        pneu = carro.PneuDianteiroEsquerdo;
                        carro.PneuDianteiroEsquerdo = carro.PneuDeEstepe;
                        break;

                    case 1:
                        pneu = carro.PneuDianteiroDireito;
                        carro.PneuDianteiroDireito = carro.PneuDeEstepe;
                        break;

                    case 2:
                        pneu = carro.PneuTraseiroEsquerdo;
                        carro.PneuTraseiroEsquerdo = carro.PneuDeEstepe;
                        break;

                    case 3:
                        pneu = carro.PneuTraseiroDireito;
                        carro.PneuTraseiroDireito = carro.PneuDeEstepe;
                        break;
                    default:
                        break;
                }


                if (pneu != null)
                    carro.PneuDeEstepe = pneu;
                Exibir();








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Exibir();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
         private void ExibirPneu(pneucs _pneu, TextBox _textBox)
         {
            _textBox.Text = "aro" + _pneu.aro;
            _textBox.Text = _textBox.Text + "\r\nMarca" + _pneu.Marca;
            _textBox.Text = _textBox.Text + "\r\nPSI" + _pneu.PSI;
            _textBox.Text = _textBox.Text + "\r\nPSIMaximo" + _pneu.PSIMaximo;
            _textBox.Text = _textBox.Text + "\r\nint PSIMINIMO"+_pneu.PSIMINIMO;
            _textBox.Text = _textBox.Text + "\r\nLARGURA"+_pneu.LARGURA;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeAtual"+_pneu.VelocidadeAtual;
            _textBox.Text = _textBox.Text + "\r\nPercentualBorracha"+_pneu.PercentualBorracha;
            _textBox.Text = _textBox.Text + "\r\nCargaMaxima"+_pneu.CargaMaxima;
            _textBox.Text = _textBox.Text + "\r\nEstourado" +_pneu.Estourado;
            _textBox.Text = _textBox.Text + "\r\nFurado" + _pneu.Furado;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeMaxima" + _pneu.VelocidadeMaxima;
            _textBox.Text = _textBox.Text + "\r\nCargaAtual" + _pneu.CargaAtual;
            _textBox.Text = _textBox.Text + "\r\nEstepe" + _pneu.Estepe;

            _textBox.BackColor = Color.White;
            if (_pneu.Estourado)
            {
                _textBox.BackColor = Color.Red;
            }
         }

        private void Exibir()
        {
            textBoxExibir.Text = "Marca :" + carro.Marca;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nModelo :" + carro.Modelo;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCor :" + carro.Cor;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nAno :" + carro.Ano;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPlaca :" + carro.Placa;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCapaciidadeDoTanque :" + carro.CapacidadeDoTanque;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPercentualDeCombustivel :" + carro.PercentualDeCombustivel;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nligado :" + carro.Ligado;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade maxima :" + carro.VelocidadeMaxima;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade atual :" + carro.VelocidadeAtual;

            ExibirPneu(carro.PneuDianteiroEsquerdo, textBoxDe);
            ExibirPneu(carro.PneuDianteiroDireito, textBoxDd);
            ExibirPneu(carro.PneuTraseiroDireito, textBoxTd);
            ExibirPneu(carro.PneuTraseiroEsquerdo, textBoxTe);
            ExibirPneu(carro.PneuDeEstepe, textBoxE);

            if (carro.Ligado)
            {
             
                buttonLigar.Text = "Ligar";
            }
            else
            {
                buttonLigar.Text = "Desligar";
        
            }
        
        }

        private void buttonLigar_Click(object sender, EventArgs e)
        {
            if (carro.Ligado)
            {
                carro.Desligar();
                buttonLigar.Text = "Ligar";
            }
            else
            {
                buttonLigar.Text = "Desligar";
                carro.Ligar();      
            }
            Exibir();
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            carro.Acelerar(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }
        }
    
}

