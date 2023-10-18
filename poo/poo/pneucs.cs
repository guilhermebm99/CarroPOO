

namespace poo
{
    public class pneucs
    {
        public int aro { get; set; }
        public string Marca { get; set; }
        public int PSI { get; set; }
        public int PSIMaximo { get; set; }

        public int PSIMINIMO { get; set; }
        public int LARGURA { get; set; }
        public int VelocidadeAtual { get; set; }
        public int PercentualBorracha { get; set; }
        public int CargaMaxima { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int CargaAtual { get; private set; }
        public bool Estepe { get; set; }

        public pneucs(int _aro, string _marca, int pSi, int _pSIMAXIMO,int _largura, int _velocidadeMaxima, int _cargaMaxima, bool _estepe = false)
        {
            aro = _aro;
            Marca = _marca;
            PSI = pSi;
            PSIMaximo = _pSIMAXIMO;
            PSIMINIMO = 0;
            LARGURA = _largura; 
            PercentualBorracha = 100;
            VelocidadeMaxima = _velocidadeMaxima;
            VelocidadeAtual = 0;
            CargaMaxima = _cargaMaxima;
            CargaAtual = 0;
            Estourado = false;
            Furado = false;
            Estepe = _estepe;












        }
        public void Exibir()
        {


               Console.WriteLine("\n\nAro :" + aro);
               Console.WriteLine("Marca :" + Marca);
               Console.WriteLine("PSI :" + PSI);
               Console.WriteLine("PSIMAXIMO :" + PSIMaximo);
               Console.WriteLine("PSIMINIMO :" + PSIMINIMO);
               Console.WriteLine("Largura :" + LARGURA);
               Console.WriteLine("PercentualBorracha :" + PercentualBorracha);
               Console.WriteLine("VelocidadeMaxima :" + VelocidadeMaxima);

               Console.WriteLine("VelocidadeAtual :"+ VelocidadeAtual);
               Console.WriteLine("CargaMaxima :" + CargaMaxima);
               Console.WriteLine("CargaAtual :" + CargaAtual);
               Console.WriteLine("Estourado :" + Estourado);
               Console.WriteLine("Furado :" + Furado);











        }









        public void Acelerar(int impulso)
        {
            if (Furado || Estourado)
            {
                string estado;
                estado = Furado ? "furado" : "estourado";


                
                Console.WriteLine($"O peneu esta {estado}");
                return;

            }
                


            VelocidadeAtual = VelocidadeAtual + impulso;
            PercentualBorracha = PercentualBorracha - 2;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

            if (PercentualBorracha < 0)
                PercentualBorracha = 0;



            EstourarPneu();
          


        }


        public void Frear(int impulso)
        {



            if (VelocidadeAtual > 0)
            {
                VelocidadeAtual = VelocidadeAtual - impulso;
                PercentualBorracha = PercentualBorracha - 5;

                if (VelocidadeAtual < 0)
                    VelocidadeAtual = 0;

                if (PercentualBorracha < 0)
                    PercentualBorracha = 0;


            }


            EstourarPneu();

        }

        private void EstourarPneu()
        {
            if (PercentualBorracha < 30 || VelocidadeAtual > VelocidadeMaxima 
                || PSI > PSIMaximo ||
                CargaAtual > CargaMaxima)
            {
                Estourado = true;
                VelocidadeAtual = 0;


            }
        }

        public void Furar(int impulso)
        {

            Furado = true;

        }


        public void Remendar(int impulso)
        {

            Furado = false;

        }

      
    }
}
