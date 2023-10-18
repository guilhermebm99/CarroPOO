using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Cor { get; set; }

        public int Ano { get; set; }

      
        public string Placa { get; set; }





        private pneucs pneuDianteiroEsquerdo;
        public pneucs PneuDianteiroEsquerdo
        {
            get
            {
                return pneuDianteiroEsquerdo;
            }
            set
            {
                if (VelocidadeAtual > 0)
                {
                    throw new Exception("Vai trocar o pneu com carro andando ? Pare o carro.");
                }
                if (Ligado)
                {
                    throw new Exception("desligue o carro");
                }
              
                pneuDianteiroEsquerdo = value;
            }

        }

        public pneucs PneuDianteiroDireito { get; set; }

        public pneucs PneuTraseiroEsquerdo { get; set; }

        public pneucs PneuTraseiroDireito { get; set; }


        public pneucs PneuDeEstepe { get; set; }

        public int CapacidadeDoTanque { get; set; }

        public int PercentualDeCombustivel { get; set; }

        public bool Ligado { get; set; }

        public int VelocidadeMaxima { get; set; }

        public int VelocidadeAtual { get; set; }

        public Carro(string marca, string modelo, string cor, int ano, string _placa, int capacidadeDoTanque, int percentualDeCombustivel, int _velocidadeMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Placa = _placa;
            PneuDianteiroEsquerdo = new pneucs(13, "Michelin", 33, 38, 25, 240, 500);
            PneuDianteiroDireito = new pneucs(13, "Michelin", 33, 38, 25, 240, 500);
            PneuTraseiroEsquerdo = new pneucs(13, "Michelin", 33, 38, 25, 240, 500);
            PneuTraseiroDireito = new pneucs(13, "Michelin", 33, 38, 25, 240, 500);
            PneuDeEstepe = new pneucs(13, "Michelin", 33, 38, 25, 70, 500, true);
            CapacidadeDoTanque = capacidadeDoTanque;
            PercentualDeCombustivel = percentualDeCombustivel;
            Ligado = false;
            VelocidadeAtual = 0;
            VelocidadeMaxima = _velocidadeMaxima;
        }


        public void Ligar()
        {

            if (PercentualDeCombustivel > 0)
            {

                Ligado = true;
                PercentualDeCombustivel = PercentualDeCombustivel - 1;

            }



        }

        public void Desligar()
        {


            Ligado = false;
            Parar();





        }


        public void Acelerar(int _impulso)
        {

            PercentualDeCombustivel -= 5;


            if (!Ligado)
            {
                Console.WriteLine("O carro está desligado");
                return;


            }

            VelocidadeAtual += _impulso;
            PneuDianteiroDireito.Acelerar(_impulso);
            PneuDianteiroEsquerdo.Acelerar(_impulso);
            PneuTraseiroDireito.Acelerar(_impulso);
            PneuTraseiroEsquerdo.Acelerar(_impulso);
            CarroestaOperacional();



        }

        private bool CarroestaOperacional()
        {
            if (PercentualDeCombustivel <= 0)
            {
                PercentualDeCombustivel = 0;
                Console.WriteLine("O carro está sem combustivel");
                Desligar();
                VelocidadeAtual = 0;
                return false;

            }
            if (PneuDianteiroDireito.Estourado || PneuDianteiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro direito");
                //TODO FAZER UM MÉTDODO PARA VALIDAR SE O PNEU ESTÁ OPERACIONAL
                Parar();
                return false;
            }
            if (PneuDianteiroEsquerdo.Estourado || PneuDianteiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o pneu dianteiro esquerdo");
                //TODO FAZER UM MÉTDODO PARA VALIDAR SE O PNEU ESTÁ OPERACIONAL
                Parar();
                return false;
            }


            return true;



        }

        public void Frear(int _impulso)
        {

            VelocidadeAtual -= _impulso;
            PneuDianteiroDireito.Frear(_impulso);
            PneuDianteiroEsquerdo.Frear(_impulso);
            PneuTraseiroDireito.Frear(_impulso);
            PneuTraseiroEsquerdo.Frear(_impulso);

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;


        }

        public void Exibir()

        {
            Console.WriteLine("Marca :" + Marca);
            Console.WriteLine("Modelo :" + Modelo);
            Console.WriteLine("Cor :" + Cor);
            Console.WriteLine("Ano :" + Ano);
            Console.WriteLine("Placa :" + Placa);
            Console.WriteLine("CapaciidadeDoTanque :" + CapacidadeDoTanque);
            Console.WriteLine("PercentualDeCombustivel :" + PercentualDeCombustivel);
            Console.WriteLine("ligado :" + Ligado);
            Console.WriteLine("Velocidade maxima :" + VelocidadeMaxima);
            Console.WriteLine("Velocidade atual :" + VelocidadeAtual);


            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuEstepe");
            PneuDeEstepe.Exibir();




        }


        private void Parar()
        {

            Frear(VelocidadeAtual);






        }









    }
}
