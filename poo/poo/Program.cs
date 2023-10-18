namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            pneucs troca;
            pneucs  meuPneu = new pneucs(17,"Michelin",33,38,25,240,500);

            Carro carro = new Carro(" Chevrolet", " Seddan", " Branco", 1984, " Ka-187", 50, 100,160);
            carro.Ligar();
            carro.Acelerar(290);
        
            carro.Exibir();
            carro.PneuDianteiroEsquerdo = meuPneu;
            carro.Exibir();
            troca = carro.PneuDianteiroDireito;
            carro.PneuDianteiroDireito = carro.PneuDeEstepe;
            carro.PneuDeEstepe = troca;
        }
    }
}